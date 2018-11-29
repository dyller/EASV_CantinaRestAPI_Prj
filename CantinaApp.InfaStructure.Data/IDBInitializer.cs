using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.InfaStructure.Data
{
    public interface IDBInitializer
    {
        void SeedDb(CantinaAppContext ctx);
    }
}
