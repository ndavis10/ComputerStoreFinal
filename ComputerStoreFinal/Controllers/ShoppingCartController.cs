using ComputerStoreFinal.DataContexts;
using ComputerStoreFinal.ViewModels;
using ComputerStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ComputerStoreFinal.Controllers
{
    public class ShoppingCartController : Controller
    {
        ComputerStoreDb ComputerStoreDb = new ComputerStoreDb();
        // GET: ShoppingCart
            
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal() 
            };
            //Returns the view
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddToCart(FormCollection form)
        {
            string mobo = Request.Form["Motherboard"];
            string cpu = Request.Form["CPU"];
            string memory = Request.Form["Memory"];
            string gpu = Request.Form["GPU"];
            string hardDrive = Request.Form["Hard Drive"];
            string cabinet = Request.Form["Case"];
            string powerSupply = Request.Form["Power Supply"];

            int id = Int32.Parse(mobo);
            var addedPart = ComputerStoreDb.Parts.Single(addPart => addPart.PartID == id);
            // Add the part in the shopping cart
            var cart = ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(addedPart);

            id = Int32.Parse(cpu);
            addedPart = ComputerStoreDb.Parts.Single(addPart => addPart.PartID == id);
            
            cart.AddToCart(addedPart);

            id = Int32.Parse(memory);
            addedPart = ComputerStoreDb.Parts.Single(addPart => addPart.PartID == id);
            
            cart.AddToCart(addedPart);

            id = Int32.Parse(gpu);
            addedPart = ComputerStoreDb.Parts.Single(addPart => addPart.PartID == id);
            
            cart.AddToCart(addedPart);

            /*id = Int32.Parse(hardDrive);
            addedPart = ComputerStoreDb.Parts.Single(addPart => addPart.PartID == id);
            
            cart.AddToCart(addedPart);*/

            id = Int32.Parse(cabinet);
            addedPart = ComputerStoreDb.Parts.Single(addPart => addPart.PartID == id);
            cart.AddToCart(addedPart);

            id = Int32.Parse(powerSupply);
            addedPart = ComputerStoreDb.Parts.Single(addPart => addPart.PartID == id);
            
            cart.AddToCart(addedPart);

            return RedirectToAction("Index");
        }

        /*public ActionResult AddToCart(int? id)
        {
            // Retrive the part from the database
            if (id != null)
            {
                var addedPart = ComputerStoreDb.Parts.Single(part => part.PartID == id);
                // Add the part in the shopping cart
                var cart = ShoppingCart.GetCart(this.HttpContext);

                cart.AddToCart(addedPart);
            }
            //go back to the part page for more parts
            return RedirectToAction("Index");
        }*/
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            //remove item from cart
            var cart = ShoppingCart.GetCart(this.HttpContext);
            //get the name of the part to display confirmation
            string PartName = ComputerStoreDb.Carts.Single(item => item.RecordID == id).Part.PartName;

            //Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            //Display Confirmation Message
            var results = new ShoppingCartRemoveModel
            {
                Message = Server.HtmlEncode(PartName) + "  removed  from  cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteID = id
               
            };
            return Json(results);
        }
    }
}