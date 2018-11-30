﻿using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.DomainServices
{
    public interface IMOTDRepositories
    {
        MOTD GetFoodIconByID(int id);

        IEnumerable<MOTD> ReadMOTD();

        MOTD CreateMOTD(MOTD motd);

        MOTD DeleteMOTD(int id);
        
        MOTD UpdateMOTD(MOTD motdUpdate);
    }
}
