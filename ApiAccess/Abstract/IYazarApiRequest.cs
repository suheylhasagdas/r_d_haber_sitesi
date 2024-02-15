using Shared.Dtos;

namespace ApiAccess.Abstract
{
	public interface IYazarApiRequest
	{
		YazarlarDto GetYazarByEmailPassword (string email, string password);
	}
}
