namespace WindowsFormsApp1
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
			this.EntNum = new System.Windows.Forms.TextBox();
			this.bs = new System.Windows.Forms.Label();
			this.Time = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// EntNum
			// 
			this.EntNum.Location = new System.Drawing.Point(343, 169);
			this.EntNum.Multiline = true;
			this.EntNum.Name = "EntNum";
			this.EntNum.Size = new System.Drawing.Size(100, 20);
			this.EntNum.TabIndex = 0;
			this.EntNum.TextChanged += new System.EventHandler(this.EntNum_TextChanged);
			// 
			// bs
			// 
			this.bs.AutoSize = true;
			this.bs.Location = new System.Drawing.Point(340, 153);
			this.bs.Name = "bs";
			this.bs.Size = new System.Drawing.Size(35, 13);
			this.bs.TabIndex = 1;
			this.bs.Text = "label1";
			// 
			// Time
			// 
			this.Time.AutoSize = true;
			this.Time.Location = new System.Drawing.Point(492, 176);
			this.Time.Name = "Time";
			this.Time.Size = new System.Drawing.Size(35, 13);
			this.Time.TabIndex = 2;
			this.Time.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Time);
			this.Controls.Add(this.bs);
			this.Controls.Add(this.EntNum);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EntNum;
		private System.Windows.Forms.Label bs;
		private System.Windows.Forms.Label Time;
	}
}

