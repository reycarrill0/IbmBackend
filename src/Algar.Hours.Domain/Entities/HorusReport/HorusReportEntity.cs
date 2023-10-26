﻿using Algar.Hours.Domain.Entities.AssignmentReport;
using Algar.Hours.Domain.Entities.Client;
using Algar.Hours.Domain.Entities.User;


namespace Algar.Hours.Domain.Entities.HorusReport
{
    public class HorusReportEntity
    {
        public Guid IdHorusReport { get; set; }
        public Guid UserEntityId { get; set; }
        public virtual UserEntity UserEntity { get; set; }
        public DateTime StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public Guid ClientEntityId { get; set; }
        public virtual ClientEntity ClientEntity { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public int TipoReporte { get; set; }    

        public DateTime DateApprovalSystem { get; set; }    

        public AssignmentReport.AssignmentReport assignmentReport { get; set; }  

    }
}
