﻿using AdminUI.Models;
using ApiAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AdminUI.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IKategoriApiRequest _kategoriApiRequest;
        public KategoriController(IKategoriApiRequest kategoriApiRequest)
        {
            _kategoriApiRequest = kategoriApiRequest;
        }
        public IActionResult Index()
        {
            var pageData = _kategoriApiRequest.GetKategoriler();

			return View(pageData);
		}
		public IActionResult Ekle()
		{
			return View();
		}

		[HttpPost]
		public IActionResult KategoriEkle(KategoriViewModel model)
		{
			KategorilerDto kategori = new KategorilerDto();
			kategori.Aktifmi = model.Aktifmi;
			kategori.Aciklama = model.Aciklama;
			var result = _kategoriApiRequest.KategoriEkle(kategori);

			return RedirectToAction("Index");
		}
		public IActionResult Guncelle(int kategoriId)
		{
			var data = _kategoriApiRequest.GetKategoriById(kategoriId);

			KategoriViewModel model = new KategoriViewModel();
			model.Aktifmi = data.Aktifmi;
			model.Id = data.Id;
			model.Aciklama = data.Aciklama;

			return View(model);
		}

		[HttpPost]
		public IActionResult KategoriGuncelle(KategoriViewModel model)
		{
			KategorilerDto kategori = new KategorilerDto();
			kategori.Id = model.Id.Value;
			kategori.Aktifmi = model.Aktifmi;
			kategori.Aciklama = model.Aciklama;
			_kategoriApiRequest.UpdateKategori(kategori);
			return RedirectToAction("Index");
		}

		public IActionResult Sil(int kategoriId)
		{
			_kategoriApiRequest.DeleteKategori(kategoriId);
			return RedirectToAction("Index");
		}


	}
}
