/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 17/4/2016
 * Time: 19:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej20
{
	class Program
	{
		public static void Main(string[] args)
		{
			double[,] matriz = new double[,] {{1,2,3},{4,5,6},{7,8,9},{10,11,12},{13,14,15}};
			double[][] array = getArreglo(matriz);
			
			int num = array.GetLength(0);
			Console.Write("Arreglo: ");
			for(int i=0; i<array.GetLength(0);i++)
				for(int j=0;j<array[i].GetLength(0);j++)
					Console.Write("{0}-",array[i][j]);
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double[][] getArreglo(double[,] matriz)
		{
			double[][] array = new double[matriz.GetLength(0)][];
			for(int i=0;i<matriz.GetLength(0);i++)
			{
				array[i] = new double[matriz.GetLength(1)];
				for(int j=0;j<matriz.GetLength(1);j++)
					array[i][j] = matriz[i,j];
			}
			return array;
		}
	}
}