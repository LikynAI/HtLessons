namespace XmlApp
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
			this.infoBox = new System.Windows.Forms.TextBox();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.sNameBox = new System.Windows.Forms.TextBox();
			this.AgeBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.Obn = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.Load = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// infoBox
			// 
			this.infoBox.Location = new System.Drawing.Point(458, 74);
			this.infoBox.Multiline = true;
			this.infoBox.Name = "infoBox";
			this.infoBox.Size = new System.Drawing.Size(169, 223);
			this.infoBox.TabIndex = 0;
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(290, 95);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(100, 20);
			this.NameBox.TabIndex = 1;
			// 
			// sNameBox
			// 
			this.sNameBox.Location = new System.Drawing.Point(290, 142);
			this.sNameBox.Name = "sNameBox";
			this.sNameBox.Size = new System.Drawing.Size(100, 20);
			this.sNameBox.TabIndex = 2;
			// 
			// AgeBox
			// 
			this.AgeBox.Location = new System.Drawing.Point(290, 186);
			this.AgeBox.Name = "AgeBox";
			this.AgeBox.Size = new System.Drawing.Size(100, 20);
			this.AgeBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(178, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "second name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(178, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "age";
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(181, 303);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonCreate.TabIndex = 7;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click_1);
			// 
			// Obn
			// 
			this.Obn.Location = new System.Drawing.Point(290, 303);
			this.Obn.Name = "Obn";
			this.Obn.Size = new System.Drawing.Size(75, 23);
			this.Obn.TabIndex = 8;
			this.Obn.Text = "Obn";
			this.Obn.UseVisualStyleBackColor = true;
			this.Obn.Click += new System.EventHandler(this.Obn_Click);
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(458, 303);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 9;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Load
			// 
			this.Load.Location = new System.Drawing.Point(552, 303);
			this.Load.Name = "Load";
			this.Load.Size = new System.Drawing.Size(75, 23);
			this.Load.TabIndex = 10;
			this.Load.Text = "Load";
			this.Load.UseVisualStyleBackColor = true;
			this.Load.Click += new System.EventHandler(this.Load_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Load);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Obn);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AgeBox);
			this.Controls.Add(this.sNameBox);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.infoBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox infoBox;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.TextBox sNameBox;
		private System.Windows.Forms.TextBox AgeBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Button Obn;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Load;
	}
}

