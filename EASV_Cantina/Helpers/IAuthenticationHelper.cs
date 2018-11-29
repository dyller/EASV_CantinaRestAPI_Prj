using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EASV_CantinaRestAPI.Helpers
{
    interface IAuthenticationHelper
    {
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt);
        string GenerateToken(User user);
    }
}
