using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudents.Controllers
{
    [ApiController]
    [Route("api/teachers/{teacherId}/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StudentsController(IRepositoryManager repository, ILoggerManager logger,
            IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents(Guid teacherId)
        {
            var students = await _repository.Student.GetStudents(teacherId, trackChanges: false);

            return Ok(_mapper.Map<IEnumerable<StudentDto>>(students));
        }

        [HttpGet("{id}", Name = "StudentById")]
        public async Task<IActionResult> GetStudent(Guid teacherId, Guid id)
        {
            var teacher = await _repository.Teacher.GetTeacher(teacherId, trackChanges: false);
            if (teacher == null)
            {
                _logger.LogInfo($"Teacher with id: {id} doesn't exist in Database.");
                return NotFound();
            }

            var student = await _repository.Student.GetStudent(teacherId, id, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {id} does not exist in the database.");
                return NotFound();
            }

            return Ok(_mapper.Map<StudentDto>(student));
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Guid teacherId, [FromBody] StudentForCreationDto student)
        {
            if (student == null)
            {
                _logger.LogError("StudentForCreationDto object from client is null.");
                return NotFound();
            }

            var teacher = await _repository.Teacher.GetTeacher(teacherId, trackChanges: false);
            if (teacher == null)
            {
                _logger.LogInfo($"Teacher with id: {teacherId} doesn't exist in Database.");
                return NotFound();
            }

            var studentEntity = _mapper.Map<Student>(student);
            _repository.Student.AddStudent(teacherId, studentEntity);
            await _repository.Save();

            var studentDto = _mapper.Map<StudentDto>(studentEntity);
            return CreatedAtRoute("StudentById", new {teacherId, id = studentDto.Id }, studentDto);

        }
    }
}
