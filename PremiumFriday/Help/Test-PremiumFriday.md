---
external help file: PremiumFriday.dll-Help.xml
Module Name: PremiumFriday
online version:
schema: 2.0.0
---

# Test-PremiumFriday

## SYNOPSIS
Tests if entered date is a Premium Friday.

## SYNTAX

```
Test-PremiumFriday [-Date] <DateTime> [<CommonParameters>]
```

## DESCRIPTION
The `Test-PremiumFriday` tests the date if the entered date is Premium Friday.

## EXAMPLES

### Example 1: Check if today's a Premium Friday
```powershell
$dateToTest = Get-Date
Test-PremiumFriday $dateToTest
```

### Example 2: Check if today's a Premium Friday (Piped)
```powershell
Get-Date | Test-PremiumFriday $dateToTest
```

## PARAMETERS

### -Date
Date to test to see if the date is a Premium Friday.

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

Date to test to see if the date is a Premium Friday.

## OUTPUTS

### System.Boolean

True if the date entered is a Premium Friday.
False if the date entered is not a Premium Friday.

## NOTES
Based on [Premium Friday Japan](https://premiumfriday-japan.com/) information.

## RELATED LINKS
[Get-NextPremiumFriday](Get-NextPremiumFriday)