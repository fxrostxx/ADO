namespace Academy
{
	partial class HumanForm
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
			this.labelLastname = new System.Windows.Forms.Label();
			this.labelFirstname = new System.Windows.Forms.Label();
			this.labelMiddlename = new System.Windows.Forms.Label();
			this.labelBirthdate = new System.Windows.Forms.Label();
			this.tbLastname = new System.Windows.Forms.TextBox();
			this.tbFirstname = new System.Windows.Forms.TextBox();
			this.tbMiddlename = new System.Windows.Forms.TextBox();
			this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
			this.pbPhoto = new System.Windows.Forms.PictureBox();
			this.button = new System.Windows.Forms.Button();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.labelID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLastname
			// 
			this.labelLastname.AutoSize = true;
			this.labelLastname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLastname.Location = new System.Drawing.Point(77, 10);
			this.labelLastname.Name = "labelLastname";
			this.labelLastname.Size = new System.Drawing.Size(114, 26);
			this.labelLastname.TabIndex = 0;
			this.labelLastname.Text = "Фамилия:";
			// 
			// labelFirstname
			// 
			this.labelFirstname.AutoSize = true;
			this.labelFirstname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFirstname.Location = new System.Drawing.Point(128, 54);
			this.labelFirstname.Name = "labelFirstname";
			this.labelFirstname.Size = new System.Drawing.Size(63, 26);
			this.labelFirstname.TabIndex = 1;
			this.labelFirstname.Text = "Имя:";
			// 
			// labelMiddlename
			// 
			this.labelMiddlename.AutoSize = true;
			this.labelMiddlename.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMiddlename.Location = new System.Drawing.Point(71, 98);
			this.labelMiddlename.Name = "labelMiddlename";
			this.labelMiddlename.Size = new System.Drawing.Size(120, 26);
			this.labelMiddlename.TabIndex = 2;
			this.labelMiddlename.Text = "Отчество:";
			// 
			// labelBirthdate
			// 
			this.labelBirthdate.AutoSize = true;
			this.labelBirthdate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBirthdate.Location = new System.Drawing.Point(12, 142);
			this.labelBirthdate.Name = "labelBirthdate";
			this.labelBirthdate.Size = new System.Drawing.Size(179, 26);
			this.labelBirthdate.TabIndex = 3;
			this.labelBirthdate.Text = "Дата рождения:";
			// 
			// tbLastname
			// 
			this.tbLastname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbLastname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbLastname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLastname.Location = new System.Drawing.Point(207, 6);
			this.tbLastname.Name = "tbLastname";
			this.tbLastname.Size = new System.Drawing.Size(311, 34);
			this.tbLastname.TabIndex = 4;
			// 
			// tbFirstname
			// 
			this.tbFirstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbFirstname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbFirstname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbFirstname.Location = new System.Drawing.Point(207, 50);
			this.tbFirstname.Name = "tbFirstname";
			this.tbFirstname.Size = new System.Drawing.Size(311, 34);
			this.tbFirstname.TabIndex = 5;
			// 
			// tbMiddlename
			// 
			this.tbMiddlename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbMiddlename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbMiddlename.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbMiddlename.Location = new System.Drawing.Point(207, 94);
			this.tbMiddlename.Name = "tbMiddlename";
			this.tbMiddlename.Size = new System.Drawing.Size(311, 34);
			this.tbMiddlename.TabIndex = 6;
			// 
			// dtpBirthdate
			// 
			this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpBirthdate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthdate.Location = new System.Drawing.Point(207, 138);
			this.dtpBirthdate.Name = "dtpBirthdate";
			this.dtpBirthdate.Size = new System.Drawing.Size(311, 34);
			this.dtpBirthdate.TabIndex = 7;
			// 
			// pbPhoto
			// 
			this.pbPhoto.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbPhoto.Location = new System.Drawing.Point(524, 6);
			this.pbPhoto.Name = "pbPhoto";
			this.pbPhoto.Size = new System.Drawing.Size(222, 254);
			this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPhoto.TabIndex = 8;
			this.pbPhoto.TabStop = false;
			// 
			// button
			// 
			this.button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button.Location = new System.Drawing.Point(524, 275);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(222, 34);
			this.button.TabIndex = 9;
			this.button.Text = "Обзор";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// tbEmail
			// 
			this.tbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbEmail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbEmail.Location = new System.Drawing.Point(207, 182);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(311, 34);
			this.tbEmail.TabIndex = 11;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelEmail.Location = new System.Drawing.Point(118, 186);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(73, 26);
			this.labelEmail.TabIndex = 10;
			this.labelEmail.Text = "Email:";
			// 
			// tbPhone
			// 
			this.tbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbPhone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPhone.Location = new System.Drawing.Point(207, 226);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(311, 34);
			this.tbPhone.TabIndex = 13;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPhone.Location = new System.Drawing.Point(78, 230);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(113, 26);
			this.labelPhone.TabIndex = 12;
			this.labelPhone.Text = "Телефон:";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOk.Location = new System.Drawing.Point(524, 315);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(109, 34);
			this.buttonOk.TabIndex = 14;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(637, 315);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 34);
			this.button1.TabIndex = 15;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelID.Location = new System.Drawing.Point(12, 323);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(0, 26);
			this.labelID.TabIndex = 16;
			// 
			// HumanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 358);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.button);
			this.Controls.Add(this.pbPhoto);
			this.Controls.Add(this.dtpBirthdate);
			this.Controls.Add(this.tbMiddlename);
			this.Controls.Add(this.tbFirstname);
			this.Controls.Add(this.tbLastname);
			this.Controls.Add(this.labelBirthdate);
			this.Controls.Add(this.labelMiddlename);
			this.Controls.Add(this.labelFirstname);
			this.Controls.Add(this.labelLastname);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HumanForm";
			this.ShowInTaskbar = false;
			this.Text = "HumanForm";
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLastname;
		private System.Windows.Forms.Label labelFirstname;
		private System.Windows.Forms.Label labelMiddlename;
		private System.Windows.Forms.Label labelBirthdate;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button button1;
		protected System.Windows.Forms.TextBox tbLastname;
		protected System.Windows.Forms.TextBox tbFirstname;
		protected System.Windows.Forms.TextBox tbMiddlename;
		protected System.Windows.Forms.DateTimePicker dtpBirthdate;
		protected System.Windows.Forms.PictureBox pbPhoto;
		protected System.Windows.Forms.TextBox tbEmail;
		protected System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label labelID;
	}
}