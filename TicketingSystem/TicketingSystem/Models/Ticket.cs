using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        //name of the person
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a due date .")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please enter a sprint number.")]
        public string SprintId { get; set; }
        public Sprint Sprint { get; set; }

        [Required(ErrorMessage = "Please enter a status.")]
        public string StatusId { get; set; }
        public Status Status{ get; set;}

        public bool Overdue =>
            StatusId == "open" && DueDate < DateTime.Today;

    }
}
