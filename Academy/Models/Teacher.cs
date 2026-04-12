using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	class Teacher : Human
	{
		internal DateTime workSince;
		internal double rate;
		public Teacher(int id, string lastName, string firstName, string middleName, string birthDate, string email, string phone, Image photo, DateTime workSince, double rate)
			: base(id, lastName, firstName, middleName, birthDate, email, phone, photo)
		{
			this.workSince = workSince;
			this.rate = rate;
		}
		public Teacher(Human human, DateTime workSince, double rate) : base(human)
		{
			this.workSince = workSince;
			this.rate = rate;
		}
		public Teacher(object[] values) : base(values)
		{
			this.workSince = Convert.ToDateTime(values[8]);
			this.rate = Convert.ToDouble(values[9]);
		}
		public override string GetCondition()
		{
			return base.GetCondition() + $" AND work_since=N'{workSince.ToString("yyyy-MM-dd")}' AND rate=N'{rate}'";
		}
		public string GetUpdateString()
		{
			return GetCondition().Replace(" AND ", ",");
		}
		public override string GetNames()
		{
			return $"{base.GetNames()},work_since,rate";
		}
		public override string GetValues()
		{
			return $"{base.GetValues()},{workSince.ToString("yyyy-MM-dd")},{rate}";
		}
	}
}
