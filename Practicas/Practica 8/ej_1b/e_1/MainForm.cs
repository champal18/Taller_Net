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
				MessageBox.Show("Paso no valido, se usara 10");
				w=10;
			}

			if ((label1.Left+w)<=(MainForm.ActiveForm.Width-label1.Width))
			{
				this.label1.Width=(this.label1.Width+w);
			}
			else
			{
				this.label1.Width=(this.label1.Width+w);
				button1.Enabled=false;
				
			}
			
			
			
			label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			label1.Height=63;
			label1.Width=217;
			label1.Location=new Point(37,43);
			label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
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
				MessageBox.Show("Paso no valido, se usara 10");
				w=10;
			}
			/*if(label1.Left==0)
			{
				this.label1.Width=MainForm.ActiveForm.Size.Width;
				button1.Enabled=false;
			}*/
			
			if ((label1.Left-w)>=0)
			{
				//label1.Left=label1.Left-h;
				this.label1.Width=(this.label1.Width+w);
				this.label1.Left-=w;
			}
			else
			{
				
				this.label1.Width=(this.label1.Width+w);
				this.label1.Left-=w;
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
				MessageBox.Show("Paso no valido, se usara 10");
				h=10;
			}
			if ((label1.Top+h)<=(MainForm.ActiveForm.Height-label1.Height-panel1.Height-30))
			{
				label1.Height=(label1.Height+h);
				//label3.Text=label1.Top.ToString();
			}
			else
			{
				
				label1.Height=(label1.Height+h);
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
				MessageBox.Show("Paso no valido, se usara 10");
				h=10;
			}
			if ((label1.Top-h)>=0)
			{
				this.label1.Height=(this.label1.Height+h);
				this.label1.Top-=h;
				//label1.Top=label1.Top-h;
			}
			else
			{
				button4.Enabled=false;
				this.label1.Height=(this.label1.Height+h);
				this.label1.Top-=h;
			}
			//this.label1.Height=(this.label1.Height+h);
			
			this.label1.Text="Label de "+label1.Height+" pixeles de alto y "+label1.Width+" pixeles de ancho";
		}
	}
}