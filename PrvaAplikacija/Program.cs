using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaAplikacija
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ovo je jednolinijski komentar

			/*
			 *	Ovo je viselinijski komentar
			 * 
			 * 
			 */

			//Brojevne vrednosti
			byte bajt = 255;
			sbyte bajtSaZnakom = 127;

			int broj = -10;
			Console.WriteLine("Max i min za int:");
			Console.WriteLine(int.MaxValue);
			Console.WriteLine(int.MinValue);
			uint brojBezZnaka = 2134;
			Console.WriteLine("Max i min za uint:");
			Console.WriteLine(uint.MaxValue);
			Console.WriteLine(uint.MinValue);


			long veeeeelikBroj = 2;
			Console.WriteLine("Max i min za long:");
			Console.WriteLine(long.MaxValue);
			Console.WriteLine(long.MinValue);
			Console.WriteLine("Max i min za long:");
			Console.WriteLine(ulong.MaxValue);
			Console.WriteLine(ulong.MinValue);

			float nesto = (float)3.4567890987645;
			double nekiBroj = 2.5;
			decimal blabla = (decimal)3.4;

			bool IstinaIliLaz = true;
			IstinaIliLaz = false;

			char Karakter = 'a';
			string NekiTekst = "Nesto";
			//Console.WriteLine(NekiTekst);
			
			NekiTekst = "Nesto drugo";
			//Console.WriteLine(NekiTekst);
			Console.ReadKey();
		}
	}
}
