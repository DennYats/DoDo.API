using System;

namespace DoDo.Domain.Entities
{
    public class ToDoSubTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int ParentItemId { get; set; }
        public ToDoItem ParentItem { get; set; }
    }
}
