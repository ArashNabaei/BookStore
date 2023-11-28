using Application.Services.Write.Authors;
using Application.Services.Write.Books;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Application.Services.Read.Customers;
using Application.Services.Read.Authors;
using System.Reflection;
using Application.Services.Read.Books;
using Application.Repositories.Command.Books.Create;
using Infrastructure;
using Infrastructure.Repositories.Read.Authors;
using Infrastructure.Repositories.Read.Books;
using Infrastructure.Repositories.Read.Customers;
using Infrastructure.Repositories.Write.Authors;
using Infrastructure.Repositories.Write.Customers;
using Infrastructure.Repositories.Write.Books;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repositories.Read.Publishers;
using Infrastructure.Repositories.Write.Publishers;
using Application.Services.Read.Publishers;
using Application.Services.Write.Publishers;
using Application.Services.Write.Customers;

namespace BookStore
{
    public static class DependencyInjectionConfig
    {
        public static void ConfigureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(Assembly.GetAssembly(typeof(CreateBookCommandHandler)));
            });

            var connectionString = configuration.GetConnectionString("MyDatabaseConnection");
            services.AddDbContext<EFConnection>(options =>
                options.UseSqlServer(connectionString, b => b.MigrationsAssembly("BookStore")));

            services.AddScoped<DapperConnection>();

            services.AddScoped<IReadAuthorRepository, ReadAuthorRepository>();
            services.AddScoped<IReadBookRepository, ReadBookRepository>();
            services.AddScoped<IReadCustomerRepository, ReadCustomerRepository>();
            services.AddScoped<IReadPublisherRepository, ReadPublisherRepository>();

            services.AddScoped<IWriteAuthorRepository, WriteAuthorRepository>();
            services.AddScoped<IWriteBookRepository, WriteBookRepository>();
            services.AddScoped<IWriteCustomerRepository, WriteCustomerRepository>();
            services.AddScoped<IWritePublisherRepository, WritePublisherRepository>();

            services.AddScoped<IReadAuthorService, ReadAuthorService>();
            services.AddScoped<IReadBookService, ReadBookService>();
            services.AddScoped<IReadCustomerService, ReadCustomerService>();
            services.AddScoped<IReadPublisherService, ReadPublisherService>();

            services.AddScoped<IWriteAuthorService, WriteAuthorService>();
            services.AddScoped<IWriteBookService, WriteBookService>();
            services.AddScoped<IWriteCustomerService, WriteCustomerService>();
            services.AddScoped<IWritePublisherService, WritePublisherService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
