using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo.Models {
	public class InstructorVM {

		public InstructorDTO Item {
			get; set;
		}

		public List<CourseDTO> Courses {
			get; set;
		}
	}
}
