using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team8WebAPI.Models;

namespace Team8WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly DataContext context;
        public DriverController(DataContext context)
        {
            this.context = context;
        }

        /*Add new driver into database*/
        [HttpPost("addDriver")]
        public async Task<ActionResult> addDriver(Driver driver)
        {
            if (driver != null)
            {
                context.drivers.Add(driver);
                await context.SaveChangesAsync();
            }
            return Ok();
        }

        /* Update driver by id*/
        [HttpPost("updateDriverById")]
        public async Task<ActionResult> updateDriverById(int ID, string nameU, string emailU, string addressU, string imageURL, string language)
        {
            var driver = new Driver()
            {
                Id = ID,
                Name = nameU,
                DriverEmail = emailU,
                DriverAddress = addressU,
                DriverPictureUrl = imageURL,
                DriverLanguages = language
            };

            if (driver != null)
            {
                try
                {
                    context.drivers.Update(driver);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex.GetBaseException();
                }
            }
            return Ok();
        }


        /*Update driver details on database*/
        [HttpPost("updateDriver")]
        public async Task<ActionResult> updateDriver(Driver driver)
        {
            //var driver = await context.drivers.FindAsync(ID);
            //var driver = new Driver()
            //{
            //    //U_ID = ID,
            //    Id = ID,
            //    //U_name = nameU,
            //    DriverEmail = emailU,
            //    //U_CellNumber = cellNumberU,
            //    //U_username = usernameU,
            //    DriverPassword = passwordU,
            //    //U_type = typeU
            //};

            if (driver != null)
            {
                try
                {
                    context.drivers.Update(driver);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex.GetBaseException();
                }
            }

            return Ok();
        }

        // remove driver on the database
        [HttpDelete("removeDriver")]
        public async Task<ActionResult<List<Driver>>> removeDriver(int request)
        {
            var driver = await context.drivers.FindAsync(request);
            if (driver == null)
                return Ok("null");
            context.drivers.Remove(driver);
            await context.SaveChangesAsync();
            return Ok(await context.drivers.ToListAsync());
        }

        //get driver by ID and name
        [HttpGet("getDriver")]
        public Task<ActionResult<Driver>> getDriver(int ID)
        {
            var driver = (from d in context.drivers
                          where d.Id == ID
                          select d).FirstOrDefault();
            return Task.FromResult<ActionResult<Driver>>(Ok(driver));
        }
        
        [HttpGet("getDriverLogin")]
        public async Task<ActionResult<Users>> getDriver(string email, string password)
        {
            var user = (from m in context.drivers
                        where m.DriverEmail.Equals(email)
                        && m.DriverPassword.Equals(password)
                        select m).FirstOrDefault();
            return Ok(user);
        }


        /*
        [HttpGet("getFoodItemCart")]
        public Task<ActionResult<Food>> getFoodItemCart(string name, string description, decimal price)
        {
            var food = (from m in context.food
                        where m.Name.Equals(name) && m.Description.Equals(description) && m.Price == price
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
        */

        //Get all drivers
        [HttpGet("getAllDrivers")]
        public async Task<ActionResult<List<Driver>>> getAllDrivers()
        {
            var drivers = await (from d in context.drivers
                                 select d).ToListAsync();
            return Ok(drivers);
        }

        /*
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
        }*/

        /*[HttpGet("getCart")]
        public async Task<ActionResult<Cart>> getCart(int U_ID, int F_ID)
        {
            var com =  (from m in context.cart
                       where m.F_ID == F_ID
                     && m.U_ID == U_ID
                       select m).FirstOrDefault();
            return Ok(com);
        }*/

        /*
        [HttpGet("getCarts")]
        public async Task<ActionResult<List<Cart>>> getCarts(int U_ID)
        {
            var com = (from m in context.cart
                       where
                     m.U_ID == U_ID
                       select m).ToList();
            return Ok(com);
        }

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
        */


    }
}
