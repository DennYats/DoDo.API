using AutoMapper;
using DoDo.Application.DTOs.ToDo;
using DoDo.Domain.Entities;

namespace DoDo.Application.Mapping
{
    public class ToDoMapperProfile : Profile
    {
        public ToDoMapperProfile()
        {
            CreateMap<ToDoList, ToDoListDTO>();
            CreateMap<ToDoItem, ToDoItemDTO>()
                .ForMember(dest => dest.Notification,
                            opt => opt.MapFrom(src => (int)src.Notification))
                .ForMember(dest => dest.Priority,
                            opt => opt.MapFrom(src => (int)src.Priority));
            CreateMap<ToDoSubTask, ToDoSubTaskDTO>();
        }
    }
}
