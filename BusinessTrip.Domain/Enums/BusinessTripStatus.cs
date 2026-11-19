using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Domain.Enums
{
    public enum BusinessTripStatus
    {
        Submitted = 1,       // ثبت‌شده
        UnderReview = 2,     // در حال بررسی
        Approved = 3,        // تأییدشده
        Rejected = 4,        // ردشده
        BookingInProgress = 5, // در حال انجام رزروها
        Completed = 6,       // تکمیل‌شده
        Cancelled = 7        // لغوشده
    }
}
