/*Дано значение температуры T в градусах Цельсия. 
 * Определить значение этой же температуры в градусах Фаренгейта.
 * Температура по Цельсию TC и температура 
 * по Фаренгейту TF связаны следующим соотношением: TC = (TF – 32)·5/9.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите температуру в градусах Цельсия: ");
			double TC = double.Parse(Console.ReadLine()); //ТС - температура в Цельсия 
			double TF = 9*TC/5+32; //ТF - температура в Цельсия 
			Console.WriteLine($"Данная температуру в градусах Фаренгейта: {TF:0.000}");
			Console.ReadLine();
		}
	}
}
