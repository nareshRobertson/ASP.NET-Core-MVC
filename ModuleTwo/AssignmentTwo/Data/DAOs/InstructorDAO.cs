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
using AssignmentTwo.Models;

namespace AssignmentTwo.Data.DAOs {

	public class InstructorDAO : DAO<Instructor, InstructorDTO> {

		/**
		 * Creates a new DAO instance with its
		 * respective mapper for DTOs.
		 */
		public InstructorDAO() {
			_entities = _context.Set<Instructor>();
		}

		public async Task<InstructorVM> GetOneVM(int id) {
			var item = await _entities.SingleOrDefaultAsync(i => i.Id == id);

			if (item.Id > 0) {
				return new InstructorVM {
					Item = _mapper.Map<Instructor, InstructorDTO>(item),
					Courses = await new CourseDAO().GetAll()
				};
			}
			else
				return default;
		}

		/**
		 * Submits an item's edits to the database. Checks for 
		 * bad data first.
		 * Returns an ActionResult to the controller.
		 */
		public async Task<ActionResult> EditItem(InstructorDTO edited) {
			var existing = await _entities
				.SingleOrDefaultAsync(c => c.Id == edited.Id);

			if (existing != null) {
				if (DataEntered(edited.FirstName)) {
					existing.FirstName = edited.FirstName;
				}
				if (DataEntered(edited.LastName)) {
					existing.LastName = edited.LastName;
				}
				if (DataEntered(edited.Email) && EmailFormatCorrect(edited.Email)) {
					existing.Email = edited.Email;
				}
				if (edited.CourseId > 0 && edited.CourseId != existing.CourseId) {
					var newCourse = _context.Courses.Find(edited.CourseId);
					if (newCourse != null && newCourse.Instructor == null) {
						existing.CourseId = newCourse.Id;
					}
				}
				return await Update(existing);
			}
			return new OkResult();
		}

		/**
		 * Submits a new item to the database. Checks for 
		 * bad data first.
		 * Returns an ActionResult to the controller.
		 */
		public async Task<ActionResult> AddItem(InstructorDTO fresh) {
			var item = _mapper.Map<InstructorDTO, Instructor>(fresh);

			if (item.CourseId > 0 &&
				DataEntered(item.FirstName) &&
				DataEntered(item.LastName) &&
				DataEntered(item.Email) && EmailFormatCorrect(item.Email)) {

				var itemCourse = _context.Courses.Find(item.CourseId);
				if (itemCourse != null && itemCourse.Instructor == null) {
					return await Insert(item);
				}
			}
			return new OkResult();
		}

	}
}
