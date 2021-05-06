using AutoMapper;
using DoDo.Application.DTOs.ToDo;
using DoDo.Application.IServices;
using DoDo.Domain.Entities;
using DoDo.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoDo.Application.Services.ToDo
{
    public class ToDoListService : IToDoListService
    {
        private DoDoContext db;
        private IMapper mapper;
        private UserManager<DoDoUser> userManager;

        public ToDoListService(DoDoContext context, IMapper mapper, UserManager<DoDoUser> userManager)
        {
            this.db = context;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<ToDoListDTO>> GetListsAsync(string userId)
        {
            var listOfLists = await db.ToDoLists.Where(l => l.UserId == userId).ToListAsync();

            var dtoListOfLists = mapper.Map<IEnumerable<ToDoListDTO>>(listOfLists);

            return dtoListOfLists;
        }

        public async Task<ToDoListDTO> GetListByIdAsync(int id)
        {
            var list = await db.ToDoLists.FindAsync(id);

            var dtoList = mapper.Map<ToDoListDTO>(list);

            return dtoList;
        }

        public async Task Create(ToDoList list)
        {
            db.ToDoLists.Add(list);
            await db.SaveChangesAsync();
        }

        public async Task Update(ToDoList list)
        {
            db.ToDoLists.Update(list);
            await db.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            ToDoList list = db.ToDoLists.Find(id);
            db.ToDoLists.Remove(list);
            await db.SaveChangesAsync();
        }
    }
}
