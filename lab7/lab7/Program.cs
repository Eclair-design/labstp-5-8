namespace Task7
{
    public class Program
    {
        public static string defaultPath = @"C:\Users\yvetlin\Desktop\labs\lab7\Task7.txt";
        public static StreamWriter sw = new StreamWriter(defaultPath, false, System.Text.Encoding.Default);
        public static void Main()
        {
            animal h1 = new animal("Еж", "Млеки", 200);
            animal h2 = new animal();

            h1.Weight = 250;
            h1.Title = "Еж ушастый";
            h2.Title = "Еж карликовый";

            h1.SaveToFile();
            h2.SaveToFile();

            bool result = h1.Weight > h2.Weight;
            Console.WriteLine($"Перезагруженный >: {result}");
            Console.WriteLine($"Метод для рекламы: {h1.GetAdTitle()}");

            animal h3 = h1 + h2;

        }
    }

    public class animal
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = "Вид: " + value;
            }
        }

        private string clas;
        public string Clas
        {
            get
            {
                return clas;
            }
            private set
            {
                clas = value;
            }
        }

        private int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value > 0 ? value : 1;
            }
        }

        public static animal operator +(animal h1, animal h2)
        {
            return new animal(h1.Title, h2.Clas, h1.weight + h2.weight);     //Объяснение программе как складывать животных
        }

        public static bool operator >(animal h1, animal h2)
        {
            return h1.weight > h2.weight;
        }

        public static bool operator <(animal h1, animal h2)
        {
            return h1.weight < h2.weight;
        }                                                                       //Объяснение программе как сравнивать книги

        public animal(string title, string author, int pages)
        {
            Title = title;
            Clas = Clas;
            Weight = weight;
        }

        public animal()
        {
            Title = "Еж Лесной";
            Clas = "Млеки";
            Weight = 261;
        }

        public string GetAdTitle()
        {
            return $"Класный еж это {title} {clas}!";
        }

        public void SaveToFile()
        {
            try
            {
                using (Program.sw)
                {
                    Program.sw.WriteLine(title + " " + " вес: " + weight);
                }
                Program.sw = new StreamWriter(Program.defaultPath, true, System.Text.Encoding.Default);
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }
    }
}