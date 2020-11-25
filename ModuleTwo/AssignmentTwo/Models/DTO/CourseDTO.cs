using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo {

	public class CourseDTO : IDTO {

		public int Id {
			get; set;
		}

		[Display(Name = "Course Number")]
		[Required]
		public string Number {
			get; set;
		}

		[Display(Name = "Course Name")]
		[Required]
		public string Name {
			get; set;
		}

		[Display(Name = "Course")]
		public string NameAndNumber {
			get; set;
		}

		[Required]
		public string Description {
			get; set;
		}

		public string InstructorName {
			get; set;
		}
	}
}
