using ReadWrite.Interfaces;

namespace ReadWrite
{
    public interface IFileType
    {
        IEntity Read();
        void Create(IEntity entity);
    }
}
