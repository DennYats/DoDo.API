using DoDo.Application.DTOs.ToDo;
using DoDo.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoDo.Application.IServices
{
    public interface IToDoSubTaskService
    {
        Task<IEnumerable<ToDoSubTaskDTO>> GetSubTasksAsync();
        Task<ToDoSubTaskDTO> GetSubTaskByIdAsync(int id);
        Task Create(ToDoSubTask list);
        Task Update(ToDoSubTask list);
        Task Remove(int id);
    }
}
