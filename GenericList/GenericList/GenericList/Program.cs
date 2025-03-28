using GenericList;

public class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new();

        while (arabalar.Count < 3 || DevamEtmekIstiyorMu())
        {
            Console.Write("Marka Adı: ");
            string markaAdi = Console.ReadLine();

            Console.Write("Model Adı: ");
            string modelAdi = Console.ReadLine();

            Console.Write("100 km'de Yaktığı Yakıt (L): ");
            double benzinHarcamasi = double.Parse(Console.ReadLine());

            Console.WriteLine("Toplam Gidilen Mesafe (km): ");
            int toplamMesafe = int.Parse(Console.ReadLine());

            Marka marka = new Marka { Id = arabalar.Count + 1, Ad = markaAdi, ImageUrl = $"{markaAdi.ToLower()}.jpg" };
            Model model = new Model { Id = arabalar.Count + 1, Ad = modelAdi, ImageUrl = $"{modelAdi.ToUpper()}.jpg" };
            Araba araba = new Araba(marka, model, benzinHarcamasi, toplamMesafe);
            arabalar.Add(araba);


        }
        Console.WriteLine("/n----Eklenen Araba");
        foreach (var araba in arabalar)
        {

            Console.WriteLine($"Marka: {araba.Marka.Ad}, Model: {araba.Model.Ad}, 100 km'de Yaktığı Yakıt:" +
                $" {araba.BenzinHarcamasi} litre, Toplam Yakıt Tüketimi: {araba.Hesapla():0.00} L");



        }
    }

    public static bool DevamEtmekIstiyorMu()
    {
        Console.Write("Yeni bir araba eklemek ister misiniz? (e/h): ");
        string cevap = Console.ReadLine().ToLower();
        return cevap == "e";
    }
}