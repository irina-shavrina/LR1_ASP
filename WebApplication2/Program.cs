var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

Company company = new();

company.CompanyName = "My first company";

Random random = new Random();

int randValue = random.Next(101);

app.MapGet("/", () => company.CompanyName +"\nRandom number = " + randValue);

app.Run();