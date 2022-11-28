#!/usr/bin/env bash
# initializes and buids a new c# project inside a folder 1-new_project

dotnet new console -lang c# -o 1-new_project
dotnet build 1-new_project
