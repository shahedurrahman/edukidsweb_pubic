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

# Instructions for Using the FLYONUI MCP SERVER

These instructions are essential for ensuring accurate and helpful responses when interacting with the FLYONUI MCP SERVER. 
Follow these guidelines strictly when working with FlyonUI MCP server.

## Types of Tools for Interacting with the MCP Server

There are three primary tools you’ll use to interact with the MCP Server:

1. **`/cui`**: For creating user interfaces by using existing FlyonUI components.
2. **`/iui`**: For creating user interfaces inspired by existing FlyonUI components.
3. **`/rui`**: For refining or improving user interfaces.

## Steps to Follow

* **Determine the Right Tool**: If the user hasn’t specified which tool to use, carefully analyze their request and choose the appropriate tool (`/cui`, `/iui`, or `/rui`).

* **Follow Instructions strictly**: Once you choose the tool, **strictly follow all instructions** provided by the MCP Server.

  * Do not skip any steps.
  * Ensure the workflow is followed exactly as outlined.
  * Log each step as you complete it.
  * **Avoid Shortcuts**: Do not take shortcuts or rush through the process. Each step is crucial for achieving the desired outcome.

## Key Points to Remember:

1. Always follow **all** the instructions from the MCP Server step by step.
2. **Do not skip** or take shortcuts in the process.
3. Stick to the **entire workflow** rather than rushing to implementation.