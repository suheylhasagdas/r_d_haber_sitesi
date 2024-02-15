using Business.Abstract;
using DataAccess.Abstract.Repository;
using Shared.Dtos;
using Shared.Entities;

namespace Business.Base
{
	public class SlaytManager : ISlaytService
	{
		private readonly IRepository<Slaytlar > _repository;
        public SlaytManager(IRepository<Slaytlar> repository)
        {
			_repository = repository;
		}
        public bool DeleteSlayt(int id)
		{
			return _repository.Delete(new Slaytlar { Id = id });
		}

		public SlaytlarDto GetSlaytById(int id)
		{
			var response = _repository.GetById(id);
			
			return SlaytItem(response);
		}

		public List<SlaytlarDto> GetSlaytlar()
		{
			var response = _repository.GetAll().ToList();
			List<SlaytlarDto> result = new List<SlaytlarDto>();
			
			foreach (var item in response)
				result.Add(SlaytItem(item));

			return result;
		}

		public SlaytlarDto InsertSlayt(SlaytlarDto model)
		{
			var response = _repository.Insert(SlaytItem(model));

			return SlaytItem(response);
		}

		public SlaytlarDto UpdateSlayt(SlaytlarDto model)
		{
			var slayt = _repository.GetById(model.Id);
			var response = _repository.Update(slayt);

			return SlaytItem(response);
		}

		private SlaytlarDto SlaytItem(Slaytlar model)
		{
			SlaytlarDto result = new SlaytlarDto();
			result.Id = model.Id;
			result.Baslik = model.Baslik;
			result.Icerik = model.Icerik;
			result.HaberId = model.HaberId;
			result.Resim = model.Resim;
			result.Aktifmi = model.Aktifmi;
			return result;
		}
		private Slaytlar SlaytItem(SlaytlarDto model)
		{
			Slaytlar result = new Slaytlar();
			result.Id = model.Id;
			result.Baslik = model.Baslik;
			result.Icerik = model.Icerik;
			result.HaberId = model.HaberId;
			result.Resim = model.Resim;
			result.Aktifmi = model.Aktifmi;
			return result;
		}
	}
}
