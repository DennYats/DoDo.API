using AutoMapper;
using DoDo.Application.Mapping;
using DoDo.Application.Services.Interfaces;
using DoDo.Application.Services.ToDo;
using Microsoft.Extensions.DependencyInjection;

namespace DoDo.Infrastructure.IoC
{
    public static class ServicesExtensions
    {
        public static void AddToDoServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoListService, ToDoListService>();

            services.AddScoped<IToDoItemService, ToDoItemService>();

            services.AddScoped<IToDoSubTaskService, ToDoSubTaskService>();
        }
        
        public static void AddAutoMapperImplemented(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ToDoMapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
