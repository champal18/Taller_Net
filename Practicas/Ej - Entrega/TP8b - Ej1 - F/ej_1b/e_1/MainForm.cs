/*
 * Created by SharpDevelop.
 * User: Fuentes-Labrune
 * Date: 17/06/2016
 * Time: 20:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace e_1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		
		//EVENTOS RELACIONADOS CON BOTONES DIRECCIONALES
		
		void Button1Click(object sender, EventArgs e) //direccion derecha
		{
			int w;
			try //compruebo que se ingrese un paso valido
			{
				w=int.Parse(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("Paso incorrecto. Se usara paso=10");
				textBox1.Text="10";
				w=10;
			}

			if ((label1.Right+w)<=(panel2.Width)) //si no se va del limite agrando el label segun el paso
			{
				this.label1.Width=(this.label1.Width+w);
			}
			else //sino lo agrando hasta el borde y deshabilito el boton
			{
				this.label1.Width+=(panel2.Width-label1.Right);
				button1.Enabled=false;
				
			}
			
			label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
		}
		
		
		void Button2Click(object sender, EventArgs e) //direccion izquierda
		{
			int w;
			try //compruebo que se ingrese un paso valido
			{
				w=int.Parse(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("Paso incorrecto. Se usara paso=10");
				textBox1.Text="10";
				w=10;
			}
			
			if ((label1.Left-w)>=0) //si no se va del limite agrando el label segun el paso
			{
				this.label1.Width=(this.label1.Width+w);
				this.label1.Left-=w;
			}
			else //sino lo agrando hasta el borde y deshabilito el boton
			{
				
				this.label1.Width=(this.label1.Width+this.label1.Left);
				this.label1.Left=0;
				button2.Enabled=false;
			}
			

			this.label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int h;
			try //compruebo que se ingrese un paso valido
			{
				h=int.Parse(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("Paso incorrecto. Se usara paso=10");
				textBox1.Text="10";
				h=10;
			}
			if ((label1.Bottom+h)<=(panel2.Height)) //si no se va del limite agrando el label segun el paso
			{
				label1.Height=(label1.Height+h); 
			}
			else //sino lo agrando hasta el borde y deshabilito el boton
			{
				label1.Height=(label1.Height+(panel2.Height-label1.Bottom));
				button3.Enabled=false;
			}
			
			this.label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int h;
			try //compruebo que se ingrese un paso valido
			{
				h=int.Parse(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("Paso incorrecto. Se usara paso=10");
				textBox1.Text="10";
				h=10;
			}
			if ((label1.Top-h)>=0) //si no se va del limite agrando el label segun el paso
			{
				this.label1.Height=(this.label1.Height+h);
				this.label1.Top-=h;
			}
			else //sino lo agrando hasta el borde y deshabilito el boton
			{
				button4.Enabled=false;
				this.label1.Height=(this.label1.Height+label1.Top);
				this.label1.Top=0;
			}
			
			
			this.label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
		}
		
		
		
		void Label1Click(object sender, EventArgs e)
		{
			//reestablezco el label a su tamaño original
			label1.Height=50;
			label1.Width=150;
			//muevo el label en el centro segun el tamaño actual del form
			label1.Location=new Point((panel2.Width/2)-75,(panel2.Height/2)-25);
			
			label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
			//Vuelvo a habilitar los botones por si alguno estaba deshabilitado
			button1.Enabled=true;
			button2.Enabled=true;
			button3.Enabled=true;
			button4.Enabled=true;
		}

		

		void MainFormSizeChanged(object sender, EventArgs e)
		{	
			//al cambiar el tamaño del formulario se debe revisar si los botones
			//direccionales deben estar activados o no 
			
			if(label1.Right>panel2.Width)
			{
				button1.Enabled=false;
			}
			else
				button1.Enabled=true;
			
	
			
			
			if(label1.Bottom>panel2.Height)
			{
				button3.Enabled=false;
			}
			else
				button3.Enabled=true;
		
		
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
			textBox1.Text="10";
		}
		
		
		
		//CAMBIO DEL ICONO DE LOS BOTONES SEGUN ESTEN HABILITADOS/DESHABILITADOS
		
		void Button1EnabledChanged(object sender, EventArgs e)
		{
			if(button1.Enabled==false)
				this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("derechabloqueado")));
			else
				this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			
		}
		
		void Button2EnabledChanged(object sender, EventArgs e)
		{
			
			if(button2.Enabled==false)
				this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("izquierdabloqueado")));
			else
				this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
				
		}
		
		void Button3EnabledChanged(object sender, EventArgs e)
		{
			if(button3.Enabled==false)
				this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("abajobloqueado")));
			else
				this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
		}
		
		void Button4EnabledChanged(object sender, EventArgs e)
		{	
			if(button4.Enabled==false)
				this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arribabloqueado")));
			else
				this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			
		}
		
	
		
		void Panel2Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
	}
}