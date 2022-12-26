namespace Task61
{
    public class Task61
    {
        public static void Main()
        {
            string text = "";
            string path = @"C:\Users\Yvetlin\Desktop\labs\lab6\Task61.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var splitted = CustomSplitBy(text, new char[] { '.', '?', '!' });

            ////task 1
            //Console.WriteLine("С гласных букв:");
            //splitted.ForEach(s =>
            //{
            //    char first = s.ToCharArray().First();
            //    bool isVowel = "aeiouAEIOU".IndexOf(first) >= 0;
            //    if (isVowel) Console.WriteLine(s);
            //});

            ////task 2
            //Console.WriteLine("Без запятых:");
            //splitted.ForEach(s =>
            //{
            //    if (!s.Contains(',')) Console.WriteLine(s);
            //});

            ////task 3
            //Console.WriteLine("Предложения и кол-во слов:");
            //splitted.ForEach(s =>
            //{
            //    Console.WriteLine($"{s} {s.Length}");
            //});

            ////task 4
            //Console.WriteLine("С цифрами:");
            //splitted.ForEach(s =>
            //{
            //    if (s.Any(char.IsDigit)) Console.WriteLine(s);
            //});

            //task 5
            Console.WriteLine("Слова с гласными в начале и конце:");
            char[] wordSeparators = new char[] { ' ', ';', ':', ',', '.', '?', '!' };
            var splittedWords = text.Split(wordSeparators);
            foreach (string word in splittedWords)
            {
                char[] wordChars = word.ToCharArray();
                if (word == "") continue;
                if ("aeiouAEIOU".IndexOf(wordChars.First()) >= 0 && "aeiouAEIOU".IndexOf(wordChars.Last()) >= 0)
                    Console.WriteLine(word);
            }

            ////task 6
            //Console.WriteLine("Цифры в слова:");
            //String text2 = text;
            //text2 = text2.Replace("0", "ноль");
            //text2 = text2.Replace("1", "один");
            //text2 = text2.Replace("2", "два");
            //text2 = text2.Replace("3", "три");
            //text2 = text2.Replace("4", "четыре");
            //text2 = text2.Replace("5", "пять");
            //text2 = text2.Replace("6", "шесть");
            //text2 = text2.Replace("7", "семь");
            //text2 = text2.Replace("8", "восемь");
            //text2 = text2.Replace("9", "девять");
            //Console.WriteLine(text2);

            ////task 7
            //Console.WriteLine("Вопросительные, затем повествовательные:");
            //List<string> question = new List<string>();
            //List<string> narrative = new List<string>();

            //splitted.ForEach(s =>
            //{
            //    if (s.Last() == '?') question.Add(s);
            //    if (s.Last() == '.') narrative.Add(s);
            //});
            //question.ForEach(s => Console.WriteLine(s));
            //narrative.ForEach(s => Console.WriteLine(s));

            ////task 8
            //string longestWord = "";
            //int maxLength = 0;
            //int count = 0;
            //foreach (string word in splittedWords)
            //{
            //    if (word.Length > maxLength)
            //    {
            //        maxLength = word.Length;
            //        longestWord = word.ToLower();
            //    }
            //};
            //foreach (string word in splittedWords)
            //{
            //    if (word.ToLower().Equals(longestWord)) count++;
            //}
            //Console.WriteLine($"Кол-во слов {longestWord} - {count}");

            ////task 9
            //Console.WriteLine("Однобуквенные, затем обычные:");
            //List<string> onechar = new List<string>();
            //List<string> other = new List<string>();

            //splitted.ForEach(s =>
            //{
            //    string firstWord = s.Split(wordSeparators)[0];
            //    if (firstWord.Length == 1) onechar.Add(s);
            //    else other.Add(s);
            //});
            //onechar.ForEach(s => Console.WriteLine(s));
            //other.ForEach(s => Console.WriteLine(s));


            ////task 9
            //Console.WriteLine("Максимальное кол-во знаков пунктуации:");
            //int maxPunctuation = 0;
            //String sentence = "";

            //char[] punctMarks = new char[] { ',', ';', ':', '-', '(', ')', '\"', '\'' };
            //splitted.ForEach(s =>
            //{
            //    int length = s.Split(punctMarks).Length;
            //    if (length > maxPunctuation)
            //    {
            //        maxPunctuation = length;
            //        sentence = s;
            //    }
            //});
            //Console.WriteLine($"{sentence}");


        }

        public static List<string> CustomSplitBy(String text, char[] separators)
        {
            var splitted = new List<string>();
            string s1 = "";
            foreach (char c in text.ToCharArray())
            {
                if (separators.Contains(c))
                {
                    s1 += c;
                    splitted.Add(s1.Trim());
                    s1 = "";
                }
                else s1 += c;
            }
            return splitted;
        }
    }
}