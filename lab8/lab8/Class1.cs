using System;

namespace LR8_Lib
{
	class ArrayMethods
	{
		// 					ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ
		// Получить кол-ва строк
		private int getRows(Array arr)
		{
			return arr.GetUpperBound(0) + 1;
		}
		// Получить кол-ва столбов
		private int getCols(Array arr)
		{
			return arr.GetUpperBound(1) + 1;
		}
		private static void print(dynamic str)
		{
			Console.Write($"{str} \t");
		}
		private static void println(string str)
		{
			Console.WriteLine(str);
		}

		// Создаем объект класса Random для случ. чисел
		private Random rnd = new Random();
		// 1. Заполнить массив цел. числами в заданном инте рвале
		// Если не указаны аргументы => вещ. числа интервал от 0 до 1.

		// Общий метод без явного объявления типа
		// тип dynamic определяется по ходу выполнения проги
		public dynamic FillArray(dynamic arr, int a = 0, int b = 1)
		{
			// Своеобразная проверка на двумерность массива
			// При Вызове метода GetUpperBound(1):
			// 1. если массив двумерный => выполнится блок try
			// 2. если массив одномерный => выйдет ошибка и выполнится блок catch

			try
			{
				// Получить кол-ва строк и стобцов двум. массива
				int rows = this.getRows(arr);
				int cols = this.getCols(arr);

				// Если аргументы не были переданы в функцию
				// => заполнить массив вещ. числами
				if (a == 0 && b == 1)
				{
					for (int i = 0; i < rows; i++)
					{
						for (int j = 0; j < cols; j++)
						{
							arr[i, j] = Math.Round(this.rnd.NextDouble(), 2);
						}
					}
				}
				else
				{
					// Иначе заполнить в интервале от А до B
					for (int i = 0; i < rows; i++)
					{
						for (int j = 0; j < cols; j++)
						{
							arr[i, j] = this.rnd.Next(a, b);
						}
					}
				}
			}
			catch (System.Exception)
			{
				// Одномерный массив 
				if (a == 0 && b == 1)
				{
					for (int i = 0; i < arr.Length; i++)
					{
						arr[i] = Math.Round(this.rnd.NextDouble(), 2);
					}
				}
				else
				{
					for (int i = 0; i < arr.Length; i++)
					{
						arr[i] = this.rnd.Next(a, b);
					}
				}
			}
			return arr;
		}

		// Сумма элементов массива
		public double getSum(dynamic arr)
		{
			// Сумма 
			double s = 0;
			// Ловим ошибку с помощбю блока try/catch 
			// что-бы не было ошибки при использовании функции GetUpperBound(1)
			// Array doesn't have that many dimensions
			try
			{
				// Пытаемся взять кол-ва строк и столбов двумерного массив
				int rows = this.getRows(arr);
				int cols = this.getCols(arr); // Если тут ошибка значит массив одномерный

				// Находим сумму эл-тов 2мерного массива
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < cols; j++)
					{
						s += arr[i, j];
					}
				}
			}
			// Ловим ошибку
			catch (System.Exception)
			{
				// Если мы здесь значит массив одномерный 
				for (int i = 0; i < arr.Length; i++)
				{
					s += arr[i];
				}
			}
			return s;
		}
		// Произведение элементов массива
		// Тоже самое что и выше 
		public double getProizvedenie(dynamic arr)
		{
			double p = 1;
			try
			{
				int rows = this.getRows(arr);
				int cols = this.getCols(arr); // Если тут ошибка значит массив одномерный

				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < cols; j++)
					{
						p *= arr[i, j];
					}
				}

			}
			catch (System.Exception)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					p *= arr[i];
				}
			}
			return p;
		}


		// Получить максимальный эл-т массива
		public void getMax(dynamic arr, ref double max)
		{
			try
			{
				int rows = this.getRows(arr);
				int cols = this.getCols(arr);

				// Ищем максимальный эл-т двумерного массива
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < cols; j++)
					{
						if (arr[i, j] > max)
						{
							max = arr[i, j];
						}
					}
				}
			}
			catch (System.Exception)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					// Если элементы массива == строка
					// То находим максим. длину строки
					if (arr[i].GetType() == typeof(string))
					{
						if (arr[i].Length > max)
						{
							max = arr[i].Length;
						}
					}
					else
					{
						// Иначе находим максим. эл-т строки
						if (arr[i] > max)
						{
							max = arr[i];
						}
					}
				}
			}
		}

		// Либо найти максимальлную по длине строку
		public void getMaxString(string[] arr, ref string maxWord)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i].Length > maxWord.Length)
				{
					maxWord = arr[i];
				}
			}
		}

		// Вывести массив на экран
		public void printArr(dynamic arr)
		{
			try
			{
				for (int i = 0; i < this.getRows(arr); i++)
				{
					for (int j = 0; j < this.getCols(arr); j++)
					{
						print(arr[i, j]);
					}
					println("");
				}
			}
			catch (System.Exception)
			{
				foreach (var num in arr)
				{
					println(num.ToString());
				}
			}
		}
	}
}