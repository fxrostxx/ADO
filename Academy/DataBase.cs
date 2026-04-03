using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Academy
{
	internal class DataBase
	{
		public static DBTools.Connector Connector { get; set; } =
			new DBTools.Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
	}
}
