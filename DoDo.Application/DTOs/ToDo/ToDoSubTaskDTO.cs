namespace DoDo.Application.DTOs.ToDo
{
    public class ToDoSubTaskDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public int ParentItemId { get; set; }
    }
}
