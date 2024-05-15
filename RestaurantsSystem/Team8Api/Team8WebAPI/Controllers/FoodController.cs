using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using Team8WebAPI.Models;

namespace Team8WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly DataContext context;
        public FoodController(DataContext context)
        {
            this.context = context;
        }

        /*Add new menu item into database*/
        [HttpPost("addMenuItem")]
        public async Task<ActionResult> addMenuItem(Food food)
        {
            if (food != null)
            {
                context.food.Add(food);
                await context.SaveChangesAsync();
            }
            return Ok();
        }

        /*Update menu item on database*/
        [HttpPut("updateMenu")]
        public async Task<ActionResult> updateMenu(int ID, string nameU, string descriptionU, decimal priceU,string urlU, string categoryU)
        {
            //var food = await context.food.FindAsync(ID);
            var food = new Food()
            {
                Id=ID,
                Name=nameU,
                Description=descriptionU,
                Price=priceU,
                Url = urlU,
                Category=categoryU

            };

            if (food != null)
            {
                try
                {
                    context.food.Update(food);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex.GetBaseException();
                }
            }


            return Ok();
        }
        // remove menu item on the database
        [HttpDelete("removeMenuItem")]
        public async Task<ActionResult<List<Food>>> removeMenuItem(int request)
        {
            var food = await context.food.FindAsync(request);
            if (food == null)
                return Ok("null");
            context.food.Remove(food);
            await context.SaveChangesAsync();
            return Ok(await context.food.ToListAsync());
        }

        //get menu item by ID and name
        [HttpGet("getFoodItem")]
        public Task<ActionResult<Food>> getFoodItem(int ID)
        {
            var food = (from m in context.food
                       where m.Id == ID
                       select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Food>>(Ok(food));
        }

        [HttpGet("getFoodItemCart")]
        public Task<ActionResult<Food>> getFoodItemCart(string name, string description, decimal price)
        {
            var food = (from m in context.food
                        where m.Name.Equals(name) && m.Description.Equals(description) && m.Price == price
                        select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Food>>(Ok(food));
        }

        //get food  item by name and price
        [HttpGet("getFoodByNameAndPrice")]
        public Task<ActionResult<Food>> getFoodByNameAndPrice(string name, decimal price)
        {
            var food = (from m in context.food
                        where m.Name.Equals(name) && m.Price == price
                        select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Food>>(Ok(food));
        }

        [HttpGet("getFoodByName")]
        public Task<ActionResult<Food>> getFoodByName(string name)
        {
            var food = (from m in context.food
                        where m.Name.Equals(name)
                        select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Food>>(Ok(food));
        }


        [HttpGet("getFoods")]
        public async Task<ActionResult<List<Food>>> getFoods(string category)
        {
            var food = await (from m in context.food where m.Category.Equals(category)
                        select m).ToListAsync();
            return Ok(food);
        }

        [HttpGet("getAllFoods")]
        public async Task<ActionResult<List<Food>>> getAllFoods()
        {
            var food = await (from m in context.food
                              select m).ToListAsync();
            return Ok(food);
        }

        //check if Item already added to cart
        [HttpGet("checkCart")]
        public ActionResult<Cart> checkCart(int userID, int foodID)
        {
            var com = (from m in context.cart
                       where
                     m.U_ID == userID && m.F_ID == foodID
                       select m).FirstOrDefault();
            return Ok(com);
        }
        //Update Quantity on the cart
        [HttpPut("updateQuantity")]
        public async Task<ActionResult> updateQuantity(int userID, int foodID)
        {
            var UserCart = (from m in context.cart
                       where
                     m.U_ID == userID && m.F_ID == foodID
                       select m).FirstOrDefault();
            var food = (from m in context.food where m.Id == foodID select m).FirstOrDefault();

            if (UserCart != null)
            {
                UserCart.Quantity += 1;
                UserCart.Price = food.Price * UserCart.Quantity;
                try
                {
                    context.cart.Update(UserCart);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex.GetBaseException();
                }
            }
            return Ok();
        }

        //Add to cart
        [HttpPost("addToCart")]
        public async Task<ActionResult> addToCart(Cart cart)
        {
            if (cart != null)
            {
                
                context.cart.Add(cart);
                await context.SaveChangesAsync();

            }
            return Ok();
        }
        [HttpPut("updateCart")]
        public async Task<ActionResult> updateCart(int ID, string Itemname,  decimal priceU, int UserId, int ItemID, string UrlU, int quantity, string category)
        {
            //var food = await context.food.FindAsync(ID);
            var cart = new Cart()
            {
                Id = ID,
                Name = Itemname,
                Price = priceU,
                U_ID = UserId,
                F_ID = ItemID,
                Url = UrlU,
                Quantity = quantity,
                Category = category
            };

            if (cart != null)
            {
                try
                {
                    context.cart.Update(cart);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex.GetBaseException();
                }
            }
            return Ok();
        }

        /*[HttpGet("getCart")]
        public async Task<ActionResult<Cart>> getCart(int U_ID, int F_ID)
        {
            var com =  (from m in context.cart
                       where m.F_ID == F_ID
                     && m.U_ID == U_ID
                       select m).FirstOrDefault();
            return Ok(com);
        }*/
        [HttpGet("getCarts")]
        public async Task<ActionResult<List<Cart>>> getCarts(int U_ID)
        {
            var com = (from m in context.cart
                       where
                     m.U_ID == U_ID
                       select m).ToList();
            return Ok(com);
        }
        //Clear the cart for a user
       [HttpDelete("clearCart")]
        public async Task<ActionResult> ClearCart(int userId)
        {

            var cart = (from m in context.cart
                       where
                     m.U_ID == userId
                        select m).ToList();

            foreach(var item in cart)
            {
                context.cart.Remove(item);
                await context.SaveChangesAsync();
            }
            return Ok();
        }
        [HttpDelete("RemoveItemCart")]
        public async Task<ActionResult> RemoveItemCart(int cartId)
        {

            var cartItem = (from m in context.cart
                        where
                      m.Id== cartId
                        select m).FirstOrDefault();

            if(cartItem != null)
            {
                context.cart.Remove(cartItem);
                await context.SaveChangesAsync();
            }
            return Ok();
        }
        //Delete everything on the cart table
        [HttpDelete("DeleteEverythingOnCart")]
        public async Task<ActionResult> DeleteEverythingOnCart()
        {

            var cart = (from m in context.cart
                        select m).ToList();

            foreach (var item in cart)
            {
                context.cart.Remove(item);
                await context.SaveChangesAsync();
            }
            return Ok();
        }
    }
}
