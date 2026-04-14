using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	class Teacher : Human
	{
		internal string workSince;
		internal decimal rate;
		public Teacher(int id, string lastName, string firstName, string middleName, string birthDate, string email, string phone, Image photo, string workSince, decimal rate)
			: base(id, lastName, firstName, middleName, birthDate, email, phone, photo)
		{
			this.workSince = workSince;
			this.rate = rate;
		}
		public Teacher(Human human, string workSince, decimal rate) : base(human)
		{
			this.workSince = workSince;
			this.rate = rate;
		}
		public Teacher(object[] values) : base(values)
		{
			this.workSince = values[8].ToString();
			this.rate = Convert.ToDecimal(values[9]);
		}
		public override string GetCondition()
		{
			return base.GetCondition() + $" AND work_since=N'{workSince}' AND rate={rate.ToString().Replace(',', '.')}";
		}
		public override string GetNames()
		{
			return $"{base.GetNames()},work_since,rate";
		}
		public override string GetValues()
		{
			return $"{base.GetValues()},N'{workSince}',{rate.ToString().Replace(',', '.')}";
		}
	}
}
