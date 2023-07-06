using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_System
{
    internal class StaffSchema
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId StaffId { get; set; }

        public string StaffName { get; set; }

        public string StaffPhone { get; set; }

        public string StaffGender { get; set; }

        public string StaffPassword { get; set; }
    }
}
