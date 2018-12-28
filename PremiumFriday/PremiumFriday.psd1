@{
    RootModule = 'PremiumFriday.dll'
    ModuleVersion = '1.0.1.0'
    FunctionsToExport = @(
    'Get-NextPremiumfriday'
    'Test-PremiumFriday'
    )
    CmdletsToExport   = '*'
    VariablesToExport = '*'
    AliasesToExport   = '*'
    GUID = '8c806aea-75a1-404c-90f6-623465a1c461'
    Author = 'Hideki Saito'
    Description = 'Premium Friday Validation Module for PowerShell'
    PowerShellVersion = '6.0'
    CompatiblePSEditions = 'Core'
    Copyright = '(c) 2018 Hideki Saito. All rights reserved.'
    PrivateData = @{
        PSData = @{
            ProjectUri = 'https://github.com/hsaito/PremiumFriday/'
            LicenseUri = 'https://github.com/hsaito/PremiumFriday/blob/master/LICENSE'
            ReleaseNotes = 'Resolved the issue that resulted 2017-01-27 was shown as a Premium Friday. (While it started 2017-02-24.)'
        }
    }
}