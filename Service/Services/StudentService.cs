using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
	public class StudentService
	{
		public Student[] GetAllStudent()
		{
			Student stu1 = new Student("nuranaismayilzada", 22, "nurana@gmail.com");
			Student stu2 = new Student("alisaismayilzada", 23, "alisa@gmail.com");
			Student stu3 = new Student("nunu", 12, "nunu@gmail.com");
			Student stu4 = new Student("nura", 32, "nura@gmail.com");
			Student stu5 = new Student("nuni", 18, "nuni@gmail.com");
			Student[] students = new Student[] { stu1, stu2, stu3, stu4, stu5 };
			return students;
		}
		public Student GetById(int id)
		{
			Student[] students = GetAllStudent();
			var res=students.FirstOrDefault(student=>student.Id == id);
			return res;
		}
		public Student[] StudentSortDesc(int age)
		{
			Student[] students = GetAllStudent();
			var res=students.Where(student=>student.Age>age).ToArray();
			return res;
		}
	}
}
