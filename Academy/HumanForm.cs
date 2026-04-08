using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Academy
{
	public partial class HumanForm : Form
	{
		internal Models.Human human;
		protected HumanForm()
		{
			InitializeComponent();
		}
		protected void Extract()
		{
			if (human != null)
			{
				tbLastname.Text = human.lastName;
				tbFirstname.Text = human.firstName;
				tbMiddlename.Text = human.middleName;
				dtpBirthdate.Value = Convert.ToDateTime(human.birthDate);
				tbEmail.Text = human.email;
				tbPhone.Text = human.phone;
			}
		}
		protected virtual void buttonOk_Click(object sender, EventArgs e)
		{
			human = new Models.Human
			(
				tbLastname.Text,
				tbFirstname.Text,
				tbMiddlename.Text,
				dtpBirthdate.Value.ToString("yyyy-MM-dd"),
				tbEmail.Text,
				tbPhone.Text,
				pbPhoto.Image
			);
		}
	}
}
