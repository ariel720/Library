
1. setting up the project
https://www.youtube.com/watch?v=WTVcLFTgDqs&list=PL_26RdF10__CfUpCEnXeB0zAH3MxFNgSC&index=3&t=2480s

Asp.net web app Core->MVC pattern

1)install package thru Nuget package manager
 - EFcore / EFcore.sql / EFcore.Tools
2) create DB : gearhost

3)Create models
 - DBcontext file : add all the table model files
 - Models(tables) : * Don't forget to add Id

4) Add "services.AddDbContext" under ConfigureServices method In Startup.cs

5) NugetPackage Command
 - Add-Migration -Context MusicStoreContext Migration1 (create migration file)
 - Update-Database -Context MusicStoreContext (create table in the database)

* lazy load : 

6) push it github
 - File : add to source control-> team Explorer -> Sync 
(Reference : https://github.com/github/VisualStudio/blob/master/docs/using/publishing-an-existing-project-to-github.md)
