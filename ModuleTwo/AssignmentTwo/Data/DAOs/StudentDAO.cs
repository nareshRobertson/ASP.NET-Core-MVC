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

	public class StudentDAO : DAO<Student, StudentDTO> {

		/**
		 * Creates a new DAO instance with its
		 * respective mapper for DTOs.
		 */
		public StudentDAO() {
			_entities = _context.Set<Student>();
		}

		public async Task<StudentVM> GetOneVM(int id) {
			var item = await _entities.SingleOrDefaultAsync(i => i.Id == id);
			var allStudentCourses = await _context.StudentCourses.ToListAsync();

			if (item != null) {
				return new StudentVM {
					Item = _mapper.Map<Student, StudentDTO>(item),
					AllStudentCourses = 
					(from sc in allStudentCourses
					 select _mapper.Map<StudentCourse, StudentCourseDTO>(sc)).ToList(),
					AvailableCourses = 
						(from sc in allStudentCourses
						 where sc.StudentId != item.Id
						 select _mapper.Map<Course, CourseDTO>(sc.Course)).Distinct().ToList(),
					CurrentCourses =
						(from sc in allStudentCourses
						 where sc.StudentId == item.Id
						 select _mapper.Map<StudentCourse, StudentCourseDTO>(sc)).ToList()
				};
			}
			else
				return default;
		}

		public async Task<int> DropCourse(int id) {
			int student;

			try {
				var item = await _context.StudentCourses.SingleOrDefaultAsync(i => 
					i.Id == id);
				student = item.StudentId;
				_context.Remove(item);
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException) {
				throw;
			}
			return student;
		}

		/**
		 * Submits an item's edits to the database. Checks for 
		 * bad data first.
		 * Returns an ActionResult to the controller.
		 */
		public async Task<ActionResult> EditItem(StudentDTO edited) {
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
				if (DataEntered(edited.Phone)) {
					existing.Phone = edited.Phone;
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
		public async Task<ActionResult> AddItem(StudentDTO fresh) {
			var item = _mapper.Map<StudentDTO, Student>(fresh);

			if (DataEntered(item.FirstName) &&
				DataEntered(item.LastName) &&
				DataEntered(item.Email) && 
				EmailFormatCorrect(item.Email) &&
				DataEntered(item.Phone)) {
				return await Insert(item);
			}
			return new OkResult();
		}

	}
}
