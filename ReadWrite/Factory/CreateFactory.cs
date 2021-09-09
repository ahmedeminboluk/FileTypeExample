using ReadWrite.Concreate;
using ReadWrite.Enum;
using ReadWrite.Interfaces;

namespace ReadWrite
{
    public class CreateFactory : IFactory
    {
        public IProcessType ReadAndSave(SaveType type)
        {
            IProcessType file = null;
            switch (type)
            {
                case SaveType.BigPara:
                    file = new JsonTypeBigPara();
                    break;
                case SaveType.Mahmure:
                    file = new XmlTypeMahmure();
                    break;
                case SaveType.Advertorial:
                    file = new XmlTypeAdvertorial();
                    break;
                case SaveType.BigParaUrl:
                    file = new JsonBigParaUrl();
                    break;
            }
            return file;
        }
    }
}
