# MYGIT
source code for pah42 submission system
This solution used visual studio 2017 version 15.6.6
The solution includes 6 projects
1. ASP.NET Core MVC web application
2. Web API service application for file generation
3. Web API service application for response load
4. Console application for incoming file parser
5. Test application for unit test
6. Shared application for PowerShell scripts and SSIS package
S
PowerShell script scheudled to run once a day, check files in designated folder, and call console application to load to staging database,
then create a schedule in EDM database, then call SSIS package to load data from staging to EDM

Created two separate projects for heave duty tasks like file generation, and response load, they can be invoked by async call from 
web application

Unit test used Xunit and Moq
