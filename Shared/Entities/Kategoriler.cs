﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities
{
	[Table("KATEGORILER")]
	public class Kategoriler
	{
        [Key]
        [Column("ID")]
        public int Id { get; set; }
		[Column("ACIKLAMA")]
		public string Aciklama { get; set; }

		[Column("AKTIFMI")]
		public bool Aktifmi { get; set; }
    }
}