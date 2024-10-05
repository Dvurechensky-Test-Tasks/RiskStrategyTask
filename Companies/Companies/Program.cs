using Companies.Services;
using Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Middleware;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
// Configure Database
builder.Services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlite(connection));
//������������ �������� ���
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = _ => false; //�������� �������� �� �����������
    options.MinimumSameSitePolicy = SameSiteMode.None; //������ ��������������� �������� cookie
    options.Secure = CookieSecurePolicy.Always; //����� cookie ������ ���� �����������
});
builder.Services.AddSession(options =>//������������� ��������� ������
{
    options.Cookie.Name = AuthExt.NameSessionCookie; //������ �������� ���� ������
    options.IdleTimeout = TimeSpan.FromMinutes(10); //����� �������� ������ ��� �����������
    options.Cookie.HttpOnly = true; //������ ������ � �������
    options.Cookie.IsEssential = true; //����� �� ���� cookie ��� ������ (true-�������� �������� �������� ������������)
});
builder.Services.AddAntiforgery(options =>//��������� ������ ������ �������� ��������
{
    options.HeaderName = "X-CSRF-TOKEN";
});

builder.Services.AddControllersWithViews();// Add services to the container.

builder.Services.AddCors(); //��������� �������� CORS

//��������� Swagger
builder.Services.AddSwaggerGen(options =>
{
    //����� ����� Swagger
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "1.0.1",
        Title = "REST API Strategy Risk",
        Description = "��������� �������",
        Contact = new OpenApiContact
        {
            Name = "Nikolay",
            Email = "dvurechensky_pro@mail.ru",
        }
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "������������");
    c.RoutePrefix = "docs";
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
} 
else
{
    //app.UseHttpsRedirection();
}

app.UseStaticFiles();

app.UseCookiePolicy(); //������������ �������� ����

app.UseSession(); //������������ ������

app.UseRouting();

app.UseMiddleware<AntiforgeryMiddleware>(); //���������� ������ ������ �������� ��������

app.UseAuthorization();

app.UseCors(options =>//���������� CORS � ����� ������
{
    options.SetIsOriginAllowed(_ => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
});

#pragma warning disable ASP0014
app.UseEndpoints(endpoints =>//�������������
{
    endpoints.MapDefaultControllerRoute();//��������� ������
    endpoints.MapControllers();//��� ������������� ���� ������������ ��������
});
#pragma warning restore ASP0014

app.Run();
