using System;
using LR8_Lib;

namespace LR8
{
	class Program
	{
		static void Main(string[] args)
		{
			// Создаем объект класса для методов массива
			ArrayMethods AM = new ArrayMethods();

			// Создаем одномерные массивы
			int[] arr1 = new int[5];
			double[] arr2 = new double[5];

			// Создаем двумерные массивы
			int[,] arr3 = new int[5, 5];
			double[,] arr4 = new double[5, 5];

			// Создаем строковый массив
			string lorem = "Lorem ipsum dolor sit amet consectetur adipisicing elit Magni necessitatibus Possimus ullam eveniet vel ut totam nisi odio consectetur cum fugiat nam quidem temporibus at asperiores corrupti porro quisquam blanditiis";
			string[] arr5 = lorem.Split(' ');

			// Заполняем массив целыми числами от a до b
			int a = 10;
			int b = 30;

			//										1,5 ЗАДАНИЕ
			println($"Заполняем одномерный массив целыми числами от {a} до {b}");
			AM.FillArray(arr1, a, b);
			AM.printArr(arr1);
			println("========================================");
			println("Заполняем одномерный массив вещ числами от 0 до 1");
			AM.FillArray(arr2);
			AM.printArr(arr2);
			println("========================================");
			println($"Заполняем двумерный массив целыми числами от {a} до {b}");
			AM.FillArray(arr3, a, b);
			AM.printArr(arr3);
			println("========================================");
			println("Заполняем двумерный массив вещ числами от 0 до 1");
			AM.FillArray(arr4);
			AM.printArr(arr4);


			//										2 ЗАДАНИЕ 
			println("========================================");
			println("Находим сумму элементов каждого массива");
			// Сумма элементов массивов 
			println("sum of array 1: " + AM.getSum(arr1));
			println("sum of array 2: " + AM.getSum(arr2));
			println("sum of array 3: " + AM.getSum(arr3));
			println("sum of array 4: " + AM.getSum(arr4));
			//										3 ЗАДАНИЕ
			println("========================================");
			println("Находим произведения элементов каждого массива");
			// Произведение элементов массивов 
			println("Proizv of array 1: " + AM.getProizvedenie(arr1));
			println("Proizv of array 2: " + AM.getProizvedenie(arr2));
			println("Proizv of array 3: " + AM.getProizvedenie(arr3));
			println("Proizv of array 4: " + AM.getProizvedenie(arr4));
			//										4 ЗАДАНИЕ
			println("========================================");
			println("Находим максимальный элемент каждого массива");
			// Максимальный элемент массивов с ref
			double max1 = 0;
			double max2 = 0;
			double max3 = 0;
			double max4 = 0;
			// Макс длина строки
			double max5 = 0;
			// Макс строка по длине
			string maxWord = "";

			// Находим максимумы
			AM.getMax(arr1, ref max1);
			AM.getMax(arr2, ref max2);
			AM.getMax(arr3, ref max3);
			AM.getMax(arr4, ref max4);
			AM.getMax(arr5, ref max5);
			AM.getMaxString(arr5, ref maxWord);

			println($"Max of array 1: {max1}");
			println($"Max of array 2: {max2}");
			println($"Max of array 3: {max3}");
			println($"Max of array 4: {max4}");
			println($"Max of array 5: {max5} : {maxWord}");
			Console.ReadKey();
		}

		public static void println(dynamic str)
		{
			Console.WriteLine(str);
		}
	}
}
