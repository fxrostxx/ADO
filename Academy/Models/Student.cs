using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	class Student : Human
	{
		internal int group;
		public Student(string lastName, string firstName, string middleName, string birthDate, string email, string phone, Image photo, int group)
			: base(lastName, firstName, middleName, birthDate, email, phone, photo)
		{
			this.group = group;
		}
		public Student(Human human, int group) : base(human)
		{
			this.group = group;
		}
		public Student(object[] values) : base(values)
		{
			this.group = Convert.ToInt32(values[8]);
		}
		public override string GetNames()
		{
			return $"{base.GetNames()},[group]";
		}
		public override string GetValues()
		{
			return $"{base.GetValues()},{group}";
		}
	}
}
