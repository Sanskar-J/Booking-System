using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_System
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    internal class BookingSchema
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Bid { get; set; }

        public DateTime BDate { get; set; }

        public string BTime { get; set; }

        public string CustName { get; set; }

        public string Function { get; set; }

        public string Venue { get; set; }

        public string EquipmentsIncluded { get; set; }

        public int IncludeCost { get; set; }

        public int OtherCharges { get; set; }

        public int GndTotal { get; set; }

        public int Advance { get; set; }

        public int Balance { get; set; }

        // Add other properties as needed for your booking system

        // Optional: Add constructors, additional methods, and validation logic as necessary
    }

}
