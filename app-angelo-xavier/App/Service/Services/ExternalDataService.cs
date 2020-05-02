using Core.Helpers;
using Service.Configuration;
using Service.Contracts;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ExternalDataService : IExternalDataService
    {
        public async Task<ExternalDataResponseHeader> Find(string textToFind,int Size = 100)
        {
            string[] listFields = {
                ExternalDataRequestField.CITY,
                ExternalDataRequestField.INEXPFTE,
                ExternalDataRequestField.INSTNM,
                ExternalDataRequestField.OPEID,
                ExternalDataRequestField.OPEID6,
                ExternalDataRequestField.PFTFAC,
                ExternalDataRequestField.REGION,
                ExternalDataRequestField.STABBR,
                ExternalDataRequestField.TUITFTE,
                ExternalDataRequestField.UNITID,
                ExternalDataRequestField.ZIP };

            var request = new ExternalDataRequestHeader()
            {
                Source = listFields,
                Query = new ExternalDataRequestBody()
                {
                    MultiMatch = new ExternalDataRequestBodyMatch()
                    {
                        Fields = listFields,
                        Query = textToFind,
                        Lenient = true
                    }
                    
                },
                Size = Size
            };

            return await HttpRequestExternalDataHelper.GetRequestExternalData<ExternalDataResponseHeader>(request);
        }
    }
}
