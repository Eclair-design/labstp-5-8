using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task51
{
    public class Task51
    {
        public static void Main()
        {
            string text = "Я самая красивая девочка";
            string[] splitted = text.Split(' ');
            Array.Reverse(splitted);
            Console.WriteLine($"{text} - {String.Join(" ", splitted)}");

            string reversed = "";
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine($"{text} - {new string(chars)}");

        }
    }
}