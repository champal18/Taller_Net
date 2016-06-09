/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 07:01 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio16
{
	class Program
	{
		enum Meses{Enero,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre};
		
		public static void Main(string[] args)
		{
			
			Meses meses;
			
			// a)
			Console.WriteLine("Ejercicio a)");
			for (meses=Meses.Diciembre;meses>=Meses.Enero;meses--){
				Console.WriteLine(meses);
			}
			
			// b)
			Console.WriteLine("Ejercicio b)");
			for (meses=Meses.Febrero;meses<=Meses.Diciembre;meses+=2){
				Console.WriteLine(meses);
			}
			
			
			// c)
			string texto;
			Console.Write("Ingrese el nombre de un mes: ");
			texto=Console.ReadLine();
			
			for (meses=Meses.Enero;meses<=Meses.Diciembre;meses++){
				if (meses.ToString().Equals(texto)){
					Console.Write("Existe ");
					break;
				}
				else
					if (meses==Meses.Diciembre)
						Console.Write("No Existe ");
					
			}
			
			
			Console.ReadKey(true);
		}
	}
	
}