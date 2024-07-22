using RealEstate_Depper_Api.Models.DapperContext;
using RealEstate_Depper_Api.Repositories.AppUserRepositories;
using RealEstate_Depper_Api.Repositories.BottomGridRepositories;
using RealEstate_Depper_Api.Repositories.CategoryRepository;
using RealEstate_Depper_Api.Repositories.ContactRepositories;
using RealEstate_Depper_Api.Repositories.EmployeeRepositories;
using RealEstate_Depper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstate_Depper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstate_Depper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories;
using RealEstate_Depper_Api.Repositories.MessageRepositories;
using RealEstate_Depper_Api.Repositories.PopularLocationRepositories;
using RealEstate_Depper_Api.Repositories.ProductImageRepositories;
using RealEstate_Depper_Api.Repositories.ProductRepository;
using RealEstate_Depper_Api.Repositories.PropertyAmenityRepositories;
using RealEstate_Depper_Api.Repositories.ServiceRepository;
using RealEstate_Depper_Api.Repositories.StatisticsRepositories;
using RealEstate_Depper_Api.Repositories.SubFeatureRepositories;
using RealEstate_Depper_Api.Repositories.TestimonialRepository;
using RealEstate_Depper_Api.Repositories.ToDoListRepositories;
using RealEstate_Depper_Api.Repositories.WhoWeAreRepository;

namespace RealEstate_Depper_Api.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddTransient<Context>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();

        }
    }
}
