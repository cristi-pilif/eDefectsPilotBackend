using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDefects.Api.Models
{
    public class Defect
    {
        public Guid Id { get; set; }

        //  public string FLCode { get; set; }; 

        //nu stiu ce e asta
        //public bool SAPNotification { get; set; } 

        public string Description { get; set; }

        //nu stiu ce e asta
        //public bool RepeatDefect { get; set; }

        
        public DateTime DateFound { get; set; }

        //la fel ca mai sus
        public DateTime DateClosed { get; set; }

        //in eDefects avem un System.DateTime PMOpenDate ce nu stiu ce e

        public string FoundBy { get; set; } //se autocompleteaza automat cu username-ul logat

        public string CreatedBy { get; set; } //se autocompleteaza automat cu username-ul logat

        public string? ClosedBy { get; set; }

        public DateTime DueDate { get; set; }

        public Guid? TeamID { get; set; } //legatura cu echipa

        public Guid? DepartmentID { get; set; } //legatura cu departament 

        public Guid? ProdLineID { get; set; } //legatura cu linia de productie

        public Guid? PUGroupID { get; set; } //legatura cu grupul de productie

        public Guid? ProdUnitID { get; set; } 

        //TO DO: Atasament poza/multiple poze

        public Guid? DefectLineID { get; set; }

        public Guid? DefectComponentID { get; set; }

        public Guid? PriorityID { get; set; } 

        public Guid? FindSourceID { get; set; } 

        //public string Task { get; set; } // nu stiu ce e asta, e un camp Task in eDefects

        public string CM1 { get; set; }

        public string CM2 { get; set; }

        public string CM3 { get; set; }



    }
}
