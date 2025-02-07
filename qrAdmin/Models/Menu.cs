using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qrAdmin.Models
{
    [Table("Menuler")] // Veritabanındaki tablo adı
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }           // Menü adı
        public string Fiyat { get; set; }           // Menü fiyatı
        public string? ResimYolu { get; set; }   // Opsiyonel resim yolu
    }
}
