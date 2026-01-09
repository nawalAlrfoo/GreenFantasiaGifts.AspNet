using Microsoft.EntityFrameworkCore;
using GreenFantasiaGifts011.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. إضافة الخدمات (Services)
builder.Services.AddControllersWithViews();

// تعريف قاعدة البيانات
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    sqlOptions => sqlOptions.EnableRetryOnFailure())
    .ConfigureWarnings(w => w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning))
);

// إعدادات الجلسة (Session) - تم دمجها وتصحيحها
builder.Services.AddDistributedMemoryCache(); // ضروري لتخزين بيانات الجلسة في الذاكرة
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // وقت تنتهي فيه السلة عند الخمول
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor(); // مهم للوصول للـ Session من داخل الـ Controller

// نظام التوثيق (Authentication)
builder.Services.AddAuthentication("CookieAuth")
    .AddCookie("CookieAuth", config =>
    {
        config.Cookie.Name = "UserLoginCookie";
        config.LoginPath = "/Account/Login";
    });

// --- بناء التطبيق ---
var app = builder.Build();

// 2. إعدادات الـ Middleware (الترتيب هنا حاسم جداً)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// تفعيل الجلسة - يجب أن يكون بعد UseRouting وقبل UseAuthentication
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

// إعداد المسارات (Routing)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();