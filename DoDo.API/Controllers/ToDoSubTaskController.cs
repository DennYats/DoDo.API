using DoDo.Application.DTOs.ToDo;
using DoDo.Application.IServices;
using DoDo.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoDo.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoSubTaskController : ControllerBase
    {
        private readonly IToDoSubTaskService toDoSubTaskService;

        public ToDoSubTaskController(IToDoSubTaskService toDoSubTaskService)
        {
            this.toDoSubTaskService = toDoSubTaskService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<ToDoSubTaskDTO>> Get()
        {
            return await toDoSubTaskService.GetSubTasksAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ToDoSubTaskDTO> Get(int id)
        {
            return await toDoSubTaskService.GetSubTaskByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(ToDoSubTask list)
        {
            toDoSubTaskService.Create(list);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put(ToDoSubTask list)
        {
            toDoSubTaskService.Update(list);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            toDoSubTaskService.Remove(id);
        }
    }
}
