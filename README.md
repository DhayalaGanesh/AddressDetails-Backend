# AddressDetails-Backend

For setting up the DB, copy paste the following command line to the package manager console in VS2019
Scaffold-DbContext -Connection Name=DatabaseConnection Microsoft.EntityFrameworkCore.SqlServer -Project AddressDetails.DB.EF -OutputDir Models -force


To hit the api correctly, mention the Backend URL in apiUrl property of environment variable in environment.ts file
To get the domain, run the backend API and get the base url of the backend and copy paste it to the above mentioned location.


