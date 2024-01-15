using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces;
using LearningManagementSystem.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningManagementSystem.Repositories;

public class StudentRepository : IStudentRepository
{
    public Task<int> CreateAsync(Student obj)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<IList<Student>> GetAllAsync(PagenationParams @params)
    {
        throw new System.NotImplementedException();
    }

    public Task<Student> GetById(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Student obj)
    {
        throw new System.NotImplementedException();
    }
}
