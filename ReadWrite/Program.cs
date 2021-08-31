using ReadWrite.Enum;
using ReadWrite.Interfaces;


namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            var createFactory = new CreateFactory();

            IFileType bigPara = createFactory.ReadAndCreate(CreateType.BigPara);
            IEntity bigParaList = bigPara.Read();
            bigPara.Create(bigParaList);

            IFileType mahmure = createFactory.ReadAndCreate(CreateType.Mahmure);
            IEntity mahmureList = mahmure.Read();
            mahmure.Create(mahmureList);

            IFileType adv = createFactory.ReadAndCreate(CreateType.Advertorial);
            IEntity advList = adv.Read();
            adv.Create(advList);

            IFileType bigParaUrl = createFactory.ReadAndCreate(CreateType.BigParaUrl);
            IEntity bigParaListUrl = bigParaUrl.Read();
            bigParaUrl.Create(bigParaListUrl);
        }
    }
}
