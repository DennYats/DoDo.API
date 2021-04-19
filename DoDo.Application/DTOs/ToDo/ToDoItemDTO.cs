using System;
using DoDo.Domain.Enums;

namespace DoDo.Application.DTOs.ToDo
{
    public class ToDoItemDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? StartReminder
        {
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
        public Notification Notification { get; set; }
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }

        public int ParentListId { get; set; }
    }
}
