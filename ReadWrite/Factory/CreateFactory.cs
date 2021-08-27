using ReadWrite.Enum;
using ReadWrite.Interfaces;

namespace ReadWrite
{
    public class CreateFactory : IFactory
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
