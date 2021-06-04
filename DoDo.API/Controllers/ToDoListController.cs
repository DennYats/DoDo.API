using DoDo.Application.DTOs.ToDo;
using DoDo.Application.IServices;
using DoDo.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoDo.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListService toDoListService;
        private readonly UserManager<DoDoUser> userManager;

        public ToDoListController(IToDoListService toDoListService, UserManager<DoDoUser> userManager)
        {
            this.toDoListService = toDoListService;
            this.userManager = userManager;
        }
        
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<ToDoListDTO>> GetLists()
        {
            return await toDoListService.GetListsAsync(User?.FindFirst("uid")?.Value);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ToDoListDTO> GetListById(int id)
        {
            return await toDoListService.GetListByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void AddList(ToDoList list)
        {
            toDoListService.Create(list);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void UpdateList(ToDoList list)
        {
            toDoListService.Update(list);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void DeleteList(int id)
        {
            toDoListService.Remove(id);
        }
    }
}
