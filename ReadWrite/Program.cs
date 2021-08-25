using ReadWrite.Enum;
using System;


namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            var createFactory = new CreateFactory();

            IFileType bigPara = createFactory.ReadAndCreate(CreateType.BigPara);
            bigPara.Create();

            IFileType mahmure = createFactory.ReadAndCreate(CreateType.Mahmure);
            mahmure.Create();

            IFileType adv = createFactory.ReadAndCreate(CreateType.Advertorial);
            adv.Create();
        }
    }
}
