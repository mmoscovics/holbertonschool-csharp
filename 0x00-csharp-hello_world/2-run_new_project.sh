#!/usr/bin/env bash
# Initializes and buils a new C# project in titled folder
dotnet new console -n 2-new_project
dotnet build 2-new_project
dotnet run -p 2-new_project
