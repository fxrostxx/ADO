using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		DBTools.Connector connector;
		Query[] queries =
		{
			new Query
			(
				"last_name,first_name,middle_name,group_name,direction_name",
				"Students,Groups,Directions",
				"[group]=group_id AND direction=direction_id"
			),
			new Query
			(
				"*",
				"Groups,Directions",
				"direction=direction_id"
			),
			new Query("*", "Directions"),
			new Query("*", "Disciplines"),
			new Query("*", "Teachers")
		};
		string currentFilter = "";
		string[] statusMessages = { "студентов", "групп", "направлений", "дисциплин", "преподавателей" };
		DataGridView[] tables;
		public MainForm()
		{
			InitializeComponent();
			tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
			connector = new DBTools.Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
			tabControl_SelectedIndexChanged(tabControl, null);
		}
		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbRecords.Items.Clear();
			cbRecords.Text = "";
			cbFields.Items.Clear();
			cbFields.Text = "";
			currentFilter = "";
			int i = tabControl.SelectedIndex;
			tables[i].DataSource = connector.Select(queries[i].ToString());
			toolStripStatusLabel.Text = $"Количество {statusMessages[i]}: {tables[i].RowCount - 1}";
			for (int j = 0; j < tables[i].ColumnCount; ++j)
				cbFields.Items.Add(tables[i].Columns[j].Name);
		}
		private void cbFields_SelectedIndexChanged(object sender, EventArgs e)
		{
			int tabIndex = tabControl.SelectedIndex;
			int cbFieldsIndex = cbFields.SelectedIndex;
			cbRecords.Items.Clear();
			cbRecords.Text = "";
			HashSet<string> values = new HashSet<string> { };
			for (int j = 0; j < tables[tabIndex].RowCount - 1; ++j)
				values.Add(tables[tabIndex].Rows[j].Cells[cbFieldsIndex].Value.ToString());
			cbRecords.Items.AddRange(values.ToArray());
		}
		private void buttonFilter_Click(object sender, EventArgs e)
		{
			if (cbRecords.SelectedIndex != -1 && cbFields.SelectedIndex != -1)
			{
				int tabIndex = tabControl.SelectedIndex;
				string newFilter = $"{cbFields.SelectedItem.ToString()}=N'{cbRecords.SelectedItem.ToString()}'";
				if (currentFilter == "") currentFilter = newFilter;
				else currentFilter += $" AND {newFilter}";
				Query query = new Query(queries[tabIndex]);
				if (query.Condition != "") query.Condition += $" AND {currentFilter}";
				else query.Condition = currentFilter;
				tables[tabIndex].DataSource = connector.Select(query.ToString());
				toolStripStatusLabel.Text = $"Количество {statusMessages[tabIndex]}: {tables[tabIndex].RowCount - 1}";
			}
			cbFields_SelectedIndexChanged(cbFields, null);
		}
		private void buttonRemoveFilters_Click(object sender, EventArgs e)
		{
			if (cbFields.Text != "" || cbRecords.Text != "")
			{
				currentFilter = "";
				int tabIndex = tabControl.SelectedIndex;
				tables[tabIndex].DataSource = connector.Select(queries[tabIndex].ToString());
				cbRecords.Items.Clear();
				cbRecords.Text = "";
				HashSet<string> values = new HashSet<string> { };
				for (int j = 0; j < tables[tabIndex].RowCount - 1; ++j)
					values.Add(tables[tabIndex].Rows[j].Cells[cbFields.SelectedIndex].Value.ToString());
				cbRecords.Items.AddRange(values.ToArray());
				toolStripStatusLabel.Text = $"Количество {statusMessages[tabIndex]}: {tables[tabIndex].RowCount - 1}";
			}
		}
	}
}
