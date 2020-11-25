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

namespace AssignmentTwo.Data.DAOs {

	public class CourseDAO : DAO<Course, CourseDTO> {
	
		/**
		 * Creates a new DAO instance with its
		 * respective mapper for DTOs.
		 */
		public CourseDAO() {
			_entities = _context.Set<Course>();
		}

		/**
		 * Submits an item's edits to the database. Checks for 
		 * bad data first.
		 * Returns an ActionResult to the controller.
		 */
		public async Task<ActionResult> EditItem(CourseDTO edited) {
			var existing = await _entities
				.SingleOrDefaultAsync(c => c.Id == edited.Id);

			if (existing != null) {
				if (DataEntered(edited.Name)) {
					existing.Name = edited.Name;
				}
				if (DataEntered(edited.Number)) {
					existing.Number = edited.Number;
				}
				if (DataEntered(edited.Description)) {
					existing.Description = edited.Description;
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
		public async Task<ActionResult> AddItem(CourseDTO fresh) {
			var item = _mapper.Map<CourseDTO, Course>(fresh);

			if (DataEntered(item.Name) && DataEntered(item.Number) && DataEntered(item.Description)) {
				return await Insert(item);
			}
			return new OkResult();
		}

	}
}
