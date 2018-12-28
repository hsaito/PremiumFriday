---
external help file: PremiumFriday.dll-Help.xml
Module Name: PremiumFriday
online version:
schema: 2.0.0
---

# Get-NextPremiumFriday

## SYNOPSIS
Gets next Premium Friday date.

## SYNTAX

```
Get-NextPremiumFriday [-Date] <DateTime> [<CommonParameters>]
```

## DESCRIPTION
The `Get-NextPremiumFriday` cmdlet gets next Premium Friday date from the date entered.

## EXAMPLES

### Example 1: Find next Premium Friday
```powershell
$dateToTest = Get-Date
Get-NextPremiumFriday $dateToTest
```

### Example 2: Find next Premium Friday (Piped)
```powershell
Get-Date | Get-NextPremiumFriday
```

## PARAMETERS

### -Date
Date to start checking.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.DateTime

Date to start checking.

## OUTPUTS

### System.DateTime

Next Premium Friday date.
If the date specified is a Premium Friday, it returns that date.

## NOTES
Based on [Premium Friday Japan](https://premiumfriday-japan.com/) information.

## RELATED LINKS
[Test-PremiumFriday](Test-PremiumFriday)