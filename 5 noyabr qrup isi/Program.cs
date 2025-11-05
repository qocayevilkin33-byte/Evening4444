using _5_noyabr_qrup_isi.Models;

namespace _5_noyabr_qrup_isi
{
    internal class Program
    {



        static void ToUpperCase(string text)
        {
            Console.WriteLine(text.ToUpper());
        }
        static void ToLowerCase(string text)
        {
            Console.WriteLine(text.ToLower());
        }
        static void ReverseText(string text)
        {
           
            var reversedText = new string(text.Reverse().ToArray());
            Console.WriteLine(reversedText);
        }
        
        static void RemoveSpaces(string text)
        {
            Console.WriteLine(text.Replace(" ", ""));
        }

        //static void ContainsDigit(string word)
        //{
        //    foreach (char c in word)
        //    {
        //        if (char.IsDigit(c))
        //        {
        //            Console.WriteLine("soz reqem etiva edir");
        //            return;
        //        }
        //    }
        //}
        //static void ContainsUppercase(string word)
        //{
        //    foreach (char c in word)
        //    {
        //        if (char.IsUpper(c))
        //        {
        //            Console.WriteLine("soz boyuk herf ehtiva edir");
        //            return;
        //        }
        //    }
        //}
        //static void ContainsSymbol(string word)
        //{
        //    foreach (char c in word)
        //    {
        //        if (!char.IsLetterOrDigit(c))
        //        {
        //            Console.WriteLine("soz simvol ehtiva edir");
        //            return;
        //        }
        //    }
        //}
        //static void ContainsQuest(string sentence)
        //{
        //    if (sentence.Contains('?'))
        //    {
        //        Console.WriteLine("cumlede sual isaresi var");
        //    }
        //}
        //static void ContainsEx(string sentence)
        //{
        //    if (sentence.Contains('!'))
        //    {
        //        Console.WriteLine("cumlede nida isaresi var");
        //    }

        //}
        //static void ContainsDot(string sentence)
        //{
        //    if (sentence.Contains('.'))
        //    {
        //        Console.WriteLine("cumlede nuqte isaresi var");
        //    }
        // }
        static void Main(string[] args)
        {
            Console.WriteLine("Metn daxil edin:");
            string text = Console.ReadLine();

            Console.WriteLine("Hansi transformasiyanı seçmək istəyirsiniz?");
            Console.WriteLine("1 - Hərfleri böyütmək");
            Console.WriteLine("2 - Hərfleri kiçiltmək");
            Console.WriteLine("3 - Metni tərsinə çevirmək");
            Console.WriteLine("4 - Boşluqları silmək");

            int choice = Convert.ToInt32(Console.ReadLine());

           
            switch (choice)
            {
                case 1:
                    ToUpperCase(text);
                    break;
                case 2:
                    ToLowerCase(text);
                    break;
                case 3:
                    ReverseText(text);
                    break;
                case 4:
                    RemoveSpaces(text);
                    break;
                default:
                    Console.WriteLine("Yanlış seçim etdiniz.");
                    break;
            }
        }
        //Console.WriteLine("metn daxil edin:");
        //string text = Console.ReadLine();
        //TextTransformer transformer = null;

        //transformer += ToUpperCase;
        //transformer += ToLowerCase;
        //transformer += ReverseText;
        //transformer += RemoveSpaces;
        //transformer(text);

        //    Console.WriteLine("cumle daxil edin:");
        //    string sentence = Console.ReadLine();
        //    SentenceAnalyzer analyzer = null;
        //    analyzer += ContainsQuest;
        //    analyzer += ContainsEx;
        //    analyzer += ContainsDot;
        //    analyzer(sentence);


        //Console.WriteLine("soz daxil edin:");
        // string word = Console.ReadLine();
        // StringAnalyzer analyzer1 = null;
        // analyzer1 += ContainsDigit;
        // analyzer1 += ContainsUppercase;
        // analyzer1 += ContainsSymbol;
        // analyzer1(word);
        // Console.ReadLine();
    }
    }

