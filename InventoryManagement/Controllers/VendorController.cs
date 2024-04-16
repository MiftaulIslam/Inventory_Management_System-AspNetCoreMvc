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
    public class VendorController : Controller
    {
        private readonly InventoryManagementContext _context;

        //Constructor defination
        public VendorController(InventoryManagementContext context)
        {
            _context = context;
        }
        public IActionResult ManageVendor(){
            return View();
        }
        [HttpPost]
        public JsonResult GetVendors(){
            var vendors = _context.Vendors.ToList();
            return Json(new {Data=vendors});
        }

        //Add vendor
        [HttpPost]

        public IActionResult AddVendor(Vendor vendor){
            if(vendor.VendorName != ""){
                
                if(vendor.Photo != null){
                    using(var memoryStream = new MemoryStream()){
                        vendor.Photo?.CopyTo(memoryStream);
                        vendor.VendorPhoto = memoryStream.ToArray();
                    }
                }
                
            _context.Vendors.Add(vendor);
            _context.SaveChanges();
            return Json("Successfully created Vendor");
            }else{
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();
                return Json($"Failed to create vendor due to invalid model state: {string.Join(", ", errors)}");

            }
        }
        [HttpPost]
        public IActionResult UpdateVendor(Vendor vendor){
            if(vendor == null) return Json("Invalid Credentials");
            var id = vendor.Id;
            if(vendor.VendorName != ""){
                var ExistingVendor = _context.Vendors.Find(id);
                if(ExistingVendor == null) return BadRequest("Vendor Not found");
                if(vendor.Photo != null){
                      // Read the image data into a byte array
                    using (var memoryStream = new MemoryStream())
                    {
                        vendor.Photo?.CopyTo(memoryStream);
                        ExistingVendor.VendorPhoto = memoryStream.ToArray(); // Save the byte array to the ProductImage property
                    }
                }

                ExistingVendor.VendorCompanyName = vendor.VendorCompanyName;
                ExistingVendor.VendorName = vendor.VendorName;
                ExistingVendor.VendorAddress = vendor.VendorAddress;
                ExistingVendor.VendorPhone = vendor.VendorAddress;
                ExistingVendor.Description = vendor.Description;
                ExistingVendor.TotalAmount = vendor.TotalAmount;
                ExistingVendor.TotalDiscount = vendor.TotalDiscount;
                ExistingVendor.ReturnAmount = vendor.ReturnAmount;
                ExistingVendor.Paid = vendor.Paid;
                ExistingVendor.Due = vendor.Due;
                _context.Vendors.Update(ExistingVendor);
                _context.SaveChanges();
                return Json("Successfully updated Vendor");
            }else{
                   // Handle invalid model state
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                               .Select(e => e.ErrorMessage)
                                               .ToList();
                return Json($"Failed to create product due to invalid model state: {string.Join(", ", errors)}");
            
            }
        }
        [HttpPost]
        public IActionResult DeleteVendor(int id){
            if (id < 0) return BadRequest("Id invalid");
            var vendor = _context.Vendors.Find(id);
            if (vendor == null) return NotFound("Vendor not found");
            _context.Vendors.Remove(vendor);
            _context.SaveChanges();
            return Json("Vendor Successfully Deleted");
        }
    }
}
