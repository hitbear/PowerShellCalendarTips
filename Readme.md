# PowerShellTips

## Install pwsh on Linux (Ubuntu)

Download the Linux Powershell .deb package and install it.
Start the programm with pwsh. 

## Create an ExchangeOnlinePowerShell Session

Type in the following commands:
    Install-Module -Name PSWSMan

    Install-Module -Name ExchangeOnlineManagement

    Import-Module ExchangeOnlineManagement

    Connect-ExchangeOnline -UserPrincipalName admin.martin.schmid@ms-ortungstechnik.de

## Manage Calendar Credentials

See the CalendarTips.cs file