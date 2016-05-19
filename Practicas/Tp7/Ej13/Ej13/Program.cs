/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 19/5/2016
 * Time: 17:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej13
{
	delegate void TicEventHandler(DateTime hora);
	
	class program
	{
		static int cont=0;
		static Clock reloj=new Clock();
		
		static void Main()
		{
			reloj.Tic=new TicEventHandler(Tic);
			reloj.run();
			
			Console.ReadKey();
		}
	
		private static void Tic(DateTime horaActual)
		{
			Console.WriteLine(horaActual);
			cont++;
			if(cont==10)
				reloj.Detener();
		}
		
	}
	
	class Clock
	{
		private bool detener;
		public TicEventHandler Tic;
		
		public void run()
		{
			DateTime hora=DateTime.Parse("1/1/2000"),horaAux=DateTime.Now;
			detener=false;
			while (!detener)
			{
				if(hora.Second != horaAux.Second)
				{
					hora=horaAux;
					if(Tic!=null)
						Tic(hora);
				}
				horaAux=DateTime.Now;
			}
		}
		
		public void Detener()
		{
			detener=true;
		}
	}
}