using MassTransit;
using Microsoft.EntityFrameworkCore;
using PaiementManagementApi.Consumers;
using PaiementManagementApi.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


//builder.Services.AddMassTransit(options => {
//    options.UsingRabbitMq((context, cfg) => {
//        cfg.Host(new Uri("rabbitmq://localhost:4001"), h => {
//            h.Username("guest");
//            h.Password("guest");
//        });

//    });
//});

builder.Services.AddMassTransit(x => {
    x.AddConsumer<AbonnementCreatedConsumer>();
    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host(new Uri("rabbitmq://localhost:4001"), h => {
            h.Username("guest");
            h.Password("guest");
        });
        cfg.ReceiveEndpoint("event-listener", e =>
        {
            e.ConfigureConsumer<AbonnementCreatedConsumer>(context);
        });
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
