/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 25/4/2016
 * Time: 12:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej21
{
	class Program
	{
		public static void Main(string[] args)
		{	
			double[,] A = new double[,] {{1,2,3},{4,5,6},{7,8,9}};
			double[,] B = new double[,] {{1,2,3},{4,5,6},{7,8,9}};
			
			double[,] C = suma(A,B);
			Console.Write("Suma: \n");
			if(C == null)
				Console.Write("Error de dimensiones");
			else
			{
				for(int i=0;i<C.GetLength(0);i++)
				{
					for(int j=0;j<C.GetLength(1);j++)
						Console.Write("{0}-",C[i,j]);
					Console.Write("\n");
				}
			}
			
			Console.Write("Presione caracter para mostrar resta: \n");
			Console.ReadKey(true);
			
			C = resta(A,B);
			if(C == null)
				Console.Write("Error de dimensiones");
			else
			{
				for(int i=0;i<C.GetLength(0);i++)
				{
					for(int j=0;j<C.GetLength(1);j++)
						Console.Write("{0}-",C[i,j]);
					Console.Write("\n");
				}
			}
			
			Console.Write("Presione caracter para mostrar multiplicacion: \n");
			Console.ReadKey(true);
			
			C = multiplicacion(A,B);
			if(C == null)
				Console.Write("Error de dimensiones");
			else
			{
				for(int i=0;i<C.GetLength(0);i++)
				{
					for(int j=0;j<C.GetLength(1);j++)
						Console.Write("{0}-",C[i,j]);
					Console.Write("\n");
				}
			}
			    
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double[,] suma(double[,] A, double[,] B)
		{
			if((A.GetLength(0) == B.GetLength(0)) && (A.GetLength(1) == B.GetLength(1)))
			{
				double[,] C = new double[A.GetLength(0),A.GetLength(1)];
				for(int i=0;i<A.GetLength(0);i++)
				{
					for(int j=0;j<A.GetLength(1);j++)
					{
						C[i,j] = A[i,j] + B[i,j];
					}
				}
				return C;
			}
			return null;
		}
		
		public static double[,] resta(double[,] A, double[,] B)
		{
			if((A.GetLength(0) == B.GetLength(0)) && (A.GetLength(1) == B.GetLength(1)))
			{
				double[,] C = new double[A.GetLength(0),A.GetLength(1)];
				for(int i=0;i<A.GetLength(0);i++)
				{
					for(int j=0;j<A.GetLength(1);j++)
					{
						C[i,j] = A[i,j] - B[i,j];
					}
				}
				return C;
			}
			return null;
		}
		
		public static double[,] multiplicacion(double[,] A, double[,] B)
		{
			if(A.GetLength(1) == B.GetLength(0))
			{
				double[,] C = new double[A.GetLength(0),B.GetLength(1)];
				int inner = A.GetLength(1);
				for(int i=0;i<A.GetLength(0);i++)
				{	
					for(int j=0;j<B.GetLength(1);j++)
					{
						for(int k=0;k<inner;k++)
						{
							C[i,j] += A[i,k]*B[k,j];
						}
					}
				}
				return C;
			}
			return null;
		}
	}
}