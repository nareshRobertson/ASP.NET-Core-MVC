using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo.Models {
	public class StudentVM {

		public StudentDTO Item {
			get; set;
		}

		public List<StudentCourseDTO> CurrentCourses {
			get; set;
		}

		public List<CourseDTO> AvailableCourses {
			get; set;
		}

		public List<StudentCourseDTO> AllStudentCourses {
			get; set;
		}
	}
}
