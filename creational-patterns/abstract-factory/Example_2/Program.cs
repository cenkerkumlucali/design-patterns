using Example_2.Concrete;
using Example_2.Creator;
using Example_2.Factory.Concrete;

DatabaseCreator creator = new DatabaseCreator();
Database msSql = creator.Create(new MsSqlDatabaseFactory());
Database mySql = creator.Create(new MySqlDatabaseFactory());
