using ReadWrite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    public interface IFileType
    {
        IEntity Read();
        void Create(IEntity entity);
    }
}
