using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace KullaniciAdiSif.Controllers.Product
{
    public class ProductController : Controller
    {
        public  class ModelBinding
        {
            public static ModelBinding model;
            public string kullaniciadi { get; set; }
            public string sifre { get; set; } 
            static ModelBinding()
            {      
                if(model==null)
                {
                    model = new ModelBinding();
                }
                    
            }
        }
        public class Kontrol
        {
            public static Kontrol kontrol;
            public string kullanici_adkontrol { get; set; } 
            public string kullanici_sifkontrol { get; set; } 

            static Kontrol()
            {
                if(kontrol==null)
                {
                    kontrol = new Kontrol();
                }
                
            }
        }
        
        public IActionResult Giris()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Giris(string txt_Name,string txt_sif)
        {
            ModelBinding.model.kullaniciadi =txt_Name;
            ModelBinding.model.sifre = txt_sif;
            string data = JsonSerializer.Serialize(ModelBinding.model);
            TempData["product"] = data;
         
            return View();
        }
        [HttpPost]
        public IActionResult KontrolGiris(string kntrl_id, string kntrl_sif)
        {
            string data = TempData["product"].ToString();
            ModelBinding cevir = JsonSerializer.Deserialize<ModelBinding>(data);
            Kontrol.kontrol.kullanici_adkontrol = kntrl_id;
            Kontrol.kontrol.kullanici_sifkontrol = kntrl_sif;
            if (cevir.kullaniciadi == Kontrol.kontrol.kullanici_adkontrol && cevir.sifre ==Kontrol.kontrol.kullanici_sifkontrol)
            {

            }
            else
            {

            }
            return View();
        }

    }
}
