using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using DMproject.Models;

public interface ICampaignService
{
	public Task Create(Campaign campaign);
	public Task<IEnumerable<Campaign>> GetAllAsync();
	public Task<Campaign> GetByIdAsync(Guid id);
	public Task UpdateAsync(Campaign campaign);
	public Task DeleteAsync(Guid id);
}

