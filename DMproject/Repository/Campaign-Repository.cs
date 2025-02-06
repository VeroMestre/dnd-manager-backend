using System;
using DMproject;
using DMproject.Models;
using Microsoft.EntityFrameworkCore;

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

	public async Task<IEnumerable<Campaign>> GetAllAsync()
	{
		List<Campaign> campaigns;
		campaigns = await _context.Campaigns.ToListAsync();
		return campaigns;
	}

	public async Task<Campaign> GetByIdAsync(Guid id)
	{
		return await _context.Campaigns.FindAsync(id);
	}

	public async Task UpdateAsync(Campaign campaign)
	{
		_context.Campaigns.Update(campaign);
		await _context.SaveChangesAsync();
	}

	public async Task DeleteAsync(Guid id)
	{
		var campaign = await _context.Campaigns.FindAsync(id);
		if(campaign != null)
		{
			_context.Campaigns.Remove(campaign);
			await _context.SaveChangesAsync();
		}
	}

}
