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
	}
}
