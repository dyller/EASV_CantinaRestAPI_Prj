using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface IMOTDServices
    {
        MOTD GetMOTDById(int id);

        List<MOTD> GetMOTDs();

        MOTD AddMOTD(MOTD motd);

        MOTD DeleteMOTD(int id);

        MOTD UpdateMOTD(MOTD motdUpdate);
    }
}
