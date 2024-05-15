using Microsoft.AspNetCore.Mvc;
using Team8WebAPI.Models;


namespace Team8WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverTrackOrderTrackOrderController : ControllerBase
    {
        private readonly DataContext context;
        public DriverTrackOrderTrackOrderController(DataContext context)
        {
            this.context = context;
        }

        ///*Add new DriverTrackOrder into database*/
        //[HttpPost("addDriverTrackOrder")]
        //public async Task<ActionResult> addDriverTrackOrder(DriverTrackOrder DriverTrackOrder)
        //{
        //    if (DriverTrackOrder != null)
        //    {
        //        context.driverTrackOrders.Add(DriverTrackOrder);
        //        await context.SaveChangesAsync();
        //    }
        //    return Ok();
        //}

        ///* Update DriverTrackOrder by id*/
        //[HttpPost("updateDriverTrackOrderById")]
        //public async Task<ActionResult> updateDriverTrackOrderById(DriverTrackOrder order)
        //{
        //    if (order != null)
        //    {
        //        try
        //        {
        //            context.driverTrackOrders.Update(order);
        //            await context.SaveChangesAsync();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex.GetBaseException();
        //        }
        //    }
        //    return Ok();
        //}


        ///*Update DriverTrackOrder details on database*/
        //[HttpPost("updateDriverTrackOrder")]
        //public async Task<ActionResult> updateDriverTrackOrder(DriverTrackOrder DriverTrackOrder)
        //{

        //    if (DriverTrackOrder != null)
        //    {
        //        try
        //        {
        //            context.driverTrackOrders.Update(DriverTrackOrder);
        //            await context.SaveChangesAsync();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex.GetBaseException();
        //        }
        //    }

        //    return Ok();
        //}


        //[HttpDelete("removeDriverTrackOrderTrackOrder")]
        //public async Task<ActionResult<List<DriverTrackOrder>>> removeDriverTrackOrder(int request)
        //{
        //    var DriverTrackOrder = await context.driverTrackOrders.FindAsync(request);
        //    if (DriverTrackOrder == null)
        //        return Ok("null");
        //    context.driverTrackOrders.Remove(DriverTrackOrder);
        //    await context.SaveChangesAsync();
        //    return Ok(await context.driverTrackOrders.ToListAsync());
        //}

        //[HttpGet("getDriverTrackOrder")]
        //public Task<ActionResult<DriverTrackOrder>> getDriverTrackOrder(int ID)
        //{
        //    var DriverTrackOrder = (from d in context.driverTrackOrders
        //                            where d.Del_ID == ID
        //                  select d).FirstOrDefault();
        //    return Task.FromResult<ActionResult<DriverTrackOrder>>(Ok(DriverTrackOrder));
        //}

        ////Get all DriverTrackOrders
        //[HttpGet("getAllDriverTrackOrders")]
        //public async Task<ActionResult<List<DriverTrackOrder>>> getAllDriverTrackOrders()
        //{
        //    var DriverTrackOrders = await (from d in context.driverTrackOrders
        //                                   select d).ToListAsync();
        //    return Ok(DriverTrackOrders);
        //}

    }
}
