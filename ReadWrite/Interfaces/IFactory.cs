using ReadWrite.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite.Interfaces
{
    public interface IFactory
    {
        IFileType ReadAndCreate(CreateType type);
    }
}
