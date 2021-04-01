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
        public DateTime? StartReminder { 
            get => StartDate;
            set
            {
                if (this.Notification == Notification.Double ||
                    this.Notification == Notification.SingleStart) value = StartDate;
            }
        }
        public DateTime? FinishReminder
        {
            get => FinishDate;
            set
            {
                if (this.Notification == Notification.Double ||
                    this.Notification == Notification.SingleFinish) value = FinishDate;
            }
        }
        public DateTime? RepeatIn { get; set; }
        public Notification Notification { get; set; } = Notification.None;
        public Priority Priority { get; set; } = Priority.None;
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public int ParentListId { get; set; }
        public ToDoList ParentList { get; set; }
        public List<ToDoSubTask> SubTasks { get; set; }
    }
}
