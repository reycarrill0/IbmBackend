﻿using Algar.Hours.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algar.Hours.Domain.Entities.UsersExceptions
{
    public class UsersExceptions
    {
        public Guid IdUsersExceptions { get; set; } 

        public Guid UserId {  get; set; }   
        public virtual UserEntity User { get; set; }
        public Guid AssignedUserId { get; set; }
 
        public DateTime StartDate { get; set; } 

        public DateTime EndDate { get; set; }

        public string Description {  get; set; }    


    }
}
