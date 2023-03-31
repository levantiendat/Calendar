namespace Calendar
{
	partial class DetailForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.date = new System.Windows.Forms.DateTimePicker();
			this.startHour = new System.Windows.Forms.ComboBox();
			this.startMin = new System.Windows.Forms.ComboBox();
			this.endMin = new System.Windows.Forms.ComboBox();
			this.endHour = new System.Windows.Forms.ComboBox();
			this.ok = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên cuộc họp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Địa điểm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giờ bắt đầu";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 250);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Giờ kết thúc";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(174, 31);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(272, 27);
			this.txtName.TabIndex = 5;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(174, 83);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(272, 27);
			this.txtAddress.TabIndex = 6;
			// 
			// date
			// 
			this.date.Location = new System.Drawing.Point(174, 139);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(207, 22);
			this.date.TabIndex = 7;
			// 
			// startHour
			// 
			this.startHour.FormattingEnabled = true;
			this.startHour.Location = new System.Drawing.Point(174, 192);
			this.startHour.Name = "startHour";
			this.startHour.Size = new System.Drawing.Size(55, 24);
			this.startHour.TabIndex = 8;
			// 
			// startMin
			// 
			this.startMin.FormattingEnabled = true;
			this.startMin.Location = new System.Drawing.Point(253, 192);
			this.startMin.Name = "startMin";
			this.startMin.Size = new System.Drawing.Size(55, 24);
			this.startMin.TabIndex = 9;
			// 
			// endMin
			// 
			this.endMin.FormattingEnabled = true;
			this.endMin.Location = new System.Drawing.Point(253, 250);
			this.endMin.Name = "endMin";
			this.endMin.Size = new System.Drawing.Size(55, 24);
			this.endMin.TabIndex = 11;
			// 
			// endHour
			// 
			this.endHour.FormattingEnabled = true;
			this.endHour.Location = new System.Drawing.Point(174, 250);
			this.endHour.Name = "endHour";
			this.endHour.Size = new System.Drawing.Size(55, 24);
			this.endHour.TabIndex = 10;
			// 
			// ok
			// 
			this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ok.Location = new System.Drawing.Point(64, 322);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(101, 53);
			this.ok.TabIndex = 12;
			this.ok.Text = "OK";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// Cancel
			// 
			this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancel.Location = new System.Drawing.Point(253, 322);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(101, 53);
			this.Cancel.TabIndex = 13;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// DetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 387);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.endMin);
			this.Controls.Add(this.endHour);
			this.Controls.Add(this.startMin);
			this.Controls.Add(this.startHour);
			this.Controls.Add(this.date);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "DetailForm";
			this.Text = "DetailForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.ComboBox startHour;
		private System.Windows.Forms.ComboBox startMin;
		private System.Windows.Forms.ComboBox endMin;
		private System.Windows.Forms.ComboBox endHour;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.Button Cancel;
	}
}