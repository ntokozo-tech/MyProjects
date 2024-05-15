using Microsoft.AspNetCore.Mvc;
using Team8WebAPI.Models;

namespace Team8WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly DataContext context;
        public RatingController(DataContext context)
        {
            this.context = context;
        }

        /*Add rating into database*/
        [HttpPost("addRating")]
        public async Task<ActionResult> addRatings(Rating rating)
        {
            if (rating != null)
            {
                context.ratings.Add(rating);
                await context.SaveChangesAsync();
            }
            return Ok();
        }
        //[HttpPost("addUser")]
        //public async Task<ActionResult> addUser(Users user)
        //{
        //    if (user != null)
        //    {
        //        context.users.Add(user);
        //        await context.SaveChangesAsync();
        //    }
        //    return Ok();
        //}
        //Get rating by order ID
        [HttpGet("getRatingByOrderID")]
        public Task<ActionResult<Rating>> getRatingByOrderID(int ID)
        {
            var order = (from m in context.ratings
                         where m.OrderId == ID
                         select m).FirstOrDefault();

            return Task.FromResult<ActionResult<Rating>>(Ok(order));
        }

        /*Get all ratings*/

        [HttpGet("getAllRatings")]
        public async Task<ActionResult<List<Rating>>> getAllCustomerRatings()
        {
            var rating = await (from m in context.ratings
                                select m).ToListAsync();
            return Ok(rating);
        }
    }
}
