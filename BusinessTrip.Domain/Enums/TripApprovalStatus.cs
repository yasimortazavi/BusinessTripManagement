using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Domain.Enums
{
    public enum TripApprovalStatus
    {
        Pending = 1,   // در انتظار بررسی
        Approved = 2,  // تأییدشده
        Rejected = 3   // ردشده
    }
}
