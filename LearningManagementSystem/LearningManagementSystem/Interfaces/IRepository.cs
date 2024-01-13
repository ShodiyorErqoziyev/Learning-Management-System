using LearningManagementSystem.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces;

public interface IRepository <TModel, TVeiwModel>
{
    public Task<int> CreateAsync(TModel obj);
    public Task<int> UpdateAsync(long id, TModel obj);
    public Task<int> DeleteAsync(long id);
    public Task<IList<TVeiwModel>> GetAllAsync(PagenationParams @params);
    public Task<TVeiwModel> GetById(long id);
}
