using System.Collections.Generic;
using Isen.Dotnet.Library.Models.Base.BaseModel;
using Isen.Dotnet.Library.Models.Implementation;
namespace Isen.Dotnet.Library.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    
        where T : BaseModel
        {
            IList<T> GetAll();
            T Single(int id);
            T single(string name);
        }
    }
