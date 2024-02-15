using Business.Abstract;
using DataAccess.Abstract.Repository;
using Shared.Dtos;
using Shared.Entities;

namespace Business.Base
{
	public class HaberManager : IHaberService
	{
		private readonly IRepository<Haberler> _repository;
		public HaberManager(IRepository<Haberler> repository)
		{
			_repository = repository;
		}
		public bool DeleteHaber(int id)
		{
			return _repository.Delete(new Haberler { Id = id});
		}

		public HaberlerDto GetHaberById(int id)
		{
			var response = _repository.GetById(id);

			return HaberItem(response);
		}

		public List<HaberlerDto> GetHaberler()
		{
			var response = _repository.GetAll().ToList();

			List<HaberlerDto> result = new List<HaberlerDto>();

			foreach (var item in response) 
				result.Add(HaberItem(item));

			return result;
		}

		public HaberlerDto InsertHaber(HaberlerDto model)
		{
			Haberler response = _repository.Insert(HaberItem(model));

			return HaberItem(response);
		}

		public HaberlerDto UpdateHaber(HaberlerDto model)
		{
			var haber = _repository.GetById(model.Id);
			Haberler response = _repository.Update(haber);

			return HaberItem(response);
		}

		private HaberlerDto HaberItem(Haberler model)
		{
			HaberlerDto result = new HaberlerDto();
			result.Id = model.Id;
			result.Baslik = model.Baslik;
			result.Icerik = model.Icerik;
			result.Aktifmi = model.Aktifmi;
			result.Resim = model.Resim;
			result.EklenmeTarihi = model.EklenmeTarihi;
			result.YazarId = model.YazarId;
			result.KategoriId = model.KategoriId;
			result.GosterimSayisi = model.GosterimSayisi;
			result.Video = model.Video;
			return result;
		}
		private Haberler HaberItem(HaberlerDto model)
		{
			Haberler result = new Haberler();
			result.Id = model.Id;
			result.Baslik = model.Baslik;
			result.Icerik = model.Icerik;
			result.Aktifmi = model.Aktifmi;
			result.Resim = model.Resim;
			result.EklenmeTarihi = model.EklenmeTarihi;
			result.YazarId = model.YazarId;
			result.KategoriId = model.KategoriId;
			result.GosterimSayisi = model.GosterimSayisi;
			result.Video = model.Video;
			return result;
		}
	}
}
