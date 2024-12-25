using Domain.Model;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPP.Controllers
{
	public class StudentController
	{
		private readonly StudentService _studentService;
		public StudentController()
		{
			_studentService = new StudentService();
		}
		public void GetAllShowStudent()
		{
			Student[] students = _studentService.GetAllStudent();
			foreach (Student student in students)
			{
				Console.WriteLine(student);
			}
		}
		public void GetStudentById() {
			Console.Write("Id daxil edin:");
			int id;
			id=Int32.Parse(Console.ReadLine());
			var result=_studentService.GetById(id);
			if (result!=null)
			{
				Console.WriteLine(result);
			}
			else
			{
				Console.WriteLine("Bele bir student tapilmadi!");
			}
		}
		public void StudentSortDesc()
		{
			Console.WriteLine("Enter age:");
			int age;
			age=int.Parse(Console.ReadLine());
			var res=_studentService.StudentSortDesc(age);
			foreach (var student in res)
			{
				Console.WriteLine(student);
			}
		}
		
	}

}
