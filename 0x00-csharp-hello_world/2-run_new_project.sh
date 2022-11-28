#!/usr/bin/env bash
# initializes, buids and run a new c# project inside a folder 2-new_project

dotnet new console -lang c# -o 2-new_project
dotnet build 2-new_project
dotnet run --project 2-new_project
