using DMproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DMproject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CampaignController : ControllerBase
	{
		private readonly ICampaignService _campaignService;

		public CampaignController(ICampaignService campaignService)
		{
			_campaignService = campaignService;
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] Campaign campaign)
		{
			campaign.Id = Guid.NewGuid();

			await _campaignService.Create(campaign);
			return Ok();
		}

		[HttpGet]
		public async Task<IEnumerable<Campaign>> GetAll()
		{
			return await _campaignService.GetAllAsync();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Campaign>> GetById(Guid id)
		{
			var campaign = await _campaignService.GetByIdAsync(id);
			if (campaign == null)
			{
				return NotFound();
			}

			return Ok(campaign);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id, Campaign campaign)
		{
			if (id != campaign.Id)
			{
				return BadRequest();
			}

			await _campaignService.UpdateAsync(campaign);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			await _campaignService.DeleteAsync(id);
			return NoContent();
		}
	}
}
