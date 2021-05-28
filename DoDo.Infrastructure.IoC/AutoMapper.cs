using AutoMapper;
using DoDo.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace DoDo.Infrastructure.IoC
{
    public static class AutoMapper
    {
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
