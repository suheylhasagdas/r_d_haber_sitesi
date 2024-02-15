﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities
{
	[Table("SLAYTLAR")]
	public class Slaytlar
	{
        [Key]
        [Column("ID")]
        public int Id { get; set; }
		[Column("BASLIK")]
		public string Baslik { get; set; }
		[Column("ICERIK")]
		public string Icerik { get; set; }
		[Column("HABER_ID")]
		public int HaberId { get; set; }
		[Column("RESIM")]
		public string Resim { get; set; }
		[Column("AKTIFMI")]
		public bool Aktifmi { get; set; }
	}
}