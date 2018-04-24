#==========================================================================================================================================================
#Create on: 4/6/2018
#Create by: Michael Yan
#Script name: Pharmacy.ps1
#Description: 1) read pharmacy input file path and sql connection string from the same config file used by parser 
#             2) check if there are input files injected to designated folder
#             3) run parser exe to load them to edm staging tables
#             4) move input files to achive folder
#             5) create a pharmacy schedule in edm, pharmacy source id here specified as 2, please check the actual value
#             6) run pharmacy SSIS package, load pharmacy data to edm cache for export
#
#Revisions:
#Date			Developer					Description
#
#==========================================================================================================================================================

$currentDirectory = [IO.Path]::GetDirectoryName($MyInvocation.MyCommand.Path)
$appConfigFile = [IO.Path]::Combine($currentDirectory, 'NCPDP_Parser.exe.config')
$appConfig = New-Object XML
$appConfig.Load($appConfigFile)
$filePath=''
foreach($appSetting in $appConfig.configuration.appSettings.add)
{
    if ($appSetting.key -eq 'FilePath')
    {
        $filePath=$appSetting.value
        break
    }
}
if ($filePath -eq '') 
{
    exit
}
$connectionString=''
foreach($cn in $appConfig.configuration.connectionStrings.add)
{
    if ($cn.name -eq 'CoreEDMCustomDBEntities')
    {
        $connectionString=$cn.connectionString
        break
    }
}
if ($connectionString -eq '') 
{
    exit
}
$directoryInfo = Get-ChildItem $filePath
if ($directoryInfo.count -eq 0)
{
    exit
}
$exefile = [IO.Path]::Combine($currentDirectory,'NCPDP_Parser.exe')
Start-Process -FilePath $exefile -Wait
$destinationFolder=$FilePath.replace('Input','Archive')
if(!(Test-Path -Path $destinationFolder )){
  New-Item -ItemType directory -Path $destinationFolder
}
Get-ChildItem $FilePath | Move-Item -Destination $destinationFolder

$connectionString=$connectionString.replace('Custom','')
$sqlConnection = New-Object System.Data.SqlClient.SqlConnection
$sqlConnection.ConnectionString = $connectionString
$sqlConnection.Open()
$sqlCommand = New-Object System.Data.SqlClient.SqlCommand
$sqlCommand.Connection = $sqlConnection
$sqlCommand.CommandText = "insert into encounter.schedule values(1,getdate(),2,2,'pharm_autoload_'+convert(varchar(6),getdate(),12),getdate(),getdate(),null,null,0,1,1,null,2,0,0);"+
"insert into encounter.ScheduleSource values (1,getdate(),scope_identity(),2,'Pending');"
$sqlCommand.ExecuteNonQuery()
$sqlConnection.Close()

$executable = "dtexec.exe"
$arguments = "/File C:\EDM\Pharmacy_NCPDP.dtsx /ConfigFile C:\EDM\Pharmacy_NCPDP.dtsconfig"
Start-Process $executable $arguments -Wait
