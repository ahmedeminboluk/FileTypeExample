﻿using ReadWrite.Enum;
using ReadWrite.Interfaces;
using System;


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
        }
    }
}
