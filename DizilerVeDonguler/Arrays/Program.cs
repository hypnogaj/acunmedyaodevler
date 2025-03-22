using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5]; 
        int sum = 0; 

        Console.WriteLine("Lütfen 5 adet sayı giriniz:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");

            
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Geçerli bir sayı giriniz: ");
            }

            sum += numbers[i]; 
        }

        double average = (double)sum / numbers.Length; 
        Console.WriteLine($"Girilen sayıların ortalaması: {average:F2}");
    }
}
