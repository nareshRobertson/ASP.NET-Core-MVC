using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTwo.Data.DAOs {

	public class DAO<E, D>
		where E : IEntity
		where D : IDTO {

		public SchoolContext _context;
		public IQueryable<E> _entities;
		public IMapper _mapper;

		public DAO() {
			_context = new SchoolContext();

			// AutoMapper configuration
			var config = new MapperConfiguration(cfg => {
				// Maps for courses
				cfg.CreateMap<Course, CourseDTO>()
				.ForMember(dest => dest.InstructorName, opt => opt.MapFrom(src => src.Instructor.FirstName + " " + src.Instructor.LastName))
				.ForMember(dest => dest.NameAndNumber, opt => opt.MapFrom(src => src.Number + " - " + src.Name));
				cfg.CreateMap<CourseDTO, Course>();

				// Maps for instructors
				cfg.CreateMap<Instructor, InstructorDTO>()
				.ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
				.ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.Course.Id))
				.ForMember(dest => dest.CourseNumber, opt => opt.MapFrom(src => src.Course.Number))
				.ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name));
				cfg.CreateMap<InstructorDTO, Instructor>();

				// Maps for students
				cfg.CreateMap<Student, StudentDTO>()
				.ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.LastName + ", " + src.FirstName))
				.ForMember(dest => dest.Courses, opt => opt.MapFrom(src => src.StudentCourses));
				cfg.CreateMap<StudentDTO, Student>();

				// Maps for student-course relationship
				cfg.CreateMap<StudentCourse, StudentCourseDTO>()
				.ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.LastName + ", " + src.Student.FirstName))
				.ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Number + " - " + src.Course.Name));
				cfg.CreateMap<StudentCourseDTO, StudentCourse>();

			});

			_mapper = config.CreateMapper();
		}

		/**
		 * Returns a list of all items, mapped to their
		 * DTO form.
		 */
		public async Task<List<D>> GetAll() {
			List<E> items = await _entities.ToListAsync();
			List<D> DTOs = new List<D>();

			foreach (E e in items) {
				DTOs.Add(_mapper.Map<E, D>(e));
			}

			return DTOs;
		}

		/**
		 * Returns a single item from the database matched
		 * to an id and mapped to a DTO. If there is no such
		 * item, returns null.
		 */
		public virtual async Task<D> GetOne(int id) {
			var item = await _entities.SingleOrDefaultAsync(i => i.Id == id);

			if (item != null) {
				return _mapper.Map<E, D>(item);
			}
			else
				return default;
		}

		/**
		 * Updates the item in the database. Returns a NotFoundResult
		 * if the item does not exist.
		 */
		public async Task<ActionResult> Update(E item) {
			try {
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException) {
				if (!ItemExists(item.Id)) {
					return new NotFoundResult();
				}
				else {
					throw;
				}
			}
			return new OkResult();
		}

		/**
		 * Adds a new item to the database. Returns an error if the
		 * item already exists.
		 */
		public async Task<ActionResult> Insert(E item) {
			try {
				_context.Add(item);
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException) {
				if (ItemExists(item.Id)) {
					return new ConflictResult();
				}
				else {
					throw;
				}
			}
			return new OkResult();
		}

		/**
		 * Deletes an item from the database.
		 */
		public async Task<ActionResult> Delete(int id) {
			try {
				var item = await _entities.SingleOrDefaultAsync(i => i.Id == id);
				_context.Remove(item);
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException) {
				if (!ItemExists(id)) {
					return new NotFoundResult();
				}
				else {
					throw;
				}
			}
			return new OkResult();
		}

		/**
		 * Checks to see if an item exists.
		 */
		public bool ItemExists(int id) {
			return _entities.Any(e => e.Id == id);
		}
	}
}