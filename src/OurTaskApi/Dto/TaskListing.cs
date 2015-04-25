using System;
using System.Collections.Generic;

namespace OurTaskApi.Dto
{
    public class TaskListing
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public DateTime DueDate { get; set; }
        public IEnumerable<PersonListing> AssignedPersonnel { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string CompletionComment { get; set; }
    }
}