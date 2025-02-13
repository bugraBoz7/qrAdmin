using qrAdmin.Models;

namespace qrAdmin.Models
{
    public class IndexViewModel
    {
        public List<Urun> ?Hamburgerler { get; set; }
        public List<Urun> ?BMenuler { get; set; }
        public List<Urun> ?Menuler { get; set; }
        public List<Urun> ?Sandvicler { get; set; }
        public List<Urun> ?Tostlar { get; set; }
        
        public List<Urun> ?Salatalar { get; set; }
        public List<Urun> ?YanUrunler { get; set; }

        public List<Urun> ?EkstraMal { get; set; }
        public List<Urun> ?Icecekler { get; set; }




    }
}
