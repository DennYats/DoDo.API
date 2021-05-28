using DoDo.Application.IServices;
using DoDo.Application.Services.ToDo;
using Microsoft.Extensions.DependencyInjection;

namespace DoDo.Infrastructure.IoC
{
    public static partial class ToDoServices
    {
        public static void AddToDoServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoListService, ToDoListService>();

            services.AddScoped<IToDoItemService, ToDoItemService>();

            services.AddScoped<IToDoSubTaskService, ToDoSubTaskService>();
        }
    }
}
