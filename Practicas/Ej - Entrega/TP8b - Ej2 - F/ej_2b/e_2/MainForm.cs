/*
 * Created by SharpDevelop.
 * User: Fuentes-Labrune
 * Date: 25/05/2016
 * Time: 15:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_2b
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		//MAINFORM
		
		void MainFormLoad(object sender, EventArgs e)
		{

			
			label_invisible.Text=System.DateTime.Now.ToString("HH:mm:ss");
			int t=int.Parse(numericUpDown1.Text);
			label1.Font = new Font(label1.Font.FontFamily, t);
			label3.Text="Left="+label1.Left+",Top="+label1.Top;
			label5.Text="Width="+label1.Width+",Height="+label1.Height;
			
			for(int i=1;i<=100;i++) // cargo el combo box
				comboBox1.Items.Add(i);
			
			comboBox1.SelectedIndex = 9; //Inicio con un paso=10
		}
		
		
		
		
		//CAMBIO DE COLOR DEL LABEL CON EL CLICK
		
		void Label1Click(object sender, EventArgs e)
		{
			
			
			DialogResult result = colorDialog1.ShowDialog();
			// si el usuario presiono OK
			if (result == DialogResult.OK)
			{
				// Cambio el color de fondo por el seleccionado
				label1.BackColor=colorDialog1.Color;
			}
			
			
		}
		
		//BOTONES DIRECCIONALES
		
		void Button_upClick(object sender, EventArgs e)
		{
			int h;
			h=int.Parse(comboBox1.SelectedItem.ToString());

			label1.Text="Arriba";
			if(checkBox1.Checked==true)//si el panel esta limitado
			{
				if ((label1.Top-h)>=0) //si no se va de los limites lo desplazo segun el paso
				{
					label1.Top=label1.Top-h;
				}
				else //si se va del limite superior lo acomodo en el borde
				{
					label1.Top=0;
				}
			}
			else //si el panel no esta limitado lo desplazo normalmente
			{
				label1.Top=label1.Top-h;
			}
			
			//actualizo los labels
			label3.Text="Left="+label1.Left+",Top="+label1.Top;
			label5.Text="Width="+label1.Width+",Height="+label1.Height;
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int h;
			h=int.Parse(comboBox1.SelectedItem.ToString());
			label1.Text="Izquierda";
			if(checkBox1.Checked==true) //si el panel esta limitado
			{
				if ((label1.Left-h)>=0) //si no se va de los limites lo desplazo segun el paso
				{
					label1.Left=label1.Left-h;
				}
				else
				{
					label1.Left=0;//si se va del limite izquierdo lo acomodo en el borde
				}
			}
			else  //si el panel no esta limitado lo desplazo normalmente
			{
				label1.Left=label1.Left-h;
			}
			
			//actualizo los labels
			label3.Text="Left="+label1.Left+",Top="+label1.Top;
			label5.Text="Width="+label1.Width+",Height="+label1.Height;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int h;
			h=int.Parse(comboBox1.SelectedItem.ToString());
			label1.Text="Abajo";
			if(checkBox1.Checked==true) //si el panel esta limitado
			{
				if ((label1.Top+h)<=(panel1.Height-label1.Height)) //si no se va de los limites lo desplazo segun el paso
				{
					label1.Top=label1.Top+h;
				}
				else//si se va del limite inferior lo acomodo en el borde
				{
					label1.Top=panel1.Height-label1.Height;
					
				}
			}
			else  //si el panel no esta limitado lo desplazo normalmente
			{
				label1.Top=label1.Top+h;
			}
			
			//actualizo los labels
			
			label3.Text="Left="+label1.Left+",Top="+label1.Top;
			label5.Text="Width="+label1.Width+",Height="+label1.Height;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int h;
			h=int.Parse(comboBox1.SelectedItem.ToString());
			label1.Text="Derecha";
			if(checkBox1.Checked==true) //si el panel esta limitado
			{
				if ((label1.Left+h)<=(panel1.Width-label1.Width)) //si no se va de los limites lo desplazo segun el paso
				{
					label1.Left=label1.Left+h;
				}
				else //si se va del limite derecho lo acomodo en el borde
				{
					label1.Left=panel1.Width-label1.Width;
					
				}
			}
			else  //si el panel no esta limitado lo desplazo normalmente
			{
				
				label1.Left=label1.Left+h;
				
			}
			
			//actualizo los labels
			label3.Text="Left="+label1.Left+",Top="+label1.Top;
			label5.Text="Width="+label1.Width+",Height="+label1.Height;
		}
		
		//SELECCION DE TAMAÑO DE FUENTE
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			int t=int.Parse(numericUpDown1.Text);
			label1.Font = new Font(label1.Font.FontFamily, t); //cambio la fuente al numero t correspondiente
			
			//si el label esta cerca de un borde, con limitar panel activado, y se agranda la letra
			//se debe reacomodar para respetar los limites
			
			if(checkBox1.Checked==true)
				if(label1.Bottom>panel1.Height) //si el label paso el borde inferior
					label1.Top=label1.Top-(label1.Bottom-panel1.Height);
				if(label1.Right>panel1.Width)  //si el label paso el borde derecho
					label1.Left=label1.Left-(label1.Right-panel1.Width);
			
			label3.Text="Left="+label1.Left+",Top="+label1.Top;
			label5.Text="Width="+label1.Width+",Height="+label1.Height;
		}
		
		//LIMITAR EL PANEL
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			//Cuando se limita el panel, si el label esta fuera de los limites hay que moverlo
			if(checkBox1.Checked==true)
			{
				if(label1.Top<0) //label fuera del borde superior
					label1.Top=0;
				if(label1.Left<0)//label fuera del borde izquierdo
					label1.Left=0;
				if(label1.Bottom>panel1.Height) //label fuera del borde inferior
					label1.Top=panel1.Height-label1.Height;
				if(label1.Right>panel1.Width)//label fuera del borde derecho
					label1.Left=panel1.Width-label1.Width;
			}
		}
		
		
		//TIMER
		
		void Timer1Tick(object sender, EventArgs e)
		{
			DateTime date1= DateTime.Parse(label_invisible.Text);
			string st=System.DateTime.Now.ToString("HH:mm:ss");  //Pongo la hora de inicio en el label invisible, y despues la resto
			DateTime date2=DateTime.Parse(st);
			System.TimeSpan diff1 = date2.Subtract(date1);
			label2.Text=diff1.ToString();
			
		}
		
	}
}
