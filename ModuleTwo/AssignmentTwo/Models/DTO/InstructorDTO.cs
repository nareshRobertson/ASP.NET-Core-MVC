using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo {

	public class InstructorDTO : IDTO{

		public int Id {
			get; set;
		}

		[Display(Name = "First Name")]
		[Required]
		public string FirstName {
			get; set;
		}

		[Display(Name = "Last Name")]
		[Required]
		public string LastName {
			get; set;
		}

		[Display(Name = "Full Name")]
		public string FullName {
			get; set;
		}

		[DataType(DataType.EmailAddress)]
		[Required]
		public string Email {
			get; set;
		}

		[Display(Name = "Course Taught")]
		public int CourseId {
			get; set;
		}

		public string CourseNumber {
			get; set;
		}

		public string CourseName {
			get; set;
		}
	}
}
