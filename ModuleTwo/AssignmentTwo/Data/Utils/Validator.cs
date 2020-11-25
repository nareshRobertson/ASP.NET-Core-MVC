using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentTwo {
	public static class Validator {

		public static bool DataEntered(string data) {
			return data != null && data != "";
		}

		public static bool EmailFormatCorrect(string email) {
			return Regex.IsMatch(email, "^(.+)@(.+)$");
		}
	}
}
