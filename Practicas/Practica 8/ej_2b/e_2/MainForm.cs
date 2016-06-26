/*
 * Created by SharpDevelop.
 * User: Meisser
 * Date: 18/05/2015
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
			
			DialogResult result = colorDialog1.ShowDialog();
			// See if user pressed ok.
			if (result == DialogResult.OK)
			{
				// Set form background to the selected color.
				label1.BackColor=colorDialog1.Color;
			}
			
			
		}
		void Panel1Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}

		
		void Timer1Tick(object sender, EventArgs e)
		{
			DateTime date1= DateTime.Parse(label_invisible.Text);
			string st=System.DateTime.Now.ToString("HH:mm:ss");  //Pongo la hora de inicio en el label invisible, y despues la resto
			DateTime date2=DateTime.Parse(st);
			System.TimeSpan diff1 = date2.Subtract(date1);
			label2.Text=diff1.ToString();
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{

			
			label_invisible.Text=System.DateTime.Now.ToString("HH:mm:ss");
			int t=int.Parse(numericUpDown1.Text);
			label1.Font = new Font(label1.Font.FontFamily, t);
			label3.Text="Left="+label1.Left+" Top="+label1.Top+" Width="+label1.Width+" Height="+label1.Height;
			
			for(int i=1;i<=100;i++) // cargo el combo box
				comboBox1.Items.Add(i);
			comboBox1.SelectedIndex = 9;
		}
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			int t=int.Parse(numericUpDown1.Text);
			label1.Font = new Font(label1.Font.FontFamily, t); //cambio la fuente al numero t correspondiente
			label3.Text="Left="+label1.Left+" Top="+label1.Top+" Width="+label1.Width+" Height="+label1.Height;
		}
		
		void Button_upClick(object sender, EventArgs e)
		{
			int h;
			h=int.Parse(comboBox1.SelectedItem.ToString());

			label1.Text="Arriba";
			if(checkBox1.Checked==true)
			{
				if ((label1.Top-h)>=0)
				{
					label1.Top=label1.Top-h;
				}
				else
				{
					label1.Top=0;
				}
			}
			else
			{
				label1.Top=label1.Top-h;
			}
			
			label3.Text="Left="+label1.Left+" Top="+label1.Top+" Width="+label1.Width+" Height="+label1.Height;
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int h;
			h=int.Parse(comboBox1.SelectedItem.ToString());
			label1.Text="Izquierda";
			if(checkBox1.Checked==true)
			{
				if ((label1.Left-h)>=0)
				{
					label1.Left=label1.Left-h;
				}
				else
				{
					label1.Left=0;
				}
			}
			else
			{
				label1.Left=label1.Left-h;
			}
			
			label3.Text="Left="+label1.Left+" Top="+label1.Top+" Width="+label1.Width+" Height="+label1.Height;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int h;
			h=int.Parse(comboBox1.SelectedItem.ToString());
			label1.Text="Abajo";
			if(checkBox1.Checked==true)
			{
				if ((label1.Top+h)<=(panel1.Height-label1.Height))
				{
					label1.Top=label1.Top+h;
				}
				else
				{
					label1.Top=panel1.Height-label1.Height;
					
				}
			}
			else
			{
				label1.Top=label1.Top+h;
			}
			
			label3.Text="Left="+label1.Left+" Top="+label1.Top+" Width="+label1.Width+" Height="+label1.Height;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int h;
			h=int.Parse(comboBox1.SelectedItem.ToString());
			label1.Text="Derecha";
			if(checkBox1.Checked==true)
			{
				if ((label1.Left+h)<=(panel1.Width-label1.Width))
				{
					label1.Left=label1.Left+h;
				}
				else
				{
					label1.Left=panel1.Width-label1.Width;
					
				}
			}
			else
			{
				
				label1.Left=label1.Left+h;
				
			}
			
			label3.Text="Left="+label1.Left+" Top="+label1.Top+" Width="+label1.Width+" Height="+label1.Height;
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
