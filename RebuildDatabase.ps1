Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "nathanproctor"
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
Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\DropTables.sql"


<# WE WILL HAVE TO CHANGE ALL OF THESE TO WHATEVER WE ARE GOING TO HAVE OURS BE, THIS IS NOT CORRECT AS OF NOW #>
Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Schemas\PotionShop.sql" #I believe this is right

Write-Host "Creating tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.Employee.sql" #yes
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.Store.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.Employee.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.Order.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.PotionType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.Item.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.StoreItem.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Tables\PotionShop.OrderStoreItem.sql"

Write-Host "Stored procedures..."
#Employee Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Employee\PotionShop.CreateEmployee.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Employee\PotionShop.GetAllEmployees.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Employee\PotionShop.DeleteEmployee.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Employee\PotionShop.EditEmployeeHours.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Employee\PotionShop.EditEmployeeGoldStars.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Employee\PotionShop.EditEmployeePosition.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Employee\PotionShop.EditEmployeeSalary.sql"
#Store Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Store\PotionShop.CreateStore.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Store\PotionShop.GetAllStores.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Store\PotionShop.GetCoolestStores.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Store\PotionShop.GetMonthlyRankOfStoresByProfit.sql"
#StoreItem Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\StoreItem\PotionShop.GetAllStoreItems.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\StoreItem\PotionShop.CreateStoreItem.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\StoreItem\PotionShop.DeleteStoreItem.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\StoreItem\PotionShop.EditStoreItemQuantity.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\StoreItem\PotionShop.EditStoreItemUnitListPrice.sql"
#Order Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Order\PotionShop.GetAllOrders.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Order\PotionShop.CreateOrder.sql"
#Item Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Item\PotionShop.GetAllItems.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Item\PotionShop.CreateItem.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Item\PotionShop.DeleteItem.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\Item\PotionShop.EditItemPrice.sql"
#OrderStoreItem Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\OrderStoreItem\PotionShop.GetAllOrderStoreItems.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Procedures\OrderStoreItem\PotionShop.CreateOrderStoreItem.sql"
Write-Host "Inserting data..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PotionShopDatabase\Sql\Data\PotionShop.PotionType.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
