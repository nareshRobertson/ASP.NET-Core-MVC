using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssignmentTwo;
using AutoMapper;
using Microsoft.Extensions.Logging;
using static AssignmentTwo.Validator;
using AssignmentTwo.Data.DAOs;

namespace AssignmentTwo.Controllers {
	public class CoursesController : Controller {

		public CourseDAO _dao;
		private readonly ILogger<CoursesController> _logger;
		
		public CoursesController(ILogger<CoursesController> logger) {
			_logger = logger;
			_dao = new CourseDAO();
		}

		public async Task<IActionResult> Index() {
			return View(await _dao.GetAll());
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id) {
			var item = await _dao.GetOne(id);
			if (item.Id > 0) {
				return View(item);
			}
			else
				return NotFound();
		}

		[HttpPost, ActionName("Edit")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SubmitEdits(CourseDTO item) {
			ActionResult result = await _dao.EditItem(item);
			if (result.GetType() == typeof(OkResult)) {
				return RedirectToAction("Index");
			}
			else {
				return result;
			}
		}

		[HttpGet]
		public ActionResult AddNew() {
			return View();
		}

		[HttpPost, ActionName("AddNew")]
		public async Task<IActionResult> SubmitNew(CourseDTO item) {
			ActionResult result = await _dao.AddItem(item);
			if (result.GetType() == typeof(OkResult)) {
				return RedirectToAction("Index");
			}
			else {
				return result;
			}
		}

		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> SubmitDelete(int id) {
			ActionResult result = await _dao.Delete(id);
			if (result.GetType() == typeof(OkResult)) {
				return RedirectToAction("Index");
			}
			else {
				return result;
			}
		}

	}
}
