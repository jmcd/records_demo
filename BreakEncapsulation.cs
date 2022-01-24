namespace Records;

using System;

public class BreakEncapsulation
{
    // https://enterprisecraftsmanship.com/posts/csharp-records-value-objects/
    // 7. The problem with with
    // 

    public void SettingInvalid()
    {
        var status = new CustomerStatus(false, null)
        {
            IsAdvanced = true,
        };

        var customerStatus = status with { IsAdvanced = true };
    }

    public record CustomerStatus
    {
        public CustomerStatus(bool isAdvanced, DateTime? expirationDate)
        {
            switch (isAdvanced)
            {
                case true when expirationDate.HasValue == false:
                    throw new("Advanced status must have an expiration date");
                case false when expirationDate.HasValue:
                    throw new("Regular status must have no expiration date");
                default:
                    IsAdvanced = isAdvanced;
                    ExpirationDate = expirationDate;
                    break;
            }
        }

        public bool IsAdvanced { get; init; }
        public DateTime? ExpirationDate { get; init; }
    }
}