using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team8WebAPI.Models;

namespace Team8WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DataContext context;
        public OrdersController(DataContext context)
        {
            this.context = context;
        }

       
        [HttpPost("CreateOrder")]
        public async Task<ActionResult> CreateOrder(Order order)
        {
            if (order != null)
            {
                context.orders.Add(order);
                await context.SaveChangesAsync();
            }
            return Ok();
        }

        [HttpGet("getOrders")]
        public async Task<ActionResult<List<Users>>> getOrders()
        {

            return Ok(await context.orders.ToListAsync());
        }
        [HttpDelete("DeleteOrder")]
        public async Task<ActionResult> DeleteOrder()
        {

            var cart = (from m in context.orders
                        select m).ToList();

            foreach (var item in cart)
            {
                context.orders.Remove(item);
                await context.SaveChangesAsync();
            }
            return Ok();
        }

        [HttpPut("updateOrderStatus")]
        public async Task<ActionResult> updateOrderStatus(int orderId,int userID, string details, string status, decimal price)
        {
            //var food = await context.food.FindAsync(ID);
            Order order = new Order()
            {
                Id = orderId,
                UserID = userID,
                OrderDetails = details,
                OrderStatus = status,
                TotalCost = price,

            };
            if (order != null)
            {

                try
                {
                    context.orders.Update(order);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex.GetBaseException();
                }
            }
            return Ok();
        }

        [HttpPut("updateStatus")]
        public async Task<ActionResult> updateStatus(int orderId, string status)
        {
            //var food = await context.food.FindAsync(ID);

            var UserOrder = await context.orders.FindAsync(orderId);

            if (UserOrder != null)
            {
                UserOrder.OrderStatus = status;
                try
                {
                    context.orders.Update(UserOrder);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex.GetBaseException();
                }
            }
            return Ok();
        }
        [HttpGet("getOrderById")]
        public Task<ActionResult<Order>> getOrderById(int ID)
        {
            var order = (from m in context.orders
                         where m.Id == ID
                        select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Order>>(Ok(order));
        }

        [HttpGet("getOrderByUserId")]
        public Task<ActionResult<Order>> getOrderByUserId(int ID)
        {
            var order = (from m in context.orders
                         where m.UserID==ID
                         select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Order>>(Ok(order));
        }

        [HttpGet("getOrdersForDelivery")]
        public Task<ActionResult<List<Order>>> getOrdersForDelivery()
        {
            var order = (from m in context.orders
                         where m.OrderType.Equals("delivery") && m.OrderStatus.Equals("Ready") || m.OrderType.Equals("delivery") && m.OrderStatus.Equals("on the way") ||
                         m.OrderType.Equals("delivery") && m.OrderStatus.Equals("Arrived")
                         select m).ToList();
            return Task.FromResult<ActionResult<List<Order>>>(Ok(order));
        }
        [HttpGet("getOrderListByUserID")]
        public Task<ActionResult<List<Order>>> getOrderListByUserID(int ID)
        {
            var order = (from m in context.orders
                         where m.UserID == ID
                         select m).ToList();
            return Task.FromResult<ActionResult<List<Order>>>(Ok(order)); 
        }
        [HttpGet("getOrderByUserIdOrderID")]
        public Task<ActionResult<Order>> getOrderByUserIdOrderID(int ID, int userID)
        {
            var order = (from m in context.orders
                         where m.UserID == userID && m.Id == ID
                         select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Order>>(Ok(order));
        }

        //get Track order 
        [HttpGet("getOrderForTrackOrder")]
        public Task<ActionResult<Order>> getOrderForTrackOrder(int userID) //
        {
            var order = (from m in context.orders
                         where (m.UserID == userID && m.OrderStatus.Equals("pending")  || m.UserID == userID && m.OrderStatus.Equals("processing") ||
                         m.UserID == userID && m.OrderStatus.Equals("ready") || m.UserID == userID && m.OrderStatus.Equals("on the way") ||
                          m.UserID == userID && m.OrderStatus.Equals("Arrived") )
                         orderby m.OrderDate descending

                         select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Order>>(Ok(order));
        }
        //get order by orderID and status that says collected
        [HttpGet("getOrderByCollected")]
        public Task<ActionResult<Order>> GetLastOrderByCollected(int ID)
        {
            var order = (from m in context.orders
                         where m.UserID == ID && m.OrderStatus.Equals("collected")
                         orderby m.OrderDate descending
                         select m).FirstOrDefault();

            return Task.FromResult<ActionResult<Order>>(Ok(order));
        }
        [HttpGet("getOrderByPickeUP")]
        public Task<ActionResult<Order>> getOrderByPickeUP(int ID)
        {
            var order = (from m in context.orders
                         where m.UserID == ID && m.OrderStatus.Equals("picked up")
                         select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Order>>(Ok(order));
        }

        // Get customer points stats
        [HttpGet("getCustomerPointsStats")]
        public Task<ActionResult<List<CustomerPointsStats>>> getCustomerPointsStats(int UserId)
        {
            var order = (from m in context.customerPointsStats
                         where m.UserID == UserId
                         select m).ToList();
            return Task.FromResult<ActionResult<List<CustomerPointsStats>>>(Ok(order));
        }


        // Track order customer 

        [HttpGet("getOrderByUserIdnStatus")]
        public Task<ActionResult<Order>> getOrderByUserIdnStatus(int userID, string orderStatus, string details, string collectionTime,decimal price)
        {
            var order = (from m in context.orders
                         where m.UserID == userID && m.OrderStatus.Equals(orderStatus) && m.OrderDetails.Equals(details) && m.CollectionTime.Equals(collectionTime) && m.TotalCost == price 
                         select m).FirstOrDefault();
            return Task.FromResult<ActionResult<Order>>(Ok(order));
        }

        //Order history
        [HttpGet("getOrderCompleteOrders")]
        public Task<ActionResult<List<Order>>> getOrderCompleteOrders(int userID)
        {
            var order = (from m in context.orders
                         where m.UserID == userID && m.OrderStatus.Equals("collected")
                         select m).ToList();
            return Task.FromResult<ActionResult<List<Order>>>(Ok(order));
        }



    }
}
