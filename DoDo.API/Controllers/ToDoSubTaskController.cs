using DoDo.Application.DTOs.ToDo;
using DoDo.Application.IServices;
using DoDo.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<ToDoSubTaskDTO>> GetSubTasks()
        {
            return await toDoSubTaskService.GetSubTasksAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ToDoSubTaskDTO> GetSubTaskById(int id)
        {
            return await toDoSubTaskService.GetSubTaskByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void AddSubTask(ToDoSubTask list)
        {
            toDoSubTaskService.Create(list);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void UpdateSubTask(ToDoSubTask list)
        {
            toDoSubTaskService.Update(list);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void DeleteSubTask(int id)
        {
            toDoSubTaskService.Remove(id);
        }
    }
}
