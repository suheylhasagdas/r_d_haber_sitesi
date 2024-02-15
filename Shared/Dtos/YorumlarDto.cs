namespace Shared.Dtos
{
	public class YorumlarDto
	{
		public int Id { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string Eposta { get; set; }
		public string Baslik { get; set; }
		public string Icerik { get; set; }
		public int HaberId { get; set; }
		public int EklenmeTarihi { get; set; }
		public bool Aktifmi { get; set; }
	}
}
