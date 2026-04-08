using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	public class Human
	{
		internal string lastName;
		internal string firstName;
		internal string middleName;
		internal string birthDate;
		internal string email;
		internal string phone;
		internal Image photo;
		public Human(string lastName, string firstName, string middleName, string birthDate, string email, string phone, Image photo)
		{
			this.lastName = lastName;
			this.firstName = firstName;
			this.middleName = middleName;
			this.birthDate = birthDate;
			this.email = email;
			this.phone = phone;
			this.photo = photo;
		}
		public Human(Human other)
		{
			this.lastName = other.lastName;
			this.firstName = other.firstName;
			this.middleName = other.middleName;
			this.birthDate = other.birthDate;
			this.email = other.email;
			this.phone = other.phone;
			this.photo = other.photo;
		}
		public Human(object[] values)
		{
			this.lastName = values[1].ToString();
			this.firstName = values[2].ToString();
			this.middleName = values[3].ToString();
			this.birthDate = values[4].ToString();
			this.email = values[5].ToString();
			this.phone = values[6].ToString();
		}
		public virtual string GetNames()
		{
			return "last_name,first_name,middle_name,birth_date,email,phone";
		}
		public virtual string GetValues()
		{
			return $"{lastName},{firstName},{middleName},{birthDate},{email},{phone}";
		}
	}
}
