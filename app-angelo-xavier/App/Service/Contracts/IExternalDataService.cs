using Service.Configuration;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IExternalDataService
    {
        Task<ExternalDataResponseHeader> Find(string textToFind,int Size = 100);
    }
}
