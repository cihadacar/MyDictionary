using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, double> birthdays = new MyDictionary<string , double>();
            birthdays.Add("Cihad", 27.01);
            birthdays.Add("Muhammet", 30.12);
            birthdays.Add("Enes", 12.01);
            birthdays.Add("Eren", 30.07);
            birthdays.Add("Salih", 18.06);
            birthdays.Add("Onur", 19.06);
            birthdays.Add("İlke", 07.08);

            birthdays.Print();

        }
    }
}
