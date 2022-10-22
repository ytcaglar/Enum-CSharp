using System;

namespace enum_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Pazar);

            int sicaklik = 28;

            if (sicaklik<=(int)HavaDurumu.soğuk){
                System.Console.WriteLine("Hava bugün çok soğuk.. Bugün dışarı çıkmamalısın...");
            }else if (sicaklik > (int)HavaDurumu.soğuk && sicaklik<=(int)HavaDurumu.normal){
                System.Console.WriteLine("Hava bugün biraz soğuk.. Bugün dışarı çıkarken üstüne montunu almayı unutma...");

            }else if (sicaklik > (int)HavaDurumu.normal && sicaklik<=(int)HavaDurumu.sıcak){
                System.Console.WriteLine("Hava bugün sıcak.. Dışarı çıkmak için güzel bir gün...");

            }else if (sicaklik > (int)HavaDurumu.sıcak && sicaklik<=(int)HavaDurumu.coksıcak){
                System.Console.WriteLine("Hava bugün çok sıcak.. Dışarı çıkarsan güneşte fazla kalmamalısın...");

            }else{
                System.Console.WriteLine("Hava bugün çok çok sıcak.. Dışarı çıkmamalısın...");
            }
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı, 
        Çarşamba,
        Perşembe,
        Cuma, 
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        soğuk = 5,
        normal = 20, 
        sıcak = 30,
        coksıcak = 35,
    }
}