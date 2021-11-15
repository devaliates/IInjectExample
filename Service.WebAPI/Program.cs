using Data.Abstract;
using Data.Mssql;
using Data.Services;
using Data.Services.Abstract;

using Microsoft.AspNetCore.Authentication.Certificate;

using Service.WebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddAuthentication(
//        CertificateAuthenticationDefaults.AuthenticationScheme)
//        .AddCertificate();
//builder.Services.AddCors();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Service.WebAPI", Version = "v1" });
});
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

builder.Services
    .AddTransient(typeof(IBaseData<>), typeof(BaseData<>))
    .AddSingleton<IKisiService, KisiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Service.WebAPI v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();
//app.UseCors(c => { c.AllowAnyOrigin(); c.AllowAnyHeader(); c.AllowAnyMethod(); });

app.MapControllers();


app.Run();