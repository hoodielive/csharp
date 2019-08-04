[33mcommit 14a92543a9e4155e80bb2972a9960187e76f9849[m[33m ([m[1;36mHEAD -> [m[1;32mmaster[m[33m, [m[1;31morigin/master[m[33m, [m[1;31morigin/HEAD[m[33m)[m
Author: hoodielive <hoodielive@gmail.com>
Date:   Thu Aug 1 21:32:54 2019 -0400

    csc and mono

[1mdiff --git a/Fascinate/democonsole/Program.cs b/Fascinate/democonsole/Program.cs[m
[1mindex b93cf3a..d08bea7 100644[m
[1m--- a/Fascinate/democonsole/Program.cs[m
[1m+++ b/Fascinate/democonsole/Program.cs[m
[36m@@ -6,7 +6,8 @@[m [mnamespace democonsole[m
     {[m
         static void Main(string[] args)[m
         {[m
[31m-            Console.WriteLine("Fascinate!!");[m
[32m+[m[32m            string message = "Fascinate the World!";[m[41m[m
[32m+[m[32m            Console.WriteLine(message);[m[41m[m
         }[m
     }[m
 }[m
[1mdiff --git a/Fascinate/democonsole/Program.exe b/Fascinate/democonsole/Program.exe[m
[1mindex d859ad8..018e2a2 100644[m
Binary files a/Fascinate/democonsole/Program.exe and b/Fascinate/democonsole/Program.exe differ

[33mcommit bc8c1c386d88d7d622b1ac33ea45f43e7a7616c8[m
Author: hoodielive <hoodielive@gmail.com>
Date:   Thu Aug 1 21:26:12 2019 -0400

    fascinate me c# because its your only chance

[1mdiff --git a/Fascinate/democonsole/Program.cs b/Fascinate/democonsole/Program.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..b93cf3a[m
[1m--- /dev/null[m
[1m+++ b/Fascinate/democonsole/Program.cs[m
[36m@@ -0,0 +1,12 @@[m
[32m+[m[32m﻿using System;[m[41m[m
[32m+[m[41m[m
[32m+[m[32mnamespace democonsole[m[41m[m
[32m+[m[32m{[m[41m[m
[32m+[m[32m    class Program[m[41m[m
[32m+[m[32m    {[m[41m[m
[32m+[m[32m        static void Main(string[] args)[m[41m[m
[32m+[m[32m        {[m[41m[m
[32m+[m[32m            Console.WriteLine("Fascinate!!");[m[41m[m
[32m+[m[32m        }[m[41m[m
[32m+[m[32m    }[m[41m[m
[32m+[m[32m}[m[41m[m
[1mdiff --git a/Fascinate/democonsole/Program.exe b/Fascinate/democonsole/Program.exe[m
[1mnew file mode 100644[m
[1mindex 0000000..d859ad8[m
Binary files /dev/null and b/Fascinate/democonsole/Program.exe differ
[1mdiff --git a/Fascinate/democonsole/democonsole.csproj b/Fascinate/democonsole/democonsole.csproj[m
[1mnew file mode 100644[m
[1mindex 0000000..e5e0e16[m
[1m--- /dev/null[m
[1m+++ b/Fascinate/democonsole/democonsole.csproj[m
[36m@@ -0,0 +1,8 @@[m
[32m+[m[32m<Project Sdk="Microsoft.NET.Sdk">[m[41m[m
[32m+[m[41m[m
[32m+[m[32m  <PropertyGroup>[m[41m[m
[32m+[m[32m    <OutputType>Exe</OutputType>[m[41m[m
[32m+[m[32m    <TargetFramework>netcoreapp2.1</TargetFramework>[m[41m[m
[32m+[m[32m  </PropertyGroup>[m[41m[m
[32m+[m[41m[m
[32m+[m[32m</Project>[m[41m[m
