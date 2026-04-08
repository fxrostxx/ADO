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
		string lastName;
		string firstName;
		string middleName;
		string birthDate;
		string email;
		string phone;
		Image photo;
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
