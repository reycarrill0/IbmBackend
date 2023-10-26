﻿using Algar.Hours.Domain.Entities.RolMenu;
using Algar.Hours.Domain.Entities.User;


namespace Algar.Hours.Domain.Entities.Rol
{
    public class RoleEntity
    {
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }

        public virtual UserEntity User { get; set; }   
        
        public virtual RoleMenuEntity RolMenuEntity { get; set; }    

    }
}
