using DependencyInjectionWithMultipleImplementations.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


builder.Services.AddScoped<ICRUDRepository, CRUDRepositoryWithMongoDB>();
builder.Services.AddScoped<ICRUDRepository, CRUDRepositoryWithMySQL>();
builder.Services.AddScoped<ICRUDRepository, CRUDRepositoryWithSQLServer>();


//builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

builder.Services.AddSingleton<CRUDRepositoryWithMySQL>();
builder.Services.AddSingleton<CRUDRepositoryWithSQLServer>();
builder.Services.AddSingleton<CRUDRepositoryWithMongoDB>();


builder.Services.AddTransient<Func<int, ICRUDRepository>>(serviceProvider => key =>
{
    switch (key)
    {
        case 1:
            return serviceProvider.GetService<CRUDRepositoryWithMySQL>();
        case 2:
            return serviceProvider.GetService<CRUDRepositoryWithSQLServer>();
        default:
            return serviceProvider.GetService<CRUDRepositoryWithMongoDB>();
    }
});


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGet( "/", () =>  "Hello World!"); 

app.Run();

/*var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();*/
 