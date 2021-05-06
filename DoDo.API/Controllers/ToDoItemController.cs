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
    public class ToDoItemController : ControllerBase
    {
        private readonly IToDoItemService toDoItemService;

        public ToDoItemController(IToDoItemService toDoItemService)
        {
            this.toDoItemService = toDoItemService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<ToDoItemDTO>> Get()
        {
            return await toDoItemService.GetItemsAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ToDoItemDTO> Get(int id)
        {
            return await toDoItemService.GetItemByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(ToDoItem list)
        {
            toDoItemService.Create(list);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put(ToDoItem list)
        {
            toDoItemService.Update(list);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            toDoItemService.Remove(id);
        }
    }
}
