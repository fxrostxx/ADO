namespace Academy
{
	partial class TeacherForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelWorkSince = new System.Windows.Forms.Label();
			this.dtpWorkSince = new System.Windows.Forms.DateTimePicker();
			this.labelRate = new System.Windows.Forms.Label();
			this.tbRate = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelWorkSince
			// 
			this.labelWorkSince.AutoSize = true;
			this.labelWorkSince.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWorkSince.Location = new System.Drawing.Point(56, 275);
			this.labelWorkSince.Name = "labelWorkSince";
			this.labelWorkSince.Size = new System.Drawing.Size(135, 26);
			this.labelWorkSince.TabIndex = 17;
			this.labelWorkSince.Text = "Работает с:";
			// 
			// dtpWorkSince
			// 
			this.dtpWorkSince.CalendarFont = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpWorkSince.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpWorkSince.Location = new System.Drawing.Point(207, 271);
			this.dtpWorkSince.Name = "dtpWorkSince";
			this.dtpWorkSince.Size = new System.Drawing.Size(311, 34);
			this.dtpWorkSince.TabIndex = 18;
			// 
			// labelRate
			// 
			this.labelRate.AutoSize = true;
			this.labelRate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRate.Location = new System.Drawing.Point(12, 317);
			this.labelRate.Name = "labelRate";
			this.labelRate.Size = new System.Drawing.Size(179, 26);
			this.labelRate.TabIndex = 19;
			this.labelRate.Text = "Ставка за пару:";
			// 
			// tbRate
			// 
			this.tbRate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbRate.Location = new System.Drawing.Point(207, 313);
			this.tbRate.Name = "tbRate";
			this.tbRate.Size = new System.Drawing.Size(311, 34);
			this.tbRate.TabIndex = 20;
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 354);
			this.Controls.Add(this.tbRate);
			this.Controls.Add(this.labelRate);
			this.Controls.Add(this.dtpWorkSince);
			this.Controls.Add(this.labelWorkSince);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.Controls.SetChildIndex(this.tbLastname, 0);
			this.Controls.SetChildIndex(this.tbFirstname, 0);
			this.Controls.SetChildIndex(this.tbMiddlename, 0);
			this.Controls.SetChildIndex(this.dtpBirthdate, 0);
			this.Controls.SetChildIndex(this.pbPhoto, 0);
			this.Controls.SetChildIndex(this.tbEmail, 0);
			this.Controls.SetChildIndex(this.tbPhone, 0);
			this.Controls.SetChildIndex(this.labelWorkSince, 0);
			this.Controls.SetChildIndex(this.dtpWorkSince, 0);
			this.Controls.SetChildIndex(this.labelRate, 0);
			this.Controls.SetChildIndex(this.tbRate, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelWorkSince;
		private System.Windows.Forms.DateTimePicker dtpWorkSince;
		private System.Windows.Forms.Label labelRate;
		private System.Windows.Forms.TextBox tbRate;
	}
}