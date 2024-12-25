using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
	public class Student:BaseEntity
	{
		public static int counter { get; set; }
		public string Fullname { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public Student(string fullname, int age, string email)
		{
			Id=++counter;
			Fullname = fullname;
			Age = age;
			Email = email;
		}
		public override string ToString() { 
			return $"Student Id:{Id}\nStudent Fullname:{Fullname}\nStudent Age:{Age}\nStudent Email:{Email}\n" +
				$"------------------------------------------------";
		}

	}
}
