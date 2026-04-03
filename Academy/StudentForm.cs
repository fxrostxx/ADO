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
			DataBase.Connector.Insert
			(
				"Students",
				"last_name,first_name,middle_name,birth_date,email,phone,[group]",
				$"{tbLastname.Text},{tbFirstname.Text},{tbMiddlename.Text},{dtpBirthdate.Value.ToString("yyyy-MM-dd")},{tbEmail.Text},{tbPhone.Text},{cbGroup.SelectedValue}"
			);
		}
	}
}
