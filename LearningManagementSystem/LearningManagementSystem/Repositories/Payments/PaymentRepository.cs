using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces;
using LearningManagementSystem.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningManagementSystem.Repositories;

public class PaymentRepository : IPaymentRepository
{
    public Task<int> CreateAsync(Payment obj)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<IList<Payment>> GetAllAsync(PagenationParams @params)
    {
        throw new System.NotImplementedException();
    }

    public Task<Payment> GetById(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Payment obj)
    {
        throw new System.NotImplementedException();
    }
}
