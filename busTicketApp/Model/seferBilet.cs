//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace busTicketApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class seferBilet
    {
        public int seferBilet_id { get; set; }
        public int otobus_id { get; set; }
        public int guzergah_id { get; set; }
        public int sefer_id { get; set; }
        public string koltukNo { get; set; }
        public string kalkisSaati { get; set; }
        public System.DateTime kalkisTarih { get; set; }
        public string yolcuAd { get; set; }
        public string yolcuSoyad { get; set; }
        public string cinsiyet { get; set; }
        public System.DateTime tarihSaat { get; set; }
        public int fiyat { get; set; }
    
        public virtual guzergah guzergah { get; set; }
        public virtual otobus otobus { get; set; }
        public virtual seferler seferler { get; set; }
    }
}
