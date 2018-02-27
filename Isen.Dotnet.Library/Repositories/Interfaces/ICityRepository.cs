using System.Collections.Generic;
using Isen.Dotnet.Library.Models.Implementation;
public interface ICityRepository
    {
        IList<City> GetAll();
        City Single(int id);
    }