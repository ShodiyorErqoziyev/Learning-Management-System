using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces;
using LearningManagementSystem.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningManagementSystem.Repositories;

public class SubjectRepository : ISubjectRepository
{
    public Task<int> CreateAsync(Subject obj)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<IList<Subject>> GetAllAsync(PagenationParams @params)
    {
        throw new System.NotImplementedException();
    }

    public Task<Subject> GetById(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Subject obj)
    {
        throw new System.NotImplementedException();
    }
}
