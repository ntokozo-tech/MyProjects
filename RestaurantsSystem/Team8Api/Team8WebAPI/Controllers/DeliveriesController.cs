using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team8WebAPI.Models;

namespace Team8WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private readonly DataContext context;
        public DeliveriesController(DataContext context)
        {
            this.context = context;
        }

        [HttpPost("AddDelivery")]
        public async Task<ActionResult> AddDelivery(Deliveries delivery)
        {
            if (delivery != null)
            {
                context.deliveries.Add(delivery);
                await context.SaveChangesAsync();
            }
            return Ok();
        }
        [HttpGet("getAllDeliveries")]
        public async Task<ActionResult<List<Deliveries>>> getAllDeliveries()
        {

            return Ok(await context.deliveries.ToListAsync());
        }

        [HttpGet("getDeliveryByDriverID")]
        public Task<ActionResult<List<Deliveries>>> getDeliveryByDriverID(int ID)
        {
            var order = (from m in context.deliveries
                         where m.DriverID == ID
                         select m).ToList();
            return Task.FromResult<ActionResult<List<Deliveries>>>(Ok(order));
        }
        [HttpGet("getDeliveryByOrderID")]
        public Task<ActionResult<Deliveries>> getDeliveryByOrderID(int ID)
        {
            var order = (from m in context.deliveries
                         where m.OrderID == ID
                         select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Deliveries>>(Ok(order));
        }

        [HttpDelete("DeleteAllDeliveries")]
        public async Task<ActionResult> DeleteAllDeliveries()
        {

            var cart = (from m in context.deliveries
                        select m).ToList();

            foreach (var item in cart)
            {
                context.deliveries.Remove(item);
                await context.SaveChangesAsync();
            }
            return Ok();
        }

        [HttpDelete("DeleteDelivery")]
        public async Task<ActionResult> DeleteDeliveries(int ID)
        {

            var cart = (from m in context.deliveries where m.OrderID==ID
                        select m).FirstOrDefault();
            if (cart != null)
            {
                context.deliveries.Remove(cart);
                await context.SaveChangesAsync();
            }

            return Ok();
        }

        [HttpPut("updateDriver")]
        public async Task<ActionResult> updateDriver(int orderID, int driverID)
        {
            var order = (from m in context.deliveries
                            where
                            m.OrderID == orderID
                            select m).FirstOrDefault();

            if (order != null)
            {
                order.DriverID = driverID;
                try
                {
                    context.deliveries.Update(order);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex.GetBaseException();
                }
            }
            return Ok();
        }
    }
}