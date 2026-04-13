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
		public Student(int id, string lastName, string firstName, string middleName, string birthDate, string email, string phone, Image photo, int group)
			: base(id, lastName, firstName, middleName, birthDate, email, phone, photo)
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
		public override string GetCondition()
		{
			return base.GetCondition() + $" AND [group]={group}";
		}
		public override string GetNames()
		{
			return $"{base.GetNames()},[group]";
		}
		public override string GetValues()
		{
			return $"{base.GetValues()},N'{group}'";
		}
	}
}
