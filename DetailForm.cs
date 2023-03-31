using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
	public partial class DetailForm : Form
	{
		public delegate void MyDel();
		public MyDel d { get; set; }
		public string NAME { get; set; }
		public int ID_1 { get; set; }
		public DetailForm(string name)
		{
			NAME = name;
			ID_1 = 0;
			InitializeComponent();
			GUI();
		}
		public void GUI()
		{
			startHour.Items.Clear();
			startMin.Items.Clear();
			endHour.Items.Clear();
			endMin.Items.Clear();
			for (int i = 0; i < 24; i++)
			{
				startHour.Items.Add(i);
				endHour.Items.Add(i);
			}
			for (int i = 0; i < 60; i++)
			{
				startMin.Items.Add(i);
				endMin.Items.Add(i);
			}
			if (NAME != "")
			{
				DBCalendar db = new DBCalendar();
				var s = db.Calendar
					.Where(p => p.Name.CompareTo(NAME)==0)
					.Select(p => new { p.ID,p.Name, p.Address, p.RemindDay, p.StartTime, p.EndTime })
					.FirstOrDefault();
				txtName.Text = s.Name.ToString();
				txtAddress.Text = s.Address.ToString();
				date.Text = s.RemindDay.ToString();
				int hour = s.StartTime.Value.Hours;
				startHour.Text = hour.ToString();
				int minute = s.StartTime.Value.Minutes;
				startMin.Text = minute.ToString();
				hour = s.EndTime.Value.Hours;
				minute = s.EndTime.Value.Minutes;
				endHour.Text = hour.ToString();
				endMin.Text = minute.ToString();
				ID_1 = s.ID;
			}
		}
		//sai hàm checklist
		public bool checklist(Calendar cd)
		{
			
			
			DBCalendar db = new DBCalendar();
				var s = db.Calendar
					.Where(p => (p.RemindDay==cd.RemindDay))
					.Select(p => p)
					.ToList();
				int count = s.Count();
			for (int i=0;i<count;i++)
			{
				if ((cd.StartTime >= s[i].EndTime || cd.EndTime <= s[i].StartTime)||s[i].ID == ID_1)
				{
					continue;
				}
				else
				{

					return false;
				}
			}
			return true;
			
			
		}
		private void ok_Click(object sender, EventArgs e)
		{
			using (DBCalendar db = new DBCalendar())
			{
				Calendar ca = new Calendar
				{
					Name = txtName.Text.ToString(),
					Address = txtAddress.Text.ToString(),
					RemindDay = Convert.ToDateTime(date.Text.ToString()),
					StartTime=new TimeSpan(Convert.ToInt32(startHour.SelectedItem), Convert.ToInt32(startMin.SelectedItem), 0),
					EndTime = new TimeSpan(Convert.ToInt32(endHour.SelectedItem), Convert.ToInt32(endMin.SelectedItem), 0),
				};
				if (checklist(ca))
				{
					if (NAME != "")
					{

						Calendar s = db.Calendar.Find(ID_1);
						s.Name = ca.Name;
						s.Address = ca.Address;
						s.RemindDay = ca.RemindDay;
						s.StartTime = ca.StartTime;
						s.EndTime = ca.EndTime;
						db.SaveChanges();
					}
					else
					{
						db.Calendar.Add(ca);
						db.SaveChanges();
					}
					d();
					this.Close();
				}
				else
				{
					MessageBox.Show("Thông tin không hợp lệ mời bạn nhập lại\n Nếu đây là thông tin đè vào remind khác, mời bạn bấm sửa ở hàng đó");
					
					var s = db.Calendar
					.Where(p => (p.RemindDay == ca.RemindDay))
					.Select(p => p)
					.ToList();
					foreach (Calendar i in s)
					{
						if((ca.StartTime >= i.EndTime || ca.EndTime <= i.StartTime) || i.ID == ID_1){
							continue;
						}
						else {
							DialogResult at = MessageBox.Show("Bạn có muốn thay thế Remind có tên " + i.Name + " không ?", "Confirm", MessageBoxButtons.OKCancel);
							if (at == DialogResult.OK)
							{
								db.Calendar.Remove(i);
								
								db.SaveChanges();
								
							}
							else
							{
								break;
							}
							db.Calendar.Add(ca);
						}
					}
					d();
				}
				
			}


			
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
