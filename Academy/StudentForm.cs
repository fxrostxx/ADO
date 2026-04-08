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
	public partial class StudentForm : HumanForm
	{
		public StudentForm()
		{
			InitializeComponent();
			DataTable groups = DataBase.Connector.Select("SELECT * FROM Groups");
			cbGroup.DataSource = groups;
			cbGroup.DisplayMember = "group_name";
			cbGroup.ValueMember = "group_id";
		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			Models.Student student = new Models.Student
			(
				tbLastname.Text,
				tbFirstname.Text,
				tbMiddlename.Text,
				dtpBirthdate.Value.ToString("yyyy-MM-dd"),
				tbEmail.Text,
				tbPhone.Text,
				pbPhoto.Image,
				Convert.ToInt32(cbGroup.SelectedValue)
			);
			DataBase.Connector.Insert("Students", $"{student.GetNames()}", $"{student.GetValues()}");
		}
	}
}
