using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using DMproject.Models;

public interface ICampaignRepository
{
	public Task Create(Campaign campaign);
}
