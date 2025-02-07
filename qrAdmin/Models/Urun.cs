using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qrAdmin.Models
{
    [Table("Urunler")] // Veritabanındaki tablo adı
    public class Urun
    {
        [Key]
        public int Id { get; set; } // SQL'deki id ile aynı olmalı
        public string? Ad { get; set; }
        public int? Fiyat { get; set; }
        public string? ResimYolu { get; set; }
    }
}
