using System.Text.RegularExpressions;

namespace Collections;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string? phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
            return false;

        return Regex.IsMatch(
            phone,
            @"^(01[0125]\d{8}|\+201[0125]\d{8})$"
        );
    }

    public static bool IsValidEgyptianNationalId(this string? nationalId)
    {
        if (string.IsNullOrWhiteSpace(nationalId))
            return false;

        return Regex.IsMatch(
            nationalId,
            @"^[23]\d{13}$"
        );
    }
}