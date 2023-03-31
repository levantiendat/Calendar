using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
	public partial class PlanForm : Form
	{
		public PlanForm()
		{
			InitializeComponent();
			setDate();
			
		}
		public void setDate()
		{
			date.Value = DateTime.Now;
		}

		private void date_ValueChanged(object sender, EventArgs e)
		{
			DateTime s = new DateTime();
			s = Convert.ToDateTime(date.Value);
			DBCalendar db = new DBCalendar();
			var query = db.Calendar.OrderBy(p => p.StartTime)
				.Where(p => s.Date == p.RemindDay)
				.Select(p => new { p.Name, p.Address, p.StartTime, p.EndTime }).ToList();
			data.DataSource = query;
		}

		private void add_Click(object sender, EventArgs e)
		{
			DetailForm f = new DetailForm("");
			f.d += new DetailForm.MyDel(setDate);
			f.Show();
		}

		private void edit_Click(object sender, EventArgs e)
		{
			if (data.SelectedRows.Count == 1)
			{
				string name = data.SelectedRows[0].Cells["Name"].Value.ToString();
				DetailForm f = new DetailForm(name);
				f.d += new DetailForm.MyDel(setDate);
				f.Show();
			}
		}

		private void delete_Click(object sender, EventArgs e)
		{
			if (data.SelectedRows.Count > 0)
			{
				List<string> list = new List<string>();
				foreach(DataGridViewRow i in data.SelectedRows)
				{
					list.Add(i.Cells["Name"].Value.ToString());
				}
				foreach(string li in list)
				{
					DialogResult at = MessageBox.Show("Bạn có muốn xóa Remind có tên " + li + " không ?", "Confirm", MessageBoxButtons.OKCancel);
					if (at == DialogResult.OK)
					{
						DBCalendar db = new DBCalendar();
						var s = db.Calendar
							.Where(p => p.Name.CompareTo(li) == 0)
							.Select(p => p).FirstOrDefault();
						db.Calendar.Remove(s);
						db.SaveChanges();
						setDate();
					}
				}
			}
			
		}
	}
}
