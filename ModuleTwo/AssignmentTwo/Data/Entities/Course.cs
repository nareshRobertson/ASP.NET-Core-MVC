using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo {
	public class Course : IEntity {

		public int Id {
			get; set;
		}

		public string Number {
			get; set;
		}

		public string Name {
			get; set;
		}

		public string Description {
			get; set;
		}

		public virtual Instructor Instructor {
			get; set;
		}

		public virtual List<StudentCourse> StudentCourses {
			get; set;
		}
	}
}
