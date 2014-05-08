using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDemo
{
	public class Lambda
	{
		#region Instacne
		private static Lambda instance = new Lambda();
		public static Lambda Instance { get { return instance; } }
		private Lambda() { }
		#endregion

		public void Predicate()
		{
			string[] arrauString = new string[]
			{
				"one","Two","Thee","Four"
			};
			string[] arrayResult = Array.FindAll(arrauString, (c) => c.Length > 3);
		}
		public void Add1()
		{
			Func<int, int, int> sum = add;
			Action<string> print = Print;
			print(sum(1, 2).ToString());

		}

		public void Add2()
		{
			Func<int, int, int> sum = new Func<int, int, int>(delegate(int i, int j)
				{
					return i + j;
				});
			Action<string> print = new Action<string>(delegate(string message)
				{
					Console.WriteLine(message);
				});
			print(sum(12, 24).ToString());
		}

		public void Add3()
		{
			Func<int, int, int> sum = delegate(int i, int j)
			{
				return i + j;
			};
			Action<string> print = delegate(string message)
			{
				Console.WriteLine(message);
			};
		}

		public void Addd4()
		{
			Func<int, int, int> sum = (x, y) => x + y;
			Action<string> print = (message) => Console.WriteLine(message);
		}

		protected int add(int i, int j)
		{
			return i + j;
		}

		protected void Print(string message)
		{
			Console.WriteLine(message);
		}

		public void Print()
		{
			string str = "1";
			var res = str.ToInt();
			Console.WriteLine(res);
		}

		public void Linq()
		{
			int[] numbers = { 2, 5, 28, 31, 42 };
			var query = from itr in numbers
						where itr < 20
						select itr;

		}
	}

	public static class StringExtension
	{
		public static int ToInt(this string str, int result = -10)
		{
			int value;
			if (int.TryParse(str, out value))
			{
				return value;
			}
			else
			{
				return result;
			}
		}
	}
}
