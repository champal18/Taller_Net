/*
 * Created by SharpDevelop.
 * User: Meisser
 * Date: 25/05/2015
 * Time: 19:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace e_2
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
			for(int i=0; i<this.Controls.Count;i++)
			{
				if(this.Controls[i] is Panel) this.Controls[i].Dispose();
			}
			NumeroDigital numdig=new NumeroDigital((sender as Button).Text, colorDialog1.Color,colorDialog2.Color);
			this.Controls.Add(numdig);
			
		}

		
		void MainFormLoad(object sender, EventArgs e)
		{

			//NumeroDigital numdig= new NumeroDigital();
			NumeroDigital numdig=new NumeroDigital();
			this.Controls.Add(numdig);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			DialogResult result = colorDialog1.ShowDialog();
			// See if user pressed ok.
			if (result == DialogResult.OK)
			{
				// Set form background to the selected color.
				for(int i=0; i<this.Controls.Count;i++)
				{
					if(this.Controls[i] is Panel) this.Controls[i].Dispose();
				}
				NumeroDigital numdig=new NumeroDigital(button1.Text, colorDialog1.Color,colorDialog2.Color);
				this.Controls.Add(numdig);
				
			}

			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			DialogResult result = colorDialog2.ShowDialog();
			// See if user pressed ok.
			if (result == DialogResult.OK)
			{
				// Set form background to the selected color.
				for(int i=0; i<this.Controls.Count;i++)
				{
					if(this.Controls[i] is Panel) this.Controls[i].Dispose();
				}
				NumeroDigital numdig=new NumeroDigital(button1.Text, colorDialog1.Color,colorDialog2.Color);
				this.Controls.Add(numdig);
				
			}
		}
	}
	public partial class NumeroDigital: Panel
	{
		Button button2= new Button();
		
		Panel panel1= new Panel();
		Panel panel2= new Panel();
		Panel panel3= new Panel();
		Panel panel4= new Panel();
		Panel panel5= new Panel();
		Panel panel6= new Panel();
		Panel panel7= new Panel();
		Panel panel8= new Panel();
		Panel panel9= new Panel();
		Panel panel10= new Panel();
		Panel panel11= new Panel();
		Panel panel12= new Panel();
		Panel panel13= new Panel();
		Panel panel14= new Panel();
		Panel panel15= new Panel();
		public NumeroDigital()
		{
			this.Width=90;
			this.Height=150;
			this.BackColor=Color.Black;
			
			
			panel1.Width=30;panel1.Height=30; panel1.BackColor=Color.Black;
			panel2.Width=30;panel2.Height=30; panel2.BackColor=Color.Black; panel2.Left=30;
			panel3.Width=30;panel3.Height=30; panel3.BackColor=Color.Black; panel3.Left=60;
			panel4.Width=30;panel4.Height=30; panel4.BackColor=Color.Black; panel4.Top=30;
			panel5.Width=30;panel5.Height=30; panel5.BackColor=Color.Black; panel5.Left=30; panel5.Top=30;
			panel6.Width=30;panel6.Height=30; panel6.BackColor=Color.Black; panel6.Left=60; panel6.Top=30;
			panel7.Width=30;panel7.Height=30; panel7.BackColor=Color.Black; panel7.Top=60;
			panel8.Width=30;panel8.Height=30; panel8.BackColor=Color.Black; panel8.Left=30; panel8.Top=60;
			panel9.Width=30;panel9.Height=30; panel9.BackColor=Color.Black; panel9.Left=60; panel9.Top=60;
			panel10.Width=30;panel10.Height=30; panel10.BackColor=Color.Black; panel10.Top=90;
			panel11.Width=30;panel11.Height=30; panel11.BackColor=Color.Black; panel11.Left=30; panel11.Top=90;
			panel12.Width=30;panel12.Height=30; panel12.BackColor=Color.Black;  panel12.Left=60; panel12.Top=90;
			panel13.Width=30;panel13.Height=30; panel13.BackColor=Color.Black;  panel13.Top=120;
			panel14.Width=30;panel14.Height=30; panel14.BackColor=Color.Black;  panel14.Left=30; panel14.Top=120;
			panel15.Width=30;panel15.Height=30; panel15.BackColor=Color.Black;  panel15.Left=60; panel15.Top=120;
			this.Controls.Add(panel1);
			this.Controls.Add(panel2);
			this.Controls.Add(panel3);
			this.Controls.Add(panel4);
			this.Controls.Add(panel5);
			this.Controls.Add(panel6);
			this.Controls.Add(panel7);
			this.Controls.Add(panel8);
			this.Controls.Add(panel9);
			this.Controls.Add(panel10);
			this.Controls.Add(panel11);
			this.Controls.Add(panel12);
			this.Controls.Add(panel13);
			this.Controls.Add(panel14);
			this.Controls.Add(panel15);

			
		}
		public NumeroDigital(string num, Color color, Color letra)
		{
			this.Width=90;
			this.Height=150;
			this.BackColor=Color.Black;
			switch(num)
			{
				case"0":
					{
						panel1.Width=30;panel1.Height=30; panel1.BackColor=(Color)letra;
						panel2.Width=30;panel2.Height=30; panel2.BackColor=(Color)letra; panel2.Left=30;
						panel3.Width=30;panel3.Height=30; panel3.BackColor=(Color)letra; panel3.Left=60;
						panel4.Width=30;panel4.Height=30; panel4.BackColor=(Color)letra; panel4.Top=30;
						panel5.Width=30;panel5.Height=30; panel5.BackColor=(Color)color; panel5.Left=30; panel5.Top=30;
						panel6.Width=30;panel6.Height=30; panel6.BackColor=(Color)letra; panel6.Left=60; panel6.Top=30;
						panel7.Width=30;panel7.Height=30; panel7.BackColor=(Color)letra; panel7.Top=60;
						panel8.Width=30;panel8.Height=30; panel8.BackColor=(Color)color; panel8.Left=30; panel8.Top=60;
						panel9.Width=30;panel9.Height=30; panel9.BackColor=(Color)letra; panel9.Left=60; panel9.Top=60;
						panel10.Width=30;panel10.Height=30; panel10.BackColor=(Color)letra; panel10.Top=90;
						panel11.Width=30;panel11.Height=30; panel11.BackColor=(Color)color; panel11.Left=30; panel11.Top=90;
						panel12.Width=30;panel12.Height=30; panel12.BackColor=(Color)letra;  panel12.Left=60; panel12.Top=90;
						panel13.Width=30;panel13.Height=30; panel13.BackColor=(Color)letra;  panel13.Top=120;
						panel14.Width=30;panel14.Height=30; panel14.BackColor=(Color)letra; panel14.Left=30; panel14.Top=120;
						panel15.Width=30;panel15.Height=30; panel15.BackColor=(Color)letra;  panel15.Left=60; panel15.Top=120;
						this.Controls.Add(panel1);
						this.Controls.Add(panel2);
						this.Controls.Add(panel3);
						this.Controls.Add(panel4);
						this.Controls.Add(panel5);
						this.Controls.Add(panel6);
						this.Controls.Add(panel7);
						this.Controls.Add(panel8);
						this.Controls.Add(panel9);
						this.Controls.Add(panel10);
						this.Controls.Add(panel11);
						this.Controls.Add(panel12);
						this.Controls.Add(panel13);
						this.Controls.Add(panel14);
						this.Controls.Add(panel15);
					}break;
				case"1":
					{
						
						
						panel1.Width=30;panel1.Height=30; panel1.BackColor=(Color)color;
						panel2.Width=30;panel2.Height=30; panel2.BackColor=(Color)color; panel2.Left=30;
						panel3.Width=30;panel3.Height=30; panel3.BackColor=(Color)letra; panel3.Left=60;
						panel4.Width=30;panel4.Height=30; panel4.BackColor=(Color)color; panel4.Top=30;
						panel5.Width=30;panel5.Height=30; panel5.BackColor=(Color)color; panel5.Left=30; panel5.Top=30;
						panel6.Width=30;panel6.Height=30; panel6.BackColor=(Color)letra; panel6.Left=60; panel6.Top=30;
						panel7.Width=30;panel7.Height=30; panel7.BackColor=(Color)color; panel7.Top=60;
						panel8.Width=30;panel8.Height=30; panel8.BackColor=(Color)color; panel8.Left=30; panel8.Top=60;
						panel9.Width=30;panel9.Height=30; panel9.BackColor=(Color)letra; panel9.Left=60; panel9.Top=60;
						panel10.Width=30;panel10.Height=30; panel10.BackColor=(Color)color; panel10.Top=90;
						panel11.Width=30;panel11.Height=30; panel11.BackColor=(Color)color; panel11.Left=30; panel11.Top=90;
						panel12.Width=30;panel12.Height=30; panel12.BackColor=(Color)letra;  panel12.Left=60; panel12.Top=90;
						panel13.Width=30;panel13.Height=30; panel13.BackColor=(Color)color;  panel13.Top=120;
						panel14.Width=30;panel14.Height=30; panel14.BackColor=(Color)color;  panel14.Left=30; panel14.Top=120;
						panel15.Width=30;panel15.Height=30; panel15.BackColor=(Color)letra;  panel15.Left=60; panel15.Top=120;
						this.Controls.Add(panel1);
						this.Controls.Add(panel2);
						this.Controls.Add(panel3);
						this.Controls.Add(panel4);
						this.Controls.Add(panel5);
						this.Controls.Add(panel6);
						this.Controls.Add(panel7);
						this.Controls.Add(panel8);
						this.Controls.Add(panel9);
						this.Controls.Add(panel10);
						this.Controls.Add(panel11);
						this.Controls.Add(panel12);
						this.Controls.Add(panel13);
						this.Controls.Add(panel14);
						this.Controls.Add(panel15);
					}break;
				case"2":
					{
						
						panel1.Width=30;panel1.Height=30; panel1.BackColor=(Color)letra;
						panel2.Width=30;panel2.Height=30; panel2.BackColor=(Color)letra; panel2.Left=30;
						panel3.Width=30;panel3.Height=30; panel3.BackColor=(Color)letra; panel3.Left=60;
						panel4.Width=30;panel4.Height=30; panel4.BackColor=(Color)color; panel4.Top=30;
						panel5.Width=30;panel5.Height=30; panel5.BackColor=(Color)color; panel5.Left=30; panel5.Top=30;
						panel6.Width=30;panel6.Height=30; panel6.BackColor=(Color)letra; panel6.Left=60; panel6.Top=30;
						panel7.Width=30;panel7.Height=30; panel7.BackColor=(Color)letra; panel7.Top=60;
						panel8.Width=30;panel8.Height=30; panel8.BackColor=(Color)letra; panel8.Left=30; panel8.Top=60;
						panel9.Width=30;panel9.Height=30; panel9.BackColor=(Color)letra; panel9.Left=60; panel9.Top=60;
						panel10.Width=30;panel10.Height=30; panel10.BackColor=(Color)letra; panel10.Top=90;
						panel11.Width=30;panel11.Height=30; panel11.BackColor=(Color)color; panel11.Left=30; panel11.Top=90;
						panel12.Width=30;panel12.Height=30; panel12.BackColor=(Color)color;  panel12.Left=60; panel12.Top=90;
						panel13.Width=30;panel13.Height=30; panel13.BackColor=(Color)letra;   panel13.Top=120;
						panel14.Width=30;panel14.Height=30; panel14.BackColor=(Color)letra;  panel14.Left=30; panel14.Top=120;
						panel15.Width=30;panel15.Height=30; panel15.BackColor=(Color)letra;  panel15.Left=60; panel15.Top=120;
						this.Controls.Add(panel1);
						this.Controls.Add(panel2);
						this.Controls.Add(panel3);
						this.Controls.Add(panel4);
						this.Controls.Add(panel5);
						this.Controls.Add(panel6);
						this.Controls.Add(panel7);
						this.Controls.Add(panel8);
						this.Controls.Add(panel9);
						this.Controls.Add(panel10);
						this.Controls.Add(panel11);
						this.Controls.Add(panel12);
						this.Controls.Add(panel13);
						this.Controls.Add(panel14);
						this.Controls.Add(panel15);
					}break;
				default:
					{

					}break;
					


					
			}
		}
	}
}
