using System;
using System.Collections.Generic;

namespace DoDo.Domain.Entities
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string UserId { get; set; }
        public DoDoUser User { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }
    }
}
