﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssignmentTwo.Models;

namespace AssignmentTwo.Controllers {

	public class HomeController : Controller {

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger) {

			_logger = logger;

		}

		public IActionResult Index() {
			return View();
		}

		public IActionResult Instructors() {
			return View();
		}

		public IActionResult Students() {
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
