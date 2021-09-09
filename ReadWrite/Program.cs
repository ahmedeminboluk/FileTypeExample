using ReadWrite.Enum;
using ReadWrite.Interfaces;


namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            var createFactory = new CreateFactory();

            IProcessType bigPara = createFactory.ReadAndSave(SaveType.BigPara);
            IEntity bigParaList = bigPara.Read();
            bigPara.Save(bigParaList);

            IProcessType mahmure = createFactory.ReadAndSave(SaveType.Mahmure);
            IEntity mahmureList = mahmure.Read();
            mahmure.Save(mahmureList);

            IProcessType adv = createFactory.ReadAndSave(SaveType.Advertorial);
            IEntity advList = adv.Read();
            adv.Save(advList);

            IProcessType bigParaUrl = createFactory.ReadAndSave(SaveType.BigParaUrl);
            IEntity bigParaListUrl = bigParaUrl.Read();
            bigParaUrl.Save(bigParaListUrl);
        }
    }
}
