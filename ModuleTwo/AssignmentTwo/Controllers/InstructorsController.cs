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
using AssignmentTwo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentTwo.Controllers {
	public class InstructorsController : Controller {

		public InstructorDAO _dao;
		private readonly ILogger<InstructorsController> _logger;

		public InstructorsController(ILogger<InstructorsController> logger) {
			_logger = logger;
			_dao = new InstructorDAO();
		}

		public async Task<IActionResult> Index() {
			return View(await _dao.GetAll());
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id) {
			var model = await _dao.GetOneVM(id);
			return View(model);
		}

		[HttpPost, ActionName("Edit")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SubmitEdits(InstructorDTO item) {
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
		public async Task<IActionResult> SubmitNew(InstructorDTO item) {
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
