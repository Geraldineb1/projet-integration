﻿using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IProviderService
    {
        Task<List<ProviderVM>> GetProviders();
        Task<ProviderVM> GetProviderDetails(int id);
        Task<Response<int>> CreateProvider(CreateProviderVM provider);
    }
}