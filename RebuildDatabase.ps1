Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "nathanproctor"			#PLEASE CHANGE THIS TO YOUR NAME, YOU NEED INDIVIDUALIZED DATABASES
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\DropDatabase.ps1" -Database $Database
& ".\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\DropTables.sql"


<# WE WILL HAVE TO CHANGE ALL OF THESE TO WHATEVER WE ARE GOING TO HAVE OURS BE, THIS IS NOT CORRECT AS OF NOW #>
Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Schemas\PotionShop.sql" #I believe this is right

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.Employee.sql" #yes
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.Store.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.StoreItem.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\PotionShop.CreateEmployee.sql"
<#
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Person.RetrievePersons.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Person.FetchPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Person.GetPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Person.SavePersonAddress.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Person.RetrieveAddressesForPerson.sql"
#>

#Dont think we need this because i think this just replaces the 1, 2, 3, 4 with the home, apartment, etc..
<#
Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Data\Person.AddressType.sql"
#>
Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
