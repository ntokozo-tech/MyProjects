using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team8WebAPI.Models;

namespace Team8WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        private readonly DataContext context;
        public PaymentController(DataContext context)
        {
            this.context = context;
        }

        [HttpPost("AddCard")]
        public async Task<ActionResult> AddCard(Card card)
        {
            if (card != null)
            {
                context.cards.Add(card);
                await context.SaveChangesAsync();
            }
            return Ok();
        }

        [HttpGet("getCardByUserId")]
        public Task<ActionResult<Card>> getCardByUserId(int ID)
        {
            var order = (from m in context.cards
                         where m.UserID == ID
                         select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Card>>(Ok(order));
        }

        [HttpDelete("DeleteCard")]
        public async Task<ActionResult> DeleteAllCard()
        {

            var cardsP = (from m in context.cards
                        select m).ToList();

            foreach (var item in cardsP)
            {
                context.cards.Remove(item);
                await context.SaveChangesAsync();
            }
            return Ok();
        }

        [HttpDelete("DeleteUserCard")]
        public async Task<ActionResult> DeleteUserCard(int id)
        {
            var cardsP = (from m in context.cards where m.UserID == id
                        select m).FirstOrDefault();
            if(cardsP != null)
            {
                context.cards.Remove(cardsP);
                await context.SaveChangesAsync();
            }
            return Ok();
        }

    }
}
