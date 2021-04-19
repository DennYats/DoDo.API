using System.Collections.Generic;

namespace DoDo.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Icon { get; set; }


        public string UserId { get; set; }
        public DoDoUser User { get; set; }
        public IEnumerable<ToDoList> ToDoLists { get; set; }
    }
}
