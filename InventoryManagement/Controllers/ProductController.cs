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
    public class ProductController : Controller
    {
        private readonly InventoryManagementContext _context;

        //Constructor defination
        public ProductController(InventoryManagementContext context)
        {
            _context = context;
        }

        //Sector: Product Stock
        //View
        public IActionResult ManageStock(){
            return View();
        }
        
        //For Jquery DataTable
        public JsonResult GetStock(){
            var stocks = _context.ProductStocks.ToList();
            return Json(new {Data=stocks});
        }


        //Get a specific stock
        public IActionResult GetStockById(int id){
            if (id <= 0)return BadRequest("Invalid Id");
            var stocks = _context.ProductStocks.Find(id);

            if (stocks != null){
                return Json(stocks);
            }
            
            return Json("Something went wrong!");
        }

        public IActionResult ManageProduct()
        {
            ViewData["productcatalog"] = new SelectList(_context.ProductCatalog, "Id", "CatalogName");

            return View();
        }


        [HttpPost]
        public JsonResult GetProducts()
        {

            var products = _context.Products.ToList();
            return Json(new { Data = products });
        }


        //Add catalog
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (product.ProductName != "")
            {
                // Set insert and update dates
                product.InsertDate = DateTime.Today;
                product.UpdatedAt = DateTime.Today;

                // Check if an image was uploaded
                if (product.Image != null)
                {
                    // Read the image data into a byte array
                    using (var memoryStream = new MemoryStream())
                    {
                        product.Image?.CopyTo(memoryStream);
                        product.ProductImage = memoryStream.ToArray(); // Save the byte array to the ProductImage property
                    }
                }

                // Add the product to the database
                _context.Products.Add(product);
                _context.SaveChanges();

                return Json("Successfully created product");
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
        //Update catalog
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {

            if (product == null) return Json("Invalid Credentials");
            
                var id = product.Id;
            if (product.ProductName != "")
            {
                var ExistingProduct = _context.Products.Find(id);
                if (ExistingProduct == null) return BadRequest("Product not found");
                // Check if an image was uploaded
                if (product.Image != null)
                {
                    // Read the image data into a byte array
                    using (var memoryStream = new MemoryStream())
                    {
                        product.Image?.CopyTo(memoryStream);
                        ExistingProduct.ProductImage = memoryStream.ToArray(); // Save the byte array to the ProductImage property
                    }
                }

                // Set insert and update dates
                ExistingProduct.ProductName = product.ProductName;
                ExistingProduct.Description = product.Description;
                ExistingProduct.Warranty = product.Warranty;
                ExistingProduct.Note = product.Note;
                ExistingProduct.SellingPrice = product.SellingPrice;
                ExistingProduct.ProductCatalogId = product.ProductCatalogId;
                ExistingProduct.UpdatedAt = DateTime.Today;

            //    _context.Entry(ExistingProduct).State = EntityState.Detached;
                // Add the product to the database
                _context.Products.Update(ExistingProduct);
                _context.SaveChanges();

                return Json("Successfully updated product");
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
        public IActionResult DeleteProduct(int id)
        {
            if (id <= 0) return BadRequest("Id Invalid");
            var product = _context.Products.Find(id);
            if (product == null) return NotFound("Product not found");

            _context.Products.Remove(product);
            _context.SaveChanges();
            return Json("Product Successfully Deleted");
        }
        //---------------------Sector: ProductCatalog---------------------
        //Get a specific catalog
        [HttpGet]
        public IActionResult getCatalogById(int id)
        {
            if (id <= 0) return BadRequest("ID is invalid.");

            var catalog = _context.ProductCatalog.Find(id);
            if (catalog == null) return NotFound("Catalog not found");
            return Json(catalog);
        }



        //View for ProductCatalog
        public IActionResult ProductCatalog()
        {
            //Creating a selectList options will be the parent catalog. The parent catalogs are the catalog that has catalog level 1. 
            var parentCatalogs = _context.ProductCatalog
                            .Where(x => x.CatalogLevel == 1)
                            .ToList();

            //Passing productcatalogType selectList through ViewData
            ViewData["productcatalog"] = new SelectList(_context.ProductCatalogTypes, "Id", "CatalogType");
            //Passing ParentCatalogs selectList through ViewData
            ViewData["parentcatalog"] = new SelectList(parentCatalogs, "Id", "CatalogName");
            return View();
        }

        //Used for the jquery datatable
        [HttpPost]
        public JsonResult GetProductCatalogs()
        {
            var ProductCatalog = _context.ProductCatalog.ToList();
            return Json(new { data = ProductCatalog });
        }


        //Add catalog
        [HttpPost]
        public IActionResult AddCatalog(ProductCatalog catalog)
        {
            //The form will be invalid because of the insertdate and updatedate. To fix the issue, a different kind of validation needed.
            if (catalog.CatalogName != "")
            {
                //The insertdate coming from the view is not valid so setting a valid insertdate through C#. Same thing goes for the insertdate
                catalog.InsertDate = DateTime.Today;
                catalog.UpdateAt = DateTime.Today;
                //Other fields are ok so we can add the object to our database
                _context.ProductCatalog.Add(catalog);
                _context.SaveChanges();
                return Json("Successfully created product catalog");
            }
            else
            {
                //check each field and if any field occurs error it will show the error message with the field name. 
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage)
                                              .ToList();
                return Json($"Failed to create product catalog due to invalid model state: {string.Join(", ", errors)}");
            }
        }

        //update catalogtype
        [HttpPost]
        public IActionResult UpdateCatalog(ProductCatalog catalogdata)
        {
            if (catalogdata == null) return Json("Invalid Credentials");

            if (catalogdata.CatalogName != "")
            {
                var id = catalogdata.Id;

                var catalog = _context.ProductCatalog.Find(id);
                if (catalog == null) return NotFound("Catalog not found");

                //updating the specific catalog with the new values come from the view
                catalog.CatalogName = catalogdata.CatalogName;
                catalog.CatalogLevel = catalogdata.CatalogLevel;
                catalog.ItemCount = catalogdata.ItemCount;
                catalog.ParentId = catalogdata.ParentId;
                catalog.CatalogTypeId = catalogdata.CatalogTypeId;
                catalog.UpdateAt = DateTime.Today;
                _context.ProductCatalog.Update(catalog);
                _context.SaveChanges();
                return Json("Successfully updated product catalog ");
            }
            else
            {
                //check each field and if any field occurs error it will show the error message with the field name. 
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage)
                                              .ToList();
                return Json($"Failed to create product catalog due to invalid model state: {string.Join(", ", errors)}");
            }
        }

        //Deleting a catalog

        [HttpPost]
        public IActionResult DeleteCatalog(int id)
        {
            if (id <= 0) return BadRequest("Invalid Id");

            //Retriving the specific catalog. Using the include and singleordefault approach because we need to query through the catalog

            var catalog = _context.ProductCatalog.Include(c => c.InverseParent)
                                                 .SingleOrDefault(c => c.Id == id);

            if (catalog == null) return NotFound("Catalog not found");
            //With the help of the include approach, now we have the inverseParent array that contains the child catalogs.
            // Remove the catalog from its parent's inverse collection
            DeleteInverseCatalog(catalog);
            //After removing the child catalog, remove the primary catalog
            _context.ProductCatalog.Remove(catalog);
            _context.SaveChanges();

            return Json("Successfully deleted catalog");
        }

        private void DeleteInverseCatalog(ProductCatalog Catalog)
        {
            if (Catalog == null) return;

            foreach (var item in Catalog.InverseParent)
            {
                _context.ProductCatalog.Remove(item);
            }

        }

        //---------------------Sector: ProductCatalogType---------------------
        public IActionResult ProductCatalogType()
        {
            return View();
        }

        //Get a specific product catalog type
        [HttpGet]
        public IActionResult getProductCatalogTypeById(int id)
        {
            if (id <= 0) return BadRequest("Id Invalid ");
            var catalogType = _context.ProductCatalogTypes.Find(id);
            if (catalogType == null) return NotFound("Cannot find the catalog type");
            return Json(catalogType);
        }

        //Post request used for jquery datatable
        [HttpPost]
        public JsonResult GetProductCatalogTypes()
        {
            var ProductCatalogTypes = _context.ProductCatalogTypes.ToList();
            return Json(new { data = ProductCatalogTypes });
        }

        //Add catalogtype
        [HttpPost]
        public IActionResult AddCatalogType(ProductCatalogType TypeName)
        {
            //The form will be invalid because of the insertdate and updatedate. To fix the issue, a different kind of validation needed.
            if (TypeName.CatalogType != null)
            {
                //The insertdate coming from the view is not valid so setting a valid insertdate through C#. Same thing goes for the insertdate
                TypeName.InsertDate = DateTime.Today;
                TypeName.UpdatedAt = DateTime.Today;
                //Other fields are ok so we can add the object to our database
                _context.ProductCatalogTypes.Add(TypeName);
                _context.SaveChanges();
                return Json("Successfully created product catalog type");
            }
            else
            {

                //check each field and if any field occurs error it will show the error message with the field name. 
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage)
                                              .ToList();
                return Json($"Failed to create product catalog type due to invalid model state: {string.Join(", ", errors)}");
            }
        }

        //update catalogtype
        [HttpPost]
        public IActionResult UpdateCatalogType(ProductCatalogType TypeName)
        {

            //The form will be invalid because of the insertdate and updatedate. To fix the issue, a different kind of validation needed.
            if (TypeName.CatalogType != null)
            {

                var id = TypeName.Id;

                var catalogTypeName = _context.ProductCatalogTypes.Find(id);
                if (catalogTypeName == null) return NotFound();
                //updating the specific catalog with the new values come from the view
                catalogTypeName.CatalogType = TypeName.CatalogType;
                catalogTypeName.InsertDate = TypeName.InsertDate;
                catalogTypeName.UpdatedAt = DateTime.Today;
                _context.ProductCatalogTypes.Update(catalogTypeName);
                _context.SaveChanges();
                return Json("Successfully updated product catalog type");
            }
            else
            {

                //check each field and if any field occurs error it will show the error message with the field name. 
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage)
                                              .ToList();
                return Json($"Failed to create product catalog type due to invalid model state: {string.Join(", ", errors)}");
            }
        }
        public IActionResult DeleteCatalogType(int id)
        {
            if (id <= 0)
            {
                return BadRequest("CatalogType ID is invalid.");
            }


            //Retriving the specific catalog. Using the include and singleordefault approach because we need to query through the catalog

            var catalogType = _context.ProductCatalogTypes
                                      .Include(ct => ct.ProductCatalog)
                                      .FirstOrDefault(ct => ct.Id == id);

            if (catalogType == null)
            {
                return NotFound("CatalogType not found.");
            }

            // Recursively delete all related ProductCatalogs and their children
            //At first it will delete all the child catalogs of the related catalogs. Then it will delete delete all the parent catalogs.
            DeleteCatalogAndChildren(catalogType.ProductCatalog.ToList());

            // In the end, it will delete the CatalogType
            _context.ProductCatalogTypes.Remove(catalogType);
            _context.SaveChanges();

            return Json("Successfully deleted the CatalogType and all related ProductCatalogs.");
        }

        private void DeleteCatalogAndChildren(List<ProductCatalog> catalogs)
        {
            if (catalogs == null) return;

            foreach (var catalog in catalogs)
            {
                // Recursively delete children of the current catalog
                DeleteCatalogAndChildren(catalog.InverseParent?.ToList());

                // Delete the current catalog
                _context.ProductCatalog.Remove(catalog);
            }
        }



    }
}
