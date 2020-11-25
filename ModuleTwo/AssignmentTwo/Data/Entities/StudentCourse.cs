using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo {

	public class StudentCourse : IEntity {

		public int Id {
			get; set;
		}

		public int CourseId {
			get; set;
		}

		public int StudentId {
			get; set;
		}

		public virtual Course Course {
			get; set;
		}
		public virtual Student Student {
			get; set;
		}

	}
}
