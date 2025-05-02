We have 3 projects along with 3 Powershell scripts to help in rebuilding the database. 
The first project is DataAccess which was taken from the in class example.
The second project is PotionShopDatabase. This contains the files DataDelegates, Interfaces, Models, Repositories, and SQL.
The DataDelegates folder contains the subfolders for each of the tables and an aggregate folder. In each of these folders is the delegate helper methods.
The Interfaces and Repositories folders contain the interfaces and repositories for each of the tables.
The models folder helps construct the object for each table.
The Sql folder contains the subfolders Data, Procedures, Schemas, and tables
  Data contains the sql script to initially populate the tables.
  Procedures contains the subfolders for each table and aggregate functions and is the sql for each procedure.
  Schemas creates the schema for PotionShop in sql
  Tables contains the sql used to create all tables along with a script to drop all tables
The last project is our SQLUserInterface. This contains the forms for all of the tables and has the c# to populate the windows forms with data from the sql
