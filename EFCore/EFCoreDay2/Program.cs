/*
cd "/mnt/windows/diff/projects/iti DotNet/EFCore/EFCoreDay2_2"
install packages (sqlserver, tools, design)
efcpt "Server=localhost,{}; Database=Airline; user id={}; Password={}; TrustServerCertificate=True" mssql 
edit the .json file as u want .. edit tables by {"name": "[dbo].[Employee_Qualification]", "exclude":true} or
                exclude all then false it.
"file-layout": {"output-dbcontext-path": "Context", "output-path": "Models"},
every edit use efcpt.... again
*/


// Code first from exist DB