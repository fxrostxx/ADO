using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DLLTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DBTools.Connector connector = new DBTools.Connector(ConfigurationManager.ConnectionStrings["Movies_PV_521"].ConnectionString);
			connector.Select("SELECT * FROM Movies");

			DBTools.Connector academyConnector = new DBTools.Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
			academyConnector.Select("SELECT * FROM Disciplines");
		}
	}
}
