using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Lambda.Instance.Predicate();
			Lambda.Instance.Add1();
			Lambda.Instance.Add2();
			Lambda.Instance.Print();
			CanCompareClas.Instance.Sample();

			//
			var str = Encrypt.Instance.ToEncrypt("wangheng", "jingnian");
			Console.WriteLine(str);

			//var str2 = Encrypt.Instance.ToDecrypt("王恒", str);
			//Console.WriteLine(str2);

			Console.ReadKey();
		}
	}

}
