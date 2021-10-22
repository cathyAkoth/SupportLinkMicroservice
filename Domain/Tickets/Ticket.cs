using System;
using System.Collections.Generic;
using Domain.Comments;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Domain.Tickets
{
    [BsonIgnoreExtraElements]
    public class Ticket
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Summary { get; set; }
        public int TicketNumber { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Priority Priority { get; set; }
        public DateTime SubmitDate { get; set; }
        public Status Status { get; set; }