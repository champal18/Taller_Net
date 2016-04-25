/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 25/4/2016
 * Time: 14:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace Ej1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Hora h1=new Hora(23,30,15);
			h1.imprimir();
			
			Hora h2=new Hora(14.43);
			h2.imprimir();
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Hora
	{
		public double hora;
		public double min;
		public double seg;
		
		public Hora(double hora, double min, double seg)
		{
			this.hora = hora;
			this.min = min;
			this.seg = seg;
		}
		
		public Hora(double hora)
		{
			double aux = hora;
			
			// Hora
			if(hora>24)
				aux = hora%24;	
			this.hora = aux - aux%1;
			
			// Minutos
			aux = (aux - this.hora)*60;
			this.min = aux - aux%1;
			
			// Segundos
			aux = (aux - this.min)*60;
			this.seg = aux - aux%1;
		}
		
		public void imprimir()
		{
			Console.WriteLine("{0} HORAS, {1} MINUTOS Y {2} SEGUNDOS \n",hora,min,seg);
		}
	}
}