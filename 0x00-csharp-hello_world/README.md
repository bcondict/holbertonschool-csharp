# 0x00. C# - Hello, World

Here you'll found my first steps about C# and .NET with different kind of task.


#### 0. Initialize new project
Write a Bash script that initializes a new C# project inside a folder titled 0-new_project.

- Use the command dotnet
```
carrie@ubuntu:~/0x00-csharp-hello_world/$ ls
0-initialize_new_project.sh
carrie@ubuntu:~/0x00-csharp-hello_world/$ ./0-initialize_new_project.sh 
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj...
  Restoring packages for /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj...
  Generating MSBuild file /home/carrie/0x00-csharp-hello_world/0-new_project/obj/0-new_project.csproj.nuget.g.props.
  Generating MSBuild file /home/carrie/0x00-csharp-hello_world/0-new_project/obj/0-new_project.csproj.nuget.g.targets.
  Restore completed in 151.49 ms for /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj.


Restore succeeded.

carrie@ubuntu:~/0x00-csharp-hello_world/$ ls
0-initialize_new_project.sh  0-new_project
carrie@ubuntu:~/0x00-csharp-hello_world/$ ls 0-new_project/
0-new_project.csproj  obj  Program.cs
carrie@ubuntu:~/0x00-csharp-hello_world/0-new_project$
```

#### 1.Build new project
Write a Bash script that initializes and builds a new C# project inside a folder titled 1-new_project.

- Use the command dotnet
