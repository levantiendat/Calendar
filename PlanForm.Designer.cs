namespace Calendar
{
	partial class PlanForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.date = new System.Windows.Forms.DateTimePicker();
			this.data = new System.Windows.Forms.DataGridView();
			this.add = new System.Windows.Forms.Button();
			this.edit = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.date);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(821, 23);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.data);
			this.panel2.Location = new System.Drawing.Point(13, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(821, 598);
			this.panel2.TabIndex = 1;
			// 
			// date
			// 
			this.date.Location = new System.Drawing.Point(316, 0);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(200, 22);
			this.date.TabIndex = 0;
			this.date.Value = new System.DateTime(2023, 3, 31, 1, 14, 59, 0);
			this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
			// 
			// data
			// 
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(0, 4);
			this.data.Name = "data";
			this.data.RowHeadersWidth = 51;
			this.data.RowTemplate.Height = 24;
			this.data.Size = new System.Drawing.Size(821, 591);
			this.data.TabIndex = 0;
			// 
			// add
			// 
			this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add.Location = new System.Drawing.Point(13, 655);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(168, 89);
			this.add.TabIndex = 2;
			this.add.Text = "ADD";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// edit
			// 
			this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edit.Location = new System.Drawing.Point(329, 655);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(168, 89);
			this.edit.TabIndex = 3;
			this.edit.Text = "EDIT";
			this.edit.UseVisualStyleBackColor = true;
			this.edit.Click += new System.EventHandler(this.edit_Click);
			// 
			// delete
			// 
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(666, 655);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(168, 89);
			this.delete.TabIndex = 4;
			this.delete.Text = "DELETE";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// PlanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 756);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.add);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "PlanForm";
			this.Text = "PlanForm";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button edit;
		private System.Windows.Forms.Button delete;
	}
}