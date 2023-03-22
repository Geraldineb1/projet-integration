﻿using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Contracts
{
    public interface IServiceService
    {
        Task<List<ServiceVM>> GetServices();
        Task<ServiceVM> GetServiceDetails(int id);
        Task<Response<int>> CreateService(CreateServiceVM service);
        Task<Response<int>> UpdateService(int id, ServiceVM service);
        Task<Response<int>> DeleteService(int id);
    }
}
