using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Domain.Enums
{
    public enum BookingStatus
    {
        Pending = 1,     // در انتظار تأیید
        Confirmed = 2,   // تأیید شده
        Cancelled = 3   // لغو شده
    }
}
