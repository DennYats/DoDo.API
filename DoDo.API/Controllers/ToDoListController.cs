using DoDo.Application.DTOs.ToDo;
using DoDo.Application.Services.Interfaces;
using DoDo.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoDo.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListService toDoListService;
        private readonly UserManager<ApplicationUser> userManager;

        public ToDoListController(IToDoListService toDoListService, UserManager<ApplicationUser> userManager)
        {
            this.toDoListService = toDoListService;
            this.userManager = userManager;
        }
        
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<ToDoListDTO>> Get()
        {
            return await toDoListService.GetListsAsync(User?.FindFirst("uid")?.Value);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ToDoListDTO> Get(int id)
        {
            return await toDoListService.GetListByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(ToDoList list)
        {
            toDoListService.Create(list);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put(ToDoList list)
        {
            toDoListService.Update(list);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            toDoListService.Remove(id);
        }
    }
}
