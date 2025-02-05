using DMproject.Models;

public class CampaignService : ICampaignService
{
	private readonly ICampaignRepository _campaignRepository;

	public CampaignService(ICampaignRepository campaignRepository)
	{
		_campaignRepository = campaignRepository;
	}

	public async Task Create(Campaign campaign) => await _campaignRepository.Create(campaign);

}