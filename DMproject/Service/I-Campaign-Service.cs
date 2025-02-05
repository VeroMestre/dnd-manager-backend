using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using DMproject.Models;

public interface ICampaignService
{
	public Task Create(Campaign campaign);
}

