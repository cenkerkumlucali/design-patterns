using Example.Concrete;
using Example.Creator;
using Example.Factory.Concrete;

DatabaseCreator creator = new();
Database database = creator.Create(new OracleDatabaseFactory());
Console.WriteLine(database.Connection.ConnectionString);

