/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 19/5/2016
 * Time: 17:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej15
{
	delegate void ContPalabraEventHandler();
	
	class Program
	{
		public static void Main()
		{
			Palabras pal=new Palabras();
			pal.contar();
			Console.ReadKey();
		}
	}
	
	class Palabras
	{
		private int cantPalabras=0;
		
		public void contar()
		{
			Lector miLector=new Lector();
			//miLector.contPalabra = new ContPalabraEventHandler(unaMas);
			miLector.leer();
			Console.WriteLine("Cantidad de palabras leídas: {0}",cantPalabras);
		}
		
		private void unaMas()
		{
			cantPalabras ++;
		}
	}
	
	class Lector
	{
		public ContPalabraEventHandler contPalabra;
		
		public void leer()
		{
			Console.WriteLine("Ingrese una palabra por línea");
			string st=Console.ReadLine();
			if (contPalabra!=null)
			{
				while (st!="")
			
			{
				contPalabra();
				st=Console.ReadLine();
			}
			}
		}
	}
}