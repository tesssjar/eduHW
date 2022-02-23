using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using BLL;
using DAL;
using UI;

namespace Program
{
    class Program
    {
        public void Main()
        {
            Application application = ConfigureServices(new ServiceCollection()).BuildServiceProvider().GetRequiredService<Application>();

            application.Run();
        }

        public static IServiceCollection ConfigureServices(IServiceCollection services) 
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            services.AddTransient<IRepository, Repository<Student>>(provider => new Repository<Student>(path));
            services.AddTransient<IStudentsService, StudentsService>();
            services.AddTransient<Application>();
            return services;
        }
    }
}