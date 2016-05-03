/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej2
{
	enum genero {Hombre, Mujer};
	
	class Program
	{
		public static void Main(string[] args)
		{
			Persona p = new Persona();
			p.Dni = 36770329;
			p.Nombre = "juan pablo";
			p.FechaNac = new DateTime(1992,06,16);
			p.Sexo = genero.Hombre;
			
			Console.WriteLine("Acceso por propiedad de lectura:\n");
			Console.WriteLine(p.Nombre);
			Console.WriteLine(p.Dni);
			Console.WriteLine(p.FechaNac);
			Console.WriteLine(p.Sexo);
			Console.WriteLine(p.Edad);
			Console.WriteLine("\nLectura por indizadores:\n");
			for(int i=0;i<5;i++)
			{
				Console.WriteLine(p[i]);
			}
			
			Persona p2 = new Persona();
			p2[0] = "Facundo";
			p2[1] = genero.Hombre;
			p2[2] = 3575105;
			p2[3] = new DateTime(1991,1,20);
			
			Console.WriteLine("Acceso por propiedad de lectura:\n");
			Console.WriteLine(p2.Nombre);
			Console.WriteLine(p2.Dni);
			Console.WriteLine(p2.FechaNac);
			Console.WriteLine(p2.Sexo);
			Console.WriteLine(p2.Edad);
			Console.WriteLine("\nLectura por indizadores:\n");
			for(int i=0;i<5;i++)
			{
				Console.WriteLine(p2[i]);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Persona
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