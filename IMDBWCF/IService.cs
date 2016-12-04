using System.ServiceModel;
using IMDBWCF.Models;

namespace IMDBWCF
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Film GetFilmById(string id);

        [OperationContract]
        Film GetFilmBySearch(string id);
    }
}
