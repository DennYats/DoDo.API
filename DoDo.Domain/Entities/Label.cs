using System.Collections.Generic;

namespace DoDo.Domain.Entities
{
    public class Label
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HexColor { get; set; }
        public int ItemOrder { get; set; }
        public bool IsFavorite { get; set; }


        public string UserId { get; set; }
        public DoDoUser User { get; set; }
        public IEnumerable<ToDoList> ToDoLists { get; set; }
    }
}
