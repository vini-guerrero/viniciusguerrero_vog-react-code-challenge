using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.Services;
using VogCodeChallenge.Data;
using VogCodeChallenge.Data.Repository;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddTransient<IFetchDepartmentDetails, FetchDepartmentDetails>();
builder.Services.AddTransient<IFetchEmployeeDetails, FetchEmployeeDetails>();
builder.Services.AddTransient<IDepEmpRepository, DepEmpRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddSwaggerGen(options => {
options.SwaggerDoc("v1",
    new OpenApiInfo
    {
        Title = "VOG Code Challenge",
        Description = "Department and Employee API",
        Contact = new OpenApiContact
        {
            Name = "Vinicius Guerrero",
            Email = "vini.ts.guerrero@gmail.com",
            Url = new Uri("https://github.com/vini-guerrero"),
        },
        Version = "v1"
    });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.MapControllers();

app.Run();
