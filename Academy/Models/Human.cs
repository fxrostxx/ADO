using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Academy.Models
{
	public class Human
	{
		internal int id;
		internal string lastName;
		internal string firstName;
		internal string middleName;
		internal string birthDate;
		internal string email;
		internal string phone;
		internal Image photo;
		public Human(int id, string lastName, string firstName, string middleName, string birthDate, string email, string phone, Image photo)
		{
			this.id = id;
			this.lastName = lastName;
			this.firstName = firstName;
			this.middleName = middleName;
			this.birthDate = birthDate;
			this.email = email;
			this.phone = string.IsNullOrWhiteSpace(phone) ? "" : phone;
			this.photo = photo;
		}
		public Human(Human other)
		{
			this.id = other.id;
			this.lastName = other.lastName;
			this.firstName = other.firstName;
			this.middleName = other.middleName;
			this.birthDate = other.birthDate;
			this.email = other.email;
			this.phone = string.IsNullOrWhiteSpace(other.phone) ? "" : other.phone;
			this.photo = other.photo;
		}
		public Human(object[] values)
		{
			this.id = Convert.ToInt32(values[0]);
			this.lastName = values[1].ToString();
			this.firstName = values[2].ToString();
			this.middleName = values[3].ToString();
			this.birthDate = values[4].ToString();
			this.email = values[5].ToString();
			this.phone = string.IsNullOrWhiteSpace(values[6].ToString()) ? "" : phone;
		}
		public byte[] SerializePhoto()
		{
			if (photo == null) return null;
			MemoryStream ms = new MemoryStream();
			photo.Save(ms, photo.RawFormat);
			return ms.ToArray();
		}
		public virtual string GetNames()
		{
			return "last_name,first_name,middle_name,birth_date,email,phone";
		}
		public virtual string GetValues()
		{
			return $"N'{lastName}',N'{firstName}',N'{middleName}',N'{birthDate}',N'{email}',N'{phone}'";
		}
		public virtual string GetCondition()
		{
			return $" last_name=N'{lastName}' AND first_name=N'{firstName}' AND middle_name=N'{middleName}' AND birth_date=N'{birthDate}' AND email=N'{email}' AND phone=N'{phone}'";
		}
		public string GetUpdateString()
		{
			return GetCondition().Replace(" AND ", ",");
		}
	}
}
