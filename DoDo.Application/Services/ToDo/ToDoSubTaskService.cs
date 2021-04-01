using AutoMapper;
using DoDo.Application.DTOs.ToDo;
using DoDo.Application.Services.Interfaces;
using DoDo.Domain.Entities;
using DoDo.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoDo.Application.Services.ToDo
{
    public class ToDoSubTaskService : IToDoSubTaskService
    {
        private DoDoContext db;
        private IMapper mapper;

        public ToDoSubTaskService(DoDoContext context, IMapper mapper)
        {
            this.db = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ToDoSubTaskDTO>> GetSubTasksAsync()
        {
            var listOfSubTasks = await db.ToDoSubTasks.ToListAsync();

            var dtoListOfSubTasks = mapper.Map<IEnumerable<ToDoSubTaskDTO>>(listOfSubTasks);

            return dtoListOfSubTasks;
        }

        public async Task<ToDoSubTaskDTO> GetSubTaskByIdAsync(int id)
        {
            var subTask = await db.ToDoSubTasks.FindAsync(id);

            var dtoSubTask = mapper.Map<ToDoSubTaskDTO>(subTask);

            return dtoSubTask;
        }

        public async Task Create(ToDoSubTask subTask)
        {
            db.ToDoSubTasks.Add(subTask);
            await db.SaveChangesAsync();
        }

        public async Task Update(ToDoSubTask subTask)
        {
            db.ToDoSubTasks.Update(subTask);
            await db.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            ToDoSubTask subTask = db.ToDoSubTasks.Find(id);
            db.ToDoSubTasks.Remove(subTask);
            await db.SaveChangesAsync();
        }
    }
}
