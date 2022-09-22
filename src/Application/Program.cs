using Domain.Interfaces;
using Domain.Services;
using Infra;
using Infra.Context;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IListingFromCsv, ListingFromCsv>();
        builder.Services.AddScoped<IListingFromCsvService, ListingFromCsvService>();
        builder.Services.AddScoped<IListingFromCsvService, ListingFromCsvService>();
        builder.Services.AddScoped<IListingFromCsvService, ListingFromCsvService>();
        builder.Services.AddScoped<IListingFromCsvService, ListingFromCsvService>();
        builder.Services.AddScoped<ICalendarService, CalendarService>();
        builder.Services.AddScoped<IListingService, ListingService>();
        builder.Services.AddScoped<IReviewService, ReviewService>();

        builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

        builder.Services.AddDbContext<MyContext>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"))
        );

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}