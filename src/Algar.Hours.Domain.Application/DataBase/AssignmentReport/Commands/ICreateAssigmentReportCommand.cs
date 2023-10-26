﻿using Algar.Hours.Application.DataBase.Rol.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algar.Hours.Application.DataBase.AssignmentReport.Commands
{
    public interface ICreateAssigmentReportCommand
    {
        Task<CreateAssignmentReportModel> Execute(CreateAssignmentReportModel model);

    }
}
