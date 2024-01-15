using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces;
using LearningManagementSystem.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningManagementSystem.Repositories;

public class CourseRepository : ICourseRepository
{
    public Task<int> CreateAsync(Course obj)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<IList<Course>> GetAllAsync(PagenationParams @params)
    {
        throw new System.NotImplementedException();
    }

    public Task<Course> GetById(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Course obj)
    {
        throw new System.NotImplementedException();
    }
}
