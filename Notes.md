- explain upgrade challenges
- EF6 status - show repo
- System.Data.SqlClient status - list issues
- ErikEJ package history
- present MS package
- present docs page
- demo of upgrade to use Azure SQL and Entra interactive

    [DbConfigurationType(typeof(MicrosoftSqlDbConfiguration))]
    public partial class BloggingContext : DbContext

<add name="BloggingContext" connectionString="Server=tcp:speed-server.database.windows.net,1433;Initial Catalog=eej-free;Authentication=Active Directory Default;Encrypt=True;TrustServerCertificate=False;" providerName="Microsoft.Data.SqlClient" />

We can remove config sections

Move to .NET 8!

Move to PackageReference first (based on experience)

Run upgrade assistant and turn into a .NET Core app!

Remove superflous packages

Fix project file

Inspect app.config

Run and show new row in portal