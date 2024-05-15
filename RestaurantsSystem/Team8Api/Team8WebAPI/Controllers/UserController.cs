using Microsoft.AspNetCore.Mvc;
using Team8WebAPI.Models;

namespace Team44WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    /***********User CRUD***************************************************************/
    public class UserController : ControllerBase
    {

        private readonly DataContext context;
        public UserController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("getUsers")]
        public async Task<ActionResult<List<Users>>> getUsers()
        {

            return Ok(await context.users.ToListAsync());
        }

        [HttpGet("getUser")]
        public async Task<ActionResult<Users>> getUser(string email, string password)
        {
            var user = (from m in context.users where m.U_Email.Equals(email)
                        && m.U_Password.Equals(password) select m).FirstOrDefault();
            return Ok(user);
        }
        [HttpPost("addUser")]
        public async Task<ActionResult> addUser(Users user)
        {
            if (user != null)
            {
                context.users.Add(user);
                await context.SaveChangesAsync();
            }
            return Ok();
        }


        [HttpGet("getUserByID")]
        public ActionResult<Users> getUserByID(int id)
        {
            var user = (from m in context.users
                        where m.U_ID == id
                        select m).FirstOrDefault();
            return Ok(user);
        }
        [HttpDelete("removeUser")]
        public async Task<ActionResult<Users>> removeUser(int userID)
        {
            var user = await context.users.FindAsync(userID);
            if (user == null)
                return Ok("null");
            context.users.Remove(user);
            await context.SaveChangesAsync();
            return Ok(user);
        }

    }
}
