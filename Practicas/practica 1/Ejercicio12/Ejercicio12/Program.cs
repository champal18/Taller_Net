/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 03/05/2016
 * Time: 12:35 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio12
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i;
			
			for(i=17;i<1001;i++){
				if(i%17 == 0)
					Console.Write("Multiplo de 17:"+i+"\n");
				if(i%29 == 0)
					Console.Write("Multiplo de 29:"+i+"\n");
				
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}