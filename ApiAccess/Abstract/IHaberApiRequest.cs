using Shared.Dtos;

namespace ApiAccess.Abstract
{
    public interface IHaberApiRequest
    {
        List<HaberlerDto> GetAllHaber();
    }
}
