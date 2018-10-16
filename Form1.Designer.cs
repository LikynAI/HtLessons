namespace VeruNeVeru2
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
			this.True = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Start = new System.Windows.Forms.Button();
			this.False = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// True
			// 
			this.True.Location = new System.Drawing.Point(173, 251);
			this.True.Name = "True";
			this.True.Size = new System.Drawing.Size(75, 23);
			this.True.TabIndex = 0;
			this.True.Text = "True";
			this.True.UseVisualStyleBackColor = true;
			this.True.Click += new System.EventHandler(this.True_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(170, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// Start
			// 
			this.Start.Location = new System.Drawing.Point(173, 183);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(75, 23);
			this.Start.TabIndex = 3;
			this.Start.Text = "Start";
			this.Start.UseVisualStyleBackColor = true;
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// False
			// 
			this.False.Location = new System.Drawing.Point(303, 251);
			this.False.Name = "False";
			this.False.Size = new System.Drawing.Size(75, 23);
			this.False.TabIndex = 4;
			this.False.Text = "False";
			this.False.UseVisualStyleBackColor = true;
			this.False.Click += new System.EventHandler(this.False_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.False);
			this.Controls.Add(this.Start);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.True);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button True;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.Button False;
	}
}

