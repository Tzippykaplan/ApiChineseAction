using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ApiChineseAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorsController : Controller
    {
        IDonorsService _donorService;

        public DonorsController(IDonorsService _donorsService)
        {
            this._donorService = _donorsService;
        }

        /// GET: api/<DonorsController>
        [HttpGet]
        public async Task<IEnumerable<Donor>> Get()
        {
            return await _donorService.getDonors();
        }

        // GET api/<<DonorsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Donor>> Get(int id)
        {
            Donor donor = await _donorService.getById(id);
            return donor != null ? Ok(donor) : NotFound();
        }

        // POST api/<<DonorsController>
        [HttpPost]
        public async Task<ActionResult<Donor>> Post([FromBody] Donor donor)
        {
            try
            {
                Donor newDonor = await _donorService.createDonor(donor);
                return CreatedAtAction(nameof(Get), new { id = newDonor.Id }, newDonor);
            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }
        






        // PUT api/<<DonorsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Donor>> Put(int id, [FromBody] Donor donorToUpdate)
        {
            Donor checkDonor = await _donorService.updateDonor(id, donorToUpdate);
            return checkDonor != null ? Ok(checkDonor) : BadRequest();
        }

        // DELETE api/<<DonorsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await  _donorService.deleteDonor(id)? Ok(): BadRequest();
        }
    }
}
