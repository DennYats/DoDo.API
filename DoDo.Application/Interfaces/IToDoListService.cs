using DoDo.Application.DTOs.ToDo;
using DoDo.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoDo.Application.Services.Interfaces
{
    public interface IToDoListService
    {
        Task<IEnumerable<ToDoListDTO>> GetListsAsync(string userId);
        Task<ToDoListDTO> GetListByIdAsync(int id);
        Task Create(ToDoList list);
        Task Update(ToDoList list);
        Task Remove(int id);
    }
}
