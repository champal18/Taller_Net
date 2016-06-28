/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 14:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej3
{
	enum genero {Hombre, Mujer};
	
	class Program
	{
		public static void Main(string[] args)
		{
			// Test
			ListaDePersonas list = new ListaDePersonas();
			
			Persona p = new Persona();
			p.Nombre = "juan";
			p.Dni = 36770329;
			p.FechaNac = new DateTime(1992,6,16);
			p.Sexo = genero.Hombre;
			list.Agregar(p);
			
			Persona p1 = new Persona();
			p1.Nombre = "julian";
			p1.Dni = 35755105;
			p1.FechaNac = new DateTime(1991,3,22);
			p1.Sexo = genero.Hombre;
			list.Agregar(p1);
			
			Persona p2 = new Persona();
			p2.Nombre = "facundo";
			p2.Dni = 34777666;
			p2.FechaNac = new DateTime(1991,1,20);
			p2.Sexo = genero.Hombre;
			list.Agregar(p2);
			
			// Inciso A
			// Busqueda de persona existente
			Persona p3 = new Persona();
			p3 = list[36770329];
			Console.WriteLine("Nombre buscado por dni: ");
			Console.WriteLine(p3.Nombre);
			
			// Busqueda de persona inexistente
			p3 = list[1];
			if(p3 == null)
				Console.WriteLine("\nLa persona con el dni indicado no existe!");
				
			// Inciso B
			String[] array = list['j'];
			Console.WriteLine("\nNombre buscado por primera letra:");
			for(int i=0;i<array.Length;i++)
				Console.WriteLine(array[i]);
			
			array = list['x'];
			if(array == null)
				Console.WriteLine("\nNo existen personas que empiecen por el caracter elegido!");
				
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class ListaDePersonas
	{
		private ArrayList lista = new ArrayList();
		
		public void Agregar(Persona p)
		{
			lista.Add(p);
		}
		
		// Inciso A
		public Persona this[int indice]
		{
			get
			{
				for(int i=0;i<lista.Count;i++)
				{
					Persona aux = (Persona)lista[i];
					if(aux.Dni == indice)
						return aux;
				}
				return null;
			}
		}
		
		// Inciso B
		public String[] this[char indice]
		{
			get
			{
				ArrayList auxList = new ArrayList();
				int cont = 0;
				for(int i=0;i<lista.Count;i++)
				{
					Persona aux = (Persona)lista[i];
					if(aux.Nombre[0] == indice)
					{
						auxList.Add(aux.Nombre);
						cont++;
					}
				}
				String[] resultado = new string[auxList.Count];
				for(int i=0;i<auxList.Count;i++)
				{
					resultado[i] = (String)auxList[i];
				}
				if(cont == 0)
					return null;
				else
					return resultado;
			}
		}
	}
	
	class Persona // Ejercicio 2 de la practica 6
	{
		private String nombre;
		private genero sexo;
		private int dni;
		private DateTime fechaNac;
		private int edad;
		
		public String Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}
		
		public genero Sexo
		{
			get
			{
				return this.sexo;
			}
			set
			{
				this.sexo = value;
			}
		}
		
		public int Dni
		{
			get
			{
				return this.dni;
			}
			set
			{
				this.dni = value;
			}
		}
		
		public DateTime FechaNac
		{
			get
			{
				return this.fechaNac;
			}
			set
			{
				this.fechaNac = value;
				this.edad = (DateTime.Today.AddTicks(-this.fechaNac.Ticks).Year - 1);
			}
		}
		
		public int Edad
		{
			get
			{
				return this.edad;
			}
		}
		
		public Object this[int indice]
		{
			get
			{
				switch(indice)
				{
					case 0:
					{
						return this.nombre;
					}
					case 1:
					{
						return this.sexo;
					}
					case 2:
					{
						return this.dni;
					}
					case 3:
					{
						return this.fechaNac;
					}
					case 4:
					{
						return this.edad;
					}
					default:
					{
						Console.WriteLine("\nError de indice\n");
						break;
					}
				}
				return null;
			}
			set
			{
				switch(indice)
				{
					case 0:
					{
							this.nombre = (String)value;
						break;
					}
					case 1:
					{
						this.sexo = (genero)value;
						break;
					}
					case 2:
					{
						this.dni = (int)value;
						break;
					}
					case 3:
					{
						this.fechaNac = (DateTime)value;
						this.edad = (DateTime.Today.AddTicks(-this.fechaNac.Ticks).Year - 1);
						break;
					}
					default:
					{
						Console.WriteLine("\nError de indice\n");
						break;
					}
				}
			}
		}
		
	}
}