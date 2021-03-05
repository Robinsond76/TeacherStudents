using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudents.Controllers
{
    [ApiController]
    [Route("api/teachers")]
    public class TeachersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TeachersController(IRepositoryManager repository, ILoggerManager logger,
            IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTeachers()
        {
                var teachers = await _repository.Teacher.GetAllTeachers(trackChanges: false);

                return Ok(_mapper.Map<IEnumerable<TeacherDto>>(teachers));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacher(Guid id)
        {
            var teacher = await _repository.Teacher.GetTeacher(id, trackChanges: false);
            if (teacher == null)
            {
                _logger.LogInfo($"Teacher with id: {id} doesn't exist in Database.");
                return NotFound();
            }
            
            return Ok(_mapper.Map<TeacherDto>(teacher));
        }
    }
}
