using CantinaApp.Core.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface IUsersServices
    {
        Users GetUsersInstance();

        List<Users> GetUsers();

        Users AddUsers(Users motd);

        Users DeleteMOTD(int id);

        Users FindUsersId(int id);

        Users UpdateUsers(Users userUpdate);
    }
}
