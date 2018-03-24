using AutoMapper;

namespace AutomapperUnitTesting.Converters.Automapper
{
    public abstract class AutomapperProfileTestBase<T> where T : Profile, new()
    {
        public IMapper InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<T>();
            });
            return config.CreateMapper();
        }

        protected IMapper Mapper => InitializeMapper();
    }
}
