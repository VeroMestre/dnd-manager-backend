using System;
using DMproject;
using DMproject.Models;

public class CampaignRepository : ICampaignRepository
{
	private readonly ApplicationDbContext _context;

	public CampaignRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task Create(Campaign campaign)
	{
		_context.Campaigns.Add(campaign);
		await _context.SaveChangesAsync();
	}

}
