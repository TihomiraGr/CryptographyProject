
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string s = File.ReadAllText("EncryptedMessage1.txt");  //шифротекстът от файла се чете и се записва в стринг

        int[] frequencyArray = new int[char.MaxValue]; //char.MaxValue е достатъчно голяма константа

        foreach (char ch in s)
        {
            frequencyArray[ch]++;      // стрингът се обхожда и се записва броят на срещанията на всеки символ в масива
        }

        for (int i = 0; i < char.MaxValue; i++)
        {
            if (frequencyArray[i] != 0 && char.IsLetter((char)i))
            { 
                Console.WriteLine("Буква: {0}  Честота: {1}", (char)i, frequencyArray[i]);    //масивът се обхожда и се изписва всеки срещнат символ,
                                                                                              //който е буква, и неговата честота 
            }
        }

        //Стъпка 1
        s = s.Replace("А", "а");           //използват се малки букви като placeholder-и
        s = s.Replace("Г","А");
        s = s.Replace("Е", "е");
        s = s.Replace("Ф", "Е");

        //Стъпка 2
        s = s.Replace("Н", "н");
        s = s.Replace("Б", "Н");

        //Стъпка 3
        s = s.Replace("И", "и");
        s = s.Replace("Ъ", "И");

        //Стъпка 4
        s = s.Replace("О", "о");
        s = s.Replace("Ж", "О");

        //Стъпка 5
        s = s.Replace("Я", "я");
        s = s.Replace("Щ", "Я");
        s = s.Replace("Ъ", "ъ");
        s = s.Replace("я", "Ъ");
        s = s.Replace("Д", "д");
        s = s.Replace("о", "Д");

        //Стъпка 6
        s = s.Replace("Л", "л");
        s = s.Replace("С", "Л");
        s = s.Replace("Ч", "ч");
        s = s.Replace("М", "Ч");
        s = s.Replace("В", "в");
        s = s.Replace("ч", "В");

        //Стъпка 7
        s = s.Replace("Т", "т");
        s = s.Replace("л", "Т");
        s = s.Replace("н", "Б");
        s = s.Replace("З", "з");
        s = s.Replace("Й", "З");
        s = s.Replace("Р", "р");
        s = s.Replace("з", "Р");

        //Стъпка 8
        s = s.Replace("П", "п");
        s = s.Replace("Ь", "П");
        s = s.Replace("в", "С");
        s = s.Replace("Щ", "щ");
        s = s.Replace("Ш", "Щ");
        s = s.Replace("У", "Й");

        //Стъпка 9
        s = s.Replace("т", "Г");
        s = s.Replace("р", "М");
        s = s.Replace("е", "Ж");
        s = s.Replace("Ц", "ц");
        s = s.Replace("п", "Ц");

        //Стъпка 10
        s = s.Replace("Х", "Ь");
        s = s.Replace("д", "У");
        s = s.Replace("а", "Ф");
        s = s.Replace("ц", "Х");
        s = s.Replace("и", "Ш");

        Console.WriteLine("\n");
        Console.WriteLine(s);

        //Comment1
    }
}

