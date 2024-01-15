using LearningManagementSystem.Entities;
using LearningManagementSystem.Interfaces;
using LearningManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningManagementSystem.Repositories;

public class TeacherRepository : ITeacherRepository
{
    public Task<int> CreateAsync(Teacher obj)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Teacher>> GetAllAsync(PagenationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<Teacher> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Teacher obj)
    {
        throw new NotImplementedException();
    }
}
