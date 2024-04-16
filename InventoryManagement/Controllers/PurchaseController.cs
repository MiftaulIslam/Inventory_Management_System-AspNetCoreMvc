using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly InventoryManagementContext _context;

        //Constructor defination
        public PurchaseController(InventoryManagementContext context)
        {
            _context = context;
        }


               // Helper method to generate random characters
        private string GenerateRandomChars(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        public IActionResult ManagePurchase()
        {
            ViewData["VendorCompany"] = new SelectList(_context.Vendors, "Id", "VendorCompanyName");
            
            return View();
        }
        [HttpPost]
        public JsonResult GetPurchase()
        {
            var purchases = _context.Purchases.ToList();
            return Json(new { Data = purchases });
        }

 
        public IActionResult GetPurchaseById(int id)
        {
            if (id <= 0) return BadRequest("Invalid Id");
            var purchase = _context.Purchases.Find(id);

            if (purchase != null)
            {
                return Json(purchase);
            }

            return Json("Something went wrong!");
        }


 

        //Add purchase
        [HttpPost]

        public IActionResult Addpurchase(Purchase purchase)
        {
            if (!string.IsNullOrEmpty(purchase.MemoNumber))
            {
                purchase.PurchaseDate = DateTime.Today;
                purchase.UpdateAt = DateTime.Today;

                purchase.PurchaseDiscountAmount = purchase.PurchaseTotalPrice - (purchase.PurchaseTotalPrice * (purchase.PurchaseDiscountPercentage / 100));


                if(purchase.PurchaseDiscountAmount != 0){
                purchase.PurchaseDueAmount = purchase.PurchaseDiscountAmount - purchase.PurchasePaidAmount;
                }

                
                purchase.PurchaseSn = _context.Purchases.Count() + 1;
                if (purchase.VendorId >= 0)
                {
                    var vendor = _context.Vendors.Find(purchase.VendorId);
                    if (vendor == null) return BadRequest("Invalid Vendor");

                    string VendorCompnayName = vendor.VendorCompanyName[..3];

                    string memoNumber = $"{DateTime.Today:yyyyMMdd}-{VendorCompnayName}-{GenerateRandomChars(4)}";

                    purchase.MemoNumber = memoNumber;

                    // Update vendor's values based on purchase
                    vendor.TotalAmount += purchase.PurchaseTotalPrice;
                    vendor.TotalDiscount += purchase.PurchaseDiscountAmount;
                    vendor.ReturnAmount += purchase.PurchaseReturnAmount;
                    vendor.Paid += purchase.PurchasePaidAmount;
                    vendor.Due += purchase.PurchaseDueAmount;

                    _context.Vendors.Update(vendor);
                    _context.SaveChanges();
                }

                if (purchase.PurchaseDueAmount == 0)
                {
                    purchase.PurchasePaymentStatus = "Paid";
                }else{
                    purchase.PurchasePaymentStatus = "Un-Paid";

                }
                _context.Purchases.Add(purchase);
                _context.SaveChanges();
                return Json("Successfully created Purchase Log");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();
                return Json($"Failed to create Purchase Log due to invalid model state: {string.Join(", ", errors)}");
            }
        }

        public IActionResult UpdatePurchase(Purchase purchase)
        {
            if (purchase == null) return Json("Invalid Credentials");
            var id = purchase.Id;
            if (purchase.MemoNumber != "")
            {
                var Existingpurchase = _context.Purchases.Find(id);
                if (Existingpurchase == null) return BadRequest("purchase Not found");

                Existingpurchase.PurchasePaidAmount += purchase.PurchasePaidAmount;

                Existingpurchase.PurchaseDueAmount = Existingpurchase.PurchaseDiscountAmount - Existingpurchase.PurchasePaidAmount;

                var vendor = _context.Vendors.Find(Existingpurchase.VendorId);

                vendor.Paid += purchase.PurchasePaidAmount;

                vendor.Due = vendor.TotalDiscount - vendor.Paid;

                Existingpurchase.PurchasePaymentStatus = purchase.PurchasePaymentStatus;

                Existingpurchase.UpdateAt = DateTime.Today;


                 if (Existingpurchase.PurchaseDueAmount == 0)
                {
                    Existingpurchase.PurchasePaymentStatus = "Paid";
                }else{
                    Existingpurchase.PurchasePaymentStatus = "Un-Paid";

                }


                _context.Vendors.Update(vendor);
                _context.Purchases.Update(Existingpurchase);
                _context.SaveChanges();
                return Json("Successfully updated purchase");
            }
            else
            {
                // Handle invalid model state
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();
                return Json($"Failed to create product due to invalid model state: {string.Join(", ", errors)}");

            }
        }
        [HttpPost]
        public IActionResult Deletepurchase(int id)
        {
            if (id < 0) return BadRequest("Id invalid");
            var purchase = _context.Purchases.Find(id);
            if (purchase == null) return NotFound("purchase not found");

            var vendor = _context.Vendors.Find(purchase.VendorId);

            vendor.TotalAmount -= purchase.PurchaseTotalPrice; 
            vendor.TotalDiscount -= purchase.PurchaseDiscountAmount; 
            vendor.Paid -= purchase.PurchasePaidAmount; 
            vendor.Due -= purchase.PurchaseDueAmount; 
            _context.Vendors.Update(vendor);
            _context.Purchases.Remove(purchase);
            _context.SaveChanges();
            return Json("purchase Successfully Deleted");
        }
        public IActionResult ManagePurchaseList()
        {
             ViewData["Product"] = new SelectList(_context.Products, "Id", "ProductName");
             ViewData["Purchase"] = new SelectList(_context.Purchases, "Id", "MemoNumber");

            return View();
        }
        public IActionResult GetPurchaseListById(int id)
        {
            var PurchaseList = _context.PurchaseLists.Find(id);

            return Json(PurchaseList);
        }
        public JsonResult GetPurchaseLists()
        {
            var purchaseLists = _context.PurchaseLists.ToList();
            return Json(new { data = purchaseLists });
        }
        [HttpPost]
        public IActionResult AddPurchaseList(PurchaseList purchaseList)
        {
            if (purchaseList.PurchaseId > 0)
            {
                purchaseList.Id = 0;
                purchaseList.PurchaseItemTime = DateTime.Today;
                var product = _context.Products.Find(purchaseList.ProductId);
                if(product == null) BadRequest("Product does not exist");

                string PCode = $"{DateTime.Today:yyyyMMdd}-{product.ProductName[..3]}-{GenerateRandomChars(4)}";

                _context.PurchaseLists.Add(purchaseList);
                _context.SaveChanges();
                ProductStock ProductStock = new ProductStock{
                    ProductCode = PCode,
                    ProductId = product.Id,
                    PurchaseListId = purchaseList.Id,
                    IsSold = false,
                    IsDamage = false,
                    InsertDate = DateTime.Today
                };
                _context.ProductStocks.Add(ProductStock);
                _context.SaveChanges();
                return Json("Successfully created purchaseList Log");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();
                return Json($"Failed to create purchaseList Log due to invalid model state: {string.Join(", ", errors)}");

            }
        }
        [HttpPost]
        public IActionResult UpdatePurchaseList(PurchaseList purchaseList)
        {
            if (purchaseList == null) return Json("Invalid Credentials");
            var id = purchaseList.Id;
            if (purchaseList.PurchaseId > 0)
            {
                var ExistingPurchaseList = _context.PurchaseLists.Find(id);
                if (ExistingPurchaseList == null) return BadRequest("purchase Not found");
                ExistingPurchaseList.PurchaseId = purchaseList.PurchaseId;
                ExistingPurchaseList.ProductId = purchaseList.ProductId;
                ExistingPurchaseList.Description = purchaseList.Description;
                ExistingPurchaseList.Warranty = purchaseList.Warranty;
                ExistingPurchaseList.Note = purchaseList.Note;
                ExistingPurchaseList.SellingPrice = purchaseList.SellingPrice;
                ExistingPurchaseList.PurchasePrice = purchaseList.PurchasePrice;

                _context.PurchaseLists.Update(ExistingPurchaseList);
                _context.SaveChanges();
                return Json("Successfully updated PurchaseList");
            }
            else
            {
                // Handle invalid model state
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();
                return Json($"Failed to create PurchaseList due to invalid model state: {string.Join(", ", errors)}");

            }
        }
        [HttpPost]
        public IActionResult DeletePurchaseList(int id)
        {
            if (id < 0) return BadRequest("Id invalid");
            var purchaselist = _context.PurchaseLists.Find(id);
            if (purchaselist == null) return NotFound("purchaselist not found");
            _context.PurchaseLists.Remove(purchaselist);
            _context.SaveChanges();
            return Json("purchaselist Successfully Deleted");
        }

    }
}
