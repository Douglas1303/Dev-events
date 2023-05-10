using dev_events_api.Configuration;
using dev_events_domain.Interfaces;
using dev_events_ioc;
using dev_events_repository.Repository;
using dev_events_repository.Repository.UnitOfWork;
using dev_events_service.Interface;
using dev_events_service.Service;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();
builder.Services.AddFluentValidationConfiguration();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.RegisterService();

var app = builder.Build();

app.UseMiddleware(typeof(ErrorMiddleware));

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
