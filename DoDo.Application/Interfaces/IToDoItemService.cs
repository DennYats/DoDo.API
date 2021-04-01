using DoDo.Application.DTOs.ToDo;
using DoDo.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoDo.Application.Services.Interfaces
{
    public interface IToDoItemService
    {
        Task<IEnumerable<ToDoItemDTO>> GetItemsAsync();
        Task<ToDoItemDTO> GetItemByIdAsync(int id);
        Task Create(ToDoItem item);
        Task Update(ToDoItem item);
        Task Remove(int id);
    }
}
