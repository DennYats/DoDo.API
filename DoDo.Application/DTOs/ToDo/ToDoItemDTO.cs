using System;

namespace DoDo.Application.DTOs.ToDo
{
    public class ToDoItemDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? StartReminder { get; set; }
        public DateTime? FinishReminder { get; set; }
        public DateTime? RepeatIn { get; set; }
        public int Notification { get; set; }
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }

        public int ParentListId { get; set; }
    }
}
