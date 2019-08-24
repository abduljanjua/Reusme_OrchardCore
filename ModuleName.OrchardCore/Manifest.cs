using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "ModuleName.OrchardCore",
    Author = "Abdul Raheem",
    Website = "https://orchardproject.net",
    Version = "0.0.1",
    Description = "ModuleName.OrchardCore",
    Dependencies = new[] { "OrchardCore.Contents" },
    Category = "Content Management"
)]
