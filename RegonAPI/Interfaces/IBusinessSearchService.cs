using System.Data;

namespace RegonAPI.Interfaces
{
    public interface IBusinessSearchService
    {
        DataSet SearchEntities(string nipList);
    }
}
