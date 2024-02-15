using ApiAccess.Abstract;
using Shared.Dtos;
using Shared.Helpers.Abstract;

namespace ApiAccess.Base
{
    public class HaberApiRequest : IHaberApiRequest
    {
        private readonly IRequestService _requestService;
        public HaberApiRequest(IRequestService requestService)
        {
            _requestService = requestService;
        }
        public List<HaberlerDto> GetAllHaber() => _requestService.Get<List<HaberlerDto>>("Haber/GetAllHaber");
    }
}

