using DMproject.Models;

public class CampaignService : ICampaignService
{
	private readonly ICampaignRepository _campaignRepository;

	public CampaignService(ICampaignRepository campaignRepository)
	{
		_campaignRepository = campaignRepository;
	}

	public async Task Create(Campaign campaign) => await _campaignRepository.Create(campaign);
	public Task<IEnumerable<Campaign>> GetAllAsync() => _campaignRepository.GetAllAsync();
	public async Task<Campaign> GetByIdAsync(Guid id) => await _campaignRepository.GetByIdAsync(id);
	public async Task UpdateAsync(Campaign campaign) => await _campaignRepository.UpdateAsync(campaign);
	public async Task DeleteAsync(Guid id) => await _campaignRepository.DeleteAsync(id);
}