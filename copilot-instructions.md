# Project Overview

This project is a web site of a school. It is built using ASP.NET Core Razor Pages and uses Postgres as database.

## Project Structure and Conventions

- This is an **ASP.NET Core Razor Pages** application (not MVC Controllers or Blazor).
- Follows standard ASP.NET Core Razor Pages structure.
- UI is built using **Tailwind CSS** and FlyonUI.
- JavaScript is vanilla ES modules (no React, Vue, Angular).
- All views are `.cshtml` Razor Pages using `_Layout.cshtml` for shared layout.

## Libraries and Frameworks

- HTML, CSS, JavaScript, Tailwind CSS andd FlyonUI for the frontend.
- .NET for the backend.
- Postgres for data storage.

## Coding Standards

- Use `@page` directive for page routing.
- Use `PageModel` classes for server logic (`.cshtml.cs` files).
- Avoid MVC `Controller`/`View` patterns unless explicitly requested.
- Keep markup clean: prefer semantic HTML tags.
- Avoid inline styles unless necessary.
- `_Layout.cshtml` contains `<head>`, `<body>` with a header/navbar and `@RenderBody()`.
- Use `Partial` or `ViewComponent` for reusable UI blocks (e.g., navbar, footer).
- Scripts go at the bottom of `_Layout.cshtml` unless page-specific.
- Tailwind configuration file: `tailwind.config.js`
- Use `asp-for`, `asp-page`, and `asp-route-*` tag helpers where applicable.
- Use `Model` properties in `.cshtml` instead of manually passing `ViewData`.
- Use `<form method="post">` with Razor tag helpers for model binding.
- Include antiforgery token: `@Html.AntiForgeryToken()`.
- Encode all user-generated output with `@` (Razor default HTML encoding).
- Validate all input in `OnPostAsync` methods.
- Use var in C# code.

## UI guidelines

- Application should have a modern and clean design.
- All pages should be responsive and mobile-friendly.