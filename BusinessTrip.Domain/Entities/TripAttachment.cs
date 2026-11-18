using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Domain.Entities;

public class TripAttachment
{
    public int Id { get; set; }

    public string OriginalFileName { get; set; } = string.Empty;

    public string StoredFileName { get; set; } = string.Empty;

    public string StoragePath { get; set; } = string.Empty;

    public string ContentType { get; set; } = string.Empty;

    public long FileSize { get; set; }

    public int BusinessTripRequestId { get; set; }

    public BusinessTripRequest BusinessTripRequest { get; set; } = null!;
}
