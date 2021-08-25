using ReadWrite.Enum;
using ReadWrite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    public class CreateFactory : IVehicleFactory
    {
        public IFileType ReadAndCreate(CreateType type)
        {
            IFileType file = null;
            switch (type)
            {
                case CreateType.BigPara:
                    file = new JsonTypeBigPara();
                    break;
                case CreateType.Mahmure:
                    file = new XmlTypeMahmure();
                    break;
                case CreateType.Advertorial:
                    file = new XmlTypeAdvertorial();
                    break;
            }
            return file;
        }
    }
}
