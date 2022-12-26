using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task52
{
    class Task52
    {
        static void Main(string[] args)
        {
            string text = "So for example, if they got two halves of a 500 soum note,they could get 500 soum in cash in the Shell shop.";

            var arrayword = text.Split(' ', ',', '.');
            var k = 0;
            foreach (var word in arrayword)
                if (word.Length > k)
                    k = word.Length;
            Console.WriteLine(k);
            foreach (char c in text)
            {
                if (char.IsLetter(c) && char.IsLower(c))
                {
                    if ((int)c <= 122 - k)
                        Console.Write((char)((int)c + k));
                    else
                        Console.Write((char)((int)c + k - 26));
                }
                else
                    if (char.IsLetter(c) && char.IsUpper(c))
                {
                    if ((int)c <= 90 - k)
                        Console.Write((char)((int)c + k));
                    else
                        Console.Write((char)((int)c + k - 26));
                }
                else
                    Console.Write(c);

            }


            Console.ReadLine();

        }
    }
}