using ReadWrite.Interfaces;

namespace ReadWrite
{
    public interface IProcessType
    {
        IEntity Read();
        void Save(IEntity entity);
    }
}
