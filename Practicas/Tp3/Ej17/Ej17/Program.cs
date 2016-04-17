/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 17/4/2016
 * Time: 18:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej17
{
	class Program
	{
		public static void Main(string[] args)
		{
			double[,] matriz = new double[,] {{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
			imprimirMatriz(matriz);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void imprimirMatriz(double[,] matriz)
		{
			for(int i=0;i<matriz.GetLength(0);i++)
			{
				for(int j=0;j<matriz.GetLength(1);j++)
					Console.Write("{0}-",matriz[i,j]);
				Console.Write("\n");
			}
		}
	}
}