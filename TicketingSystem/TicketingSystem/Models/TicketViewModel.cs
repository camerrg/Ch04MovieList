using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class TicketViewModel
    {
        public TicketViewModel()
        {
            CurrentTask = new Ticket();
        }
        public Filters Filters { get; set; }
        public List<Status> Statuses { get; set; }
        public List<Sprint> Sprints { get; set; }

        public Dictionary<string, string> DueFilters { get; set; }

        public List<Ticket> Tasks { get; set; }

        public Ticket CurrentTask { get; set; }  //used for Add
    }
}
