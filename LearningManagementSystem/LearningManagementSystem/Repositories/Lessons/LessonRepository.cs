using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces;
using LearningManagementSystem.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningManagementSystem.Repositories;

public class LessonRepository : ILessonRepository
{
    public Task<int> CreateAsync(Lesson obj)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<IList<Lesson>> GetAllAsync(PagenationParams @params)
    {
        throw new System.NotImplementedException();
    }

    public Task<Lesson> GetById(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Lesson obj)
    {
        throw new System.NotImplementedException();
    }
}
