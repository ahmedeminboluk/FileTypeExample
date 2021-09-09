using ReadWrite.Enum;

namespace ReadWrite.Interfaces
{
    public interface IFactory
    {
        IProcessType ReadAndSave(SaveType type);
    }
}
