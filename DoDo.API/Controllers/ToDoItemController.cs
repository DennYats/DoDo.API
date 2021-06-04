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
    public class ToDoItemController : ControllerBase
    {
        private readonly IToDoItemService toDoItemService;

        public ToDoItemController(IToDoItemService toDoItemService)
        {
            this.toDoItemService = toDoItemService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<ToDoItemDTO>> GetToDoItems()
        {
            return await toDoItemService.GetItemsAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ToDoItemDTO> GetToDoItemById(int id)
        {
            return await toDoItemService.GetItemByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void AddToDoItem(ToDoItem list)
        {
            toDoItemService.Create(list);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void UpdateToDoItem(ToDoItem list)
        {
            toDoItemService.Update(list);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void DeleteToDoItem(int id)
        {
            toDoItemService.Remove(id);
        }
    }
}
