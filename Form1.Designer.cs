namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.Dob = new System.Windows.Forms.Button();
			this.WınNumber = new System.Windows.Forms.TextBox();
			this.minus = new System.Windows.Forms.Button();
			this.Undo = new System.Windows.Forms.Button();
			this.Scorebox = new System.Windows.Forms.TextBox();
			this.NowNumber = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Dob
			// 
			this.Dob.Location = new System.Drawing.Point(196, 229);
			this.Dob.Name = "Dob";
			this.Dob.Size = new System.Drawing.Size(75, 23);
			this.Dob.TabIndex = 2;
			this.Dob.Text = "Удвоить";
			this.Dob.UseVisualStyleBackColor = true;
			this.Dob.Click += new System.EventHandler(this.button1_Click);
			// 
			// WınNumber
			// 
			this.WınNumber.Location = new System.Drawing.Point(368, 48);
			this.WınNumber.Name = "WınNumber";
			this.WınNumber.Size = new System.Drawing.Size(100, 20);
			this.WınNumber.TabIndex = 3;
			this.WınNumber.TextChanged += new System.EventHandler(this.WınNumber_TextChanged);
			// 
			// minus
			// 
			this.minus.Location = new System.Drawing.Point(368, 229);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(75, 23);
			this.minus.TabIndex = 4;
			this.minus.Text = "-1";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.button2_Click);
			// 
			// Undo
			// 
			this.Undo.Location = new System.Drawing.Point(535, 229);
			this.Undo.Name = "Undo";
			this.Undo.Size = new System.Drawing.Size(75, 23);
			this.Undo.TabIndex = 5;
			this.Undo.Text = "Отмнить";
			this.Undo.UseVisualStyleBackColor = true;
			this.Undo.Click += new System.EventHandler(this.button3_Click);
			// 
			// Scorebox
			// 
			this.Scorebox.Location = new System.Drawing.Point(535, 48);
			this.Scorebox.Name = "Scorebox";
			this.Scorebox.Size = new System.Drawing.Size(100, 20);
			this.Scorebox.TabIndex = 6;
			// 
			// NowNumber
			// 
			this.NowNumber.Location = new System.Drawing.Point(196, 48);
			this.NowNumber.Name = "NowNumber";
			this.NowNumber.Size = new System.Drawing.Size(100, 20);
			this.NowNumber.TabIndex = 7;
			this.NowNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(196, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "Твое число";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(368, 22);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "Цель";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(535, 22);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "Число ходов";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.NowNumber);
			this.Controls.Add(this.Scorebox);
			this.Controls.Add(this.Undo);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.WınNumber);
			this.Controls.Add(this.Dob);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Dob;
		private System.Windows.Forms.TextBox WınNumber;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button Undo;
		private System.Windows.Forms.TextBox Scorebox;
		private System.Windows.Forms.TextBox NowNumber;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}

