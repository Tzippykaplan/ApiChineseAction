using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiChineseAction.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RaffleController : ControllerBase
    {
        IRaffleService _raffleService;
        public RaffleController(IRaffleService raffleService)
        {
            _raffleService = raffleService;  
        }
        // GET: api/<RaffleController>
        [HttpGet("raffle")]
        public async Task<ActionResult<List<RaffleResponse>>> raffle()
        {
            try
            {
                return  await _raffleService.GetRaffleResponse();
               
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // GET api/<RaffleController>/5
        [HttpGet("{id}")]
         public async Task<ActionResult<LotteryTicket>>Get(int id)
        {
           return await _raffleService.getTicketById(id);
        }

        // POST api/<RaffleController>
        [HttpPost]
        public async Task<ActionResult<List<LotteryTicket>>>Post([FromBody] List<LotteryTicket> lotteryTickets)
        {
            try
            {
                List<LotteryTicket> newLotteryTickets = await _raffleService.createTicket(lotteryTickets);
                return Created(nameof(Get), newLotteryTickets);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

       
    }
}
