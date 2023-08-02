using CandidateApp.Domain.Entities;
using TcknService;
namespace CandidateApp.KpsService
{
    public static  class KpsAsmxService
    {
        public static async Task<bool> GetTcknDogrulama(Customer customer)
        {
            bool sonuc = false;
            await Task.Run(() =>
            {
                using (KPSPublicSoapClient kps = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
                {
                    int birth = customer.BirthDate.Year;
                    var result = kps.TCKimlikNoDogrulaAsync(customer.IdentityNo, customer.Name, customer.Surname, birth);
                    sonuc = result.Result.Body.TCKimlikNoDogrulaResult;
                }
            });
            return sonuc;
        }
    }
}
