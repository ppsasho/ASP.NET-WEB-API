using BeverageStore.Shared.Exceptions.OrderExceptions;
using DTOs.Order;
using DTOs.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Services.Interfaces;

namespace BeverageStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService service)
        {
            _orderService = service;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_orderService.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id) 
        {
            try
            {
                if (id < 1)
                    return BadRequest("Please ensure the id is greater than zero!");

                var found = _orderService.GetById(id);
                if (found.OrderId == 0) 
                    throw new OrderNotFoundException("Order wasn't found with the specified id!");

                return Ok(found);
            }catch(Exception ex)
            {
                
                Log.Error(ex, $"An error occured while attempting to fetch an order with id: [{id}]");
                return (IActionResult)new ExceptionResultDto() { ErrorMessage = ex.Message };
            }
        }

        [Authorize]
        [HttpPost("create")]
        public IActionResult CreateOrder(OrderCreateDto orderCreateDto) 
        {
            try
            {
                var result = _orderService.CreateOrder(orderCreateDto);
                if (!result.Success)
                {
                    return result.ErrorMessage switch
                    {
                        "User not found!" => NotFound(result.ErrorMessage),
                        "Invalid beverages or quantities!" => BadRequest(result.ErrorMessage),
                        _ => throw new OrderNotCreatedException("The beverage wasn't created successfully!"),
                    };
                    ;
                }
                return CreatedAtAction("CreateOrder", orderCreateDto);
            } catch(Exception ex)
            {
                Log.Error(ex, $"The order wasn't created successfully containing: [{orderCreateDto.UserId}] [{orderCreateDto.orderItems}]\n");
                return (IActionResult)new ExceptionResultDto() { ErrorMessage = ex.Message };
            }
        }

    }
}
