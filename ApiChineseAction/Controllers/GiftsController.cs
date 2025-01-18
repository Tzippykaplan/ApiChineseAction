using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
namespace ApiChineseAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftsController : Controller
    {
        IGiftsService _giftService;

        public GiftsController(IGiftsService _giftsService)
        {
            this._giftService= _giftsService;
        }

       /// GET: api/<GiftsController>
        [HttpGet]
        public async Task<IEnumerable<Gift>> Get()
        {
           return await _giftService.getGifts();
        }

        // GET api/<<GiftsController>/5
        [HttpGet("{id}")]
        public  async Task<ActionResult<Gift>> Get(int id)
        {
            Gift gift = await  _giftService.getById(id);
          return   gift != null? Ok(gift) : NotFound();
        }

        // POST api/<<GiftsController>
        [HttpPost]
        public async Task<ActionResult<Gift>> Post([FromBody] Gift gift)
        {
            try
            {
                Gift newGift= await _giftService.createGift(gift);
                return CreatedAtAction(nameof(Get), new { id = newGift.Id }, newGift);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }
   



        // PUT api/<<GiftsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Gift>> Put(int id, [FromBody] Gift giftToUpdate)
        {
            Gift checkGift = await _giftService.updateGift(id, giftToUpdate);
          return   checkGift != null ? Ok(checkGift) : BadRequest();
     }

        // DELETE api/<<GiftsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _giftService.deleteGift(id);
        }
        [HttpPost("isUnique")]
         public async Task<bool> isUnique(Gift gift)
        {
            return await _giftService.isUnique(gift);
        }

    }
}
