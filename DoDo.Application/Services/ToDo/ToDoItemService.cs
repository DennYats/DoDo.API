using AutoMapper;
using DoDo.Application.DTOs.ToDo;
using DoDo.Application.IServices;
using DoDo.Domain.Entities;
using DoDo.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoDo.Application.Services.ToDo
{
    public class ToDoItemService : IToDoItemService
    {
        private DoDoContext db;
        private IMapper mapper;

        public ToDoItemService(DoDoContext context, IMapper mapper)
        {
            this.db = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ToDoItemDTO>> GetItemsAsync()
        {
            var listOfItems = await db.ToDoItems.ToListAsync();

            var dtoListOfItems = mapper.Map<IEnumerable<ToDoItemDTO>>(listOfItems);

            return dtoListOfItems;
        }

        public async Task<ToDoItemDTO> GetItemByIdAsync(int id)
        {
            var item = await db.ToDoItems.FindAsync(id);

            var dtoItem = mapper.Map<ToDoItemDTO>(item);

            return dtoItem;
        }

        public async Task Create(ToDoItem item)
        {
            db.ToDoItems.Add(item);
            await db.SaveChangesAsync();
        }

        public async Task Update(ToDoItem item)
        {
            db.ToDoItems.Update(item);
            await db.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            ToDoItem item = db.ToDoItems.Find(id);
            db.ToDoItems.Remove(item);
            await db.SaveChangesAsync();
        }
    }
}
