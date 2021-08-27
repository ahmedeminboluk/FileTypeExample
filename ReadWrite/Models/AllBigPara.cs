using ReadWrite.Interfaces;
using System.Collections.Generic;

namespace ReadWrite.Models
{
    public class AllBigPara : IEntity
    {
        public List<BigPara> BigParas { get; set; }
    }
}
