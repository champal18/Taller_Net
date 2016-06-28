/*
 * Created by SharpDevelop.
 * User: Meisser
 * Date: 17/05/2015
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
		

		

		
		void Button1Click(object sender, EventArgs e)
		{
			int w;
			try
			{
				w=int.Parse(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("Paso incorrecto. Se usara paso=10");
				textBox1.Text="10";
				w=10;
			}

			if ((label1.Right+w)<=(panel2.Width))
			{
				this.label1.Width=(this.label1.Width+w);
			}
			else
			{
				this.label1.Width+=(panel2.Width-label1.Right);
				button1.Enabled=false;
				
			}
			
			label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			label1.Height=50;
			label1.Width=150;
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
			if ((label1.Left)<=(MainForm.ActiveForm.Width-label1.Width))
			{
				button1.Enabled=true;
			}
			else button1.Enabled=false;
			
			if ((label1.Left)>=0)
			{
				button2.Enabled=true;
			}
			else
			{
				button2.Enabled=false;
			}
			if ((label1.Top)<=(MainForm.ActiveForm.Height-label1.Height-panel1.Height-30))
			{
				button3.Enabled=true;
			}
			else button3.Enabled=false;
			if ((label1.Top)>=0)
			{
				button4.Enabled=true;
			}
			else button4.Enabled=false;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
			textBox1.Text="10";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int w;
			try
			{
				w=int.Parse(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("Paso incorrecto. Se usara paso=10");
				textBox1.Text="10";
				w=10;
			}
			
			if ((label1.Left-w)>=0)
			{
				//label1.Left=label1.Left-h;
				this.label1.Width=(this.label1.Width+w);
				this.label1.Left-=w;
			}
			else
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
			try
			{
				h=int.Parse(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("Paso incorrecto. Se usara paso=10");
				textBox1.Text="10";
				h=10;
			}
			if ((label1.Bottom+h)<=(panel2.Height))
			{
				label1.Height=(label1.Height+h);
			}
			else
			{
				label1.Height=(label1.Height+(panel2.Height-label1.Bottom));
				button3.Enabled=false;
			}
			
			this.label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int h;
			try
			{
				h=int.Parse(textBox1.Text);
			}
			catch
			{
				MessageBox.Show("Paso incorrecto. Se usara paso=10");
				textBox1.Text="10";
				h=10;
			}
			if ((label1.Top-h)>=0)
			{
				this.label1.Height=(this.label1.Height+h);
				this.label1.Top-=h;
			}
			else
			{
				button4.Enabled=false;
				this.label1.Height=(this.label1.Height+label1.Top);
				this.label1.Top=0;
			}
			
			
			this.label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
		}
		
		
		
	}
}