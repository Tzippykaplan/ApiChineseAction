using Reposetories;
using Repository;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IGiftsReposetory, GiftsReposetory>();
builder.Services.AddScoped<IGiftsService, GiftsService>();
builder.Services.AddScoped<IDonorsReposetory,DonorsReposetory>();
builder.Services.AddScoped<IDonorsService, DonorsService>();
builder.Services.AddScoped<IUserReposetory, UserReposetory>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRaffleReposetory, RaffleReposetory>();
builder.Services.AddScoped<IRaffleService, RaffleService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Origins", policy =>
    {
        policy.WithOrigins("http://localhost:4200", "http://localhost:50417/", "http://localhost:5000", "http://localhost:62529/")
              .AllowAnyHeader()
              .AllowAnyMethod()
             .AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseCors("Origins");

app.UseAuthorization();

app.MapControllers();

app.Run();

