using Academy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class TeacherForm : HumanForm
	{
		internal Models.Teacher teacher;
		public TeacherForm()
		{
			InitializeComponent();
		}
		public TeacherForm(int id) : this()
		{
			DataTable data = DataBase.Connector.Select("*", "Teachers", $"teacher_id={id}");
			teacher = new Models.Teacher(data.Rows[0].ItemArray);
			human = teacher;
			Extract();
			dtpWorkSince.Value = teacher.workSince;
			tbRate.Text = teacher.rate.ToString();
			pbPhoto.Image = DataBase.Connector.DownloadPhoto("Teachers", "photo", teacher.id);
		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			base.buttonOk_Click(sender, e);
			teacher = new Models.Teacher(human, dtpWorkSince.Value, Convert.ToDouble(tbRate.Text));
			if (teacher.id == 0) DataBase.Connector.Insert("Teachers", $"{teacher.GetNames()}", $"{teacher.GetValues()}");
			else DataBase.Connector.Update($"UPDATE Teachers SET {teacher.GetUpdateString()} WHERE teacher_id={teacher.id}");
			if (teacher.photo != null) DataBase.Connector.UploadPhoto(teacher.SerializePhoto(), teacher.id, "photo", "Teachers");
		}
	}
}
