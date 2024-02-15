using ApiAccess.Abstract;
using Shared.Dtos;
using Shared.Helpers.Abstract;

namespace ApiAccess.Base
{
    public class YazarApiRequest : IYazarApiRequest
    {
        private readonly IRequestService _requestService;
        public YazarApiRequest(IRequestService requestService)
        {
            _requestService = requestService;
        }
        public YazarlarDto GetYazarByEmailPassword(string email, string password)
        {
            return _requestService.Get<YazarlarDto>("Yazar/GetYazarByEmailPassword?email=" + email + "&password=" + password);
        }
    }
}
