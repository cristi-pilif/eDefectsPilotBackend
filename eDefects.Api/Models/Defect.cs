using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDefectsPilotBackend.Models
{
    public class Defect
    {
        public int Id { get; set; }

        //   asta se incarca automat dar nu stiu inca de unde 
        //  public string FLCode { get; set; }; 

        //nu stiu ce e asta
        //public bool SAPNotification { get; set; } 

        public String Description { get; set; }

        //nu stiu ce e asta
        //public bool RepeatDefect { get; set; }

        //se autocompleteaza cu data de azi, e pus ca optional in eDefects dar din front e obligatoriu
        public DateTime DateFound { get; set; }

        //la fel ca mai sus
        public DateTime DateClosed { get; set; }

        //in eDefects avem un System.DateTime PMOpenDate ce nu stiu ce e

        public string FoundBy { get; set; } //se autocompleteaza automat cu username-ul logat

        public string CreatedBy { get; set; } //se autocompleteaza automat cu username-ul logat

        public string? ClosedBy { get; set; }

        public DateTime DueDate { get; set; }

        public string Team { get; set; } // aici o sa trebuiasca sa se incarce echipele

       // public DefectType DefectType { get; set; }

       // public DefectComponent DefectComponent { get; set; }

       // public Priority Priority { get; set; }

       // public FindSource FindSource { get; set; }

        //public string Task { get; set; } // nu stiu ce e asta, e un camp Task in eDefects

        public string CM1 { get; set; }

        public string CM2 { get; set; }

        public string CM3 { get; set; }



    }
}
