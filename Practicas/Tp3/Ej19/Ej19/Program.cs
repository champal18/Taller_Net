/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 17/4/2016
 * Time: 18:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej19
{
	class Program
	{
		public static void Main(string[] args)
		{
			double[,] matriz = new double[,] {{1,2,3},{4,5,6},{7,8,9}};
			double[] rta =  new double[3];
			
			rta = getDiagonalPpal(matriz);
			Console.Write("Diagonal principal: \n");
			if(rta != null)
				for(int i=0;i<rta.Length;i++)
					Console.Write("{0}-",rta[i]);
			else
					Console.WriteLine("La matriz no es cuadrada");
			
			Console.Write("\nDiagonal secundaria: \n");
			rta = getDiagonalSec(matriz);
			if(rta != null)
				for(int i=0;i<rta.Length;i++)
					Console.Write("{0}-",rta[i]);
			else
					Console.WriteLine("La matriz no es cuadrada");
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double[] getDiagonalPpal(double[,] matriz)
		{
			double[] resultado = new double[matriz.GetLength(0)];
			if(matriz.GetLength(0) == matriz.GetLength(1))
			{
				for(int i=0;i<matriz.GetLength(1);i++)
					resultado[i] = matriz[i,i];
				return resultado;
			}
			else
				return null;
		}
		
		public static double[] getDiagonalSec(double[,] matriz)
		{
			double[] resultado = new double[matriz.GetLength(0)];
			if(matriz.GetLength(0) == matriz.GetLength(1))
			{
				for(int i=matriz.GetLength(0);i>=0;i--)
					for(int j=0;j<matriz.GetLength(0);j++)
						if(matriz.GetLength(0)-1-i == j)
							resultado[j] = matriz[i,j];
				return resultado;
			}
			else
				return null;
		}
	}
}