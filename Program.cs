using Microsoft.EntityFrameworkCore;
using ProductManagerAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // سطر مهم
builder.Services.AddSwaggerGen(); // سطر مهم لتشغيل الصفحة

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // تفعيل Swagger
    app.UseSwaggerUI(); // تفعيل واجهة المستخدم
}
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting(); // ضيف السطر ده لو مش موجود
app.MapControllers();
app.Run();