$messtechniker = ('name.name@tenant.com:\calendar', 'name.name@tenant.com:\Kalender')

$bueroteam = ('name.name@tenant.com', 'name.name@tenant.com')
// For the actual names look into Names.cs

foreach ($techniker in $messtechniker){
    echo $techniker; 
    Get-MailboxFolderPermission -Identity $techniker | select User,AccessRights;
    echo "`n" 
}


foreach ($techniker in $messtechniker){
    echo $techniker; 
    Add-MailboxFolderPermission -Identity $techniker -User antonie.weiss@ms-ortungstechnik.de -AccessRights Editor;
    echo "`n"
}


foreach ($techniker in $messtechniker){
    echo $techniker; 
    foreach ($buero in $bueroteam) {
        Add-MailboxFolderPermission -Identity $techniker -User $buero -AccessRights Editor; 
        echo "`n";
    }
}


foreach ($techniker in $messtechniker){
    echo $techniker; 
    foreach ($buero in $bueroteam) {
        Get-MailboxFolderPermission -Identity $techniker ;
        echo "`n"
    }
}
