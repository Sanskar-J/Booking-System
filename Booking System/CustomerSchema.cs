using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_System
{
    internal class CustomerSchema
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId CustId { get; set; }

        public string CustName { get; set; }

        public string CustAdd { get; set; }

        public string CustPhone { get; set; }
    }
}
