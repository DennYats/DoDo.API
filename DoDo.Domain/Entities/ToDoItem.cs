using DoDo.Domain.Enums;
using System;
using System.Collections.Generic;

namespace DoDo.Domain.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? StartReminder { get; set; }
        public DateTime? FinishReminder { get; set; }
        public Notification Notification { get; set; } = Notification.None;
        public Priority Priority { get; set; } = Priority.None;
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsReccurent { get; set; } = false;
        public DateTime? ReccurentInterval { get; set; }


        public int ParentListId { get; set; }
        public ToDoList ParentList { get; set; }
        public List<ToDoSubTask> SubTasks { get; set; }
    }
}
