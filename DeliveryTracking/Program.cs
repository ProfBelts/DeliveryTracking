
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddWebOptimizer(pipeline =>
{
    pipeline.AddCssBundle("css/bundle.css", "css/site.css", "css/**/*.css");
});

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddWebOptimizer(minifyJavaScript: false, minifyCss: false);
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseWebOptimizer();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();