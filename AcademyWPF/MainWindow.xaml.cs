using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using DBTools;

namespace AcademyWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Connector connector;
		DataGrid[] tables;
		Dictionary<string, int> d_directions;
		Dictionary<string, int> d_groups;
		public MainWindow()
		{
			InitializeComponent();
			connector = new Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
			tables = new DataGrid[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
			tabControl.SelectedIndex = 0;
			d_directions = connector.GetDictionary("Directions");
			d_groups = connector.GetDictionary("Groups");
			cbStudentsGroup.ItemsSource = d_groups.Keys.ToArray();
			cbGroupsDirection.ItemsSource = d_directions.Keys.ToArray();
			cbStudentsDirection.ItemsSource = d_directions.Keys.ToArray();
		}
		private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int i = (sender as TabControl).SelectedIndex;
			tables[i].ItemsSource = connector.Select($"SELECT * FROM {((sender as TabControl).Items[i] as TabItem).Header.ToString()}").DefaultView;
			statusBarCount.Text = $"Количество записей: {tables[i].Items.Count - 1}";
		}
		private void cbGroupsDirection_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			dgvGroups.ItemsSource = connector.Select($"SELECT * FROM Groups,Directions WHERE direction=direction_id AND direction={d_directions[cbGroupsDirection.SelectedItem.ToString()]}").DefaultView;
			statusBarCount.Text = $"Количество записей: {dgvGroups.Items.Count - 1}";
		}
		private void cbStudentsDirection_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			d_groups = connector.GetDictionary("Groups", $"direction={d_directions[cbStudentsDirection.SelectedItem.ToString()]}");
			cbStudentsGroup.Items.Clear();
			cbStudentsGroup.ItemsSource = d_groups.Keys.ToArray();
			dgvStudents.ItemsSource = connector.Select($"SELECT stud_id,last_name,first_name,middle_name,group_name,direction_name FROM Students,Groups,Directions WHERE [group]=group_id AND direction=direction_id AND direction={d_directions[cbStudentsDirection.SelectedItem.ToString()]}").DefaultView;
			statusBarCount.Text = $"Количество записей: {dgvStudents.Items.Count - 1}";
		}
		private void buttonAddStudent_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
