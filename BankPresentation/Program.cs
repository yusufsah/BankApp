using Entity;
using Repository;
using Repository.Abstract;
using Repository.Concrete;
using Serivce;
using Serivce.Abrstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(); // bunu ekliyoruz yoksa açýlmaz  unutma
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
	     // bunu ekliyoruz yoksa açýlmaz  unutma


builder.Services.AddScoped<ICustomerAccountProcessDal,EfCustomerAccountProcess>(); // repository
builder.Services.AddScoped<ICustomerAccountDal,EfCustomerAccount>();

builder.Services.AddScoped<ICustomerAccountProcessService, CustomerAccountProcessManager>(); // service
builder.Services.AddScoped<ICustomerAccountService,CustomerAccountManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
