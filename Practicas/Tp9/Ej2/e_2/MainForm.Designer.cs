﻿/*
 * Created by SharpDevelop.
 * User: Meisser
 * Date: 25/05/2015
 * Time: 19:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace e_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.colorDialog2 = new System.Windows.Forms.ColorDialog();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(66, 383);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 38);
			this.button1.TabIndex = 0;
			this.button1.Text = "0";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 485);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 59);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cambiar Color Fondo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(128, 383);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 38);
			this.button3.TabIndex = 2;
			this.button3.Text = "1";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button1Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(190, 383);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(56, 38);
			this.button4.TabIndex = 3;
			this.button4.Text = "2";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button1Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 485);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(133, 59);
			this.button5.TabIndex = 4;
			this.button5.Text = "Cambiar Color Letra";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 608);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "e_2";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColorDialog colorDialog2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button button1;
		

		

	}
}
