using ReadWrite.Enum;

namespace ReadWrite.Interfaces
{
    public interface IFactory
    {
        IFileType ReadAndCreate(CreateType type);
    }
}
