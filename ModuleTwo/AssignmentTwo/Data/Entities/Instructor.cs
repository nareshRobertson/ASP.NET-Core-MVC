using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo {
	public class Instructor : IEntity {

		public int Id {
			get; set;
		}

		public int CourseId {
			get; set;
		}

		public string FirstName {
			get; set;
		}

		public string LastName {
			get; set;
		}

		public string Email {
			get; set;
		}

		public virtual Course Course {
			get; set;
		}
		
	}
}
