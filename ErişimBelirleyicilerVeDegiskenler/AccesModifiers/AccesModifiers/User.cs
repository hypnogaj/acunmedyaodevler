using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    public class User
    {
        private string adSoyad;
        private int yas;

        public string Email { get; set; }

        // Getter ve Setter metodları
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int yas)
        {
            if (yas > 0)
            {
                this.yas = yas;
            }
            else
            {
                Console.WriteLine("Yaş negatif olamaz!");
            }
        }

        // Bilgileri gösteren metot
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}\nYaş: {yas}\nEmail: {Email}");
        }
    }
}