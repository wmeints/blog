# Willem's Fizzy Logic Blog

Welcome to my personal blog source files. This is the new engine I'm working on,
that will run my blog in the coming few months. It's based on .NET 5 and uses
Blazor for the admin section of the website.

## System requirements

* .NET 5 SDK RC1
* Visual Studio Code
* Postgres

## Getting started

* `docker run -d -p 5432:5432 -e POSTGRES_DATABASE=fizzylogic_dev -e POSTGRES_PASSWORD=<Your password> postgres`
* `git clone https://github.com/wmeints/blog`
* `dotnet tool restore`
* `cd blog/src/Server`
* `dotnet user-secrets set "ConnectionStrings:DefaultDatabase" "host=localhost;database=fizzylogic_dev;username=postgres;password=<Your password>"`
* `dotnet ef database update`
* `dotnet run`

## How to use this project for your own website

Please make sure to update the theming of the razor pages in the `src/Server` 
project. You can find the accompanying styles in `Stylesheets/site.scss`.

You can leave the `Pages/Admin.cshtml` as-is, as this page serves as the host
for the admin section of the website. 

## Contributing

Feel free to submit bug reports and feature requests. I'm happy to help out.
Please make sure to create an issue before submitting a pull request.