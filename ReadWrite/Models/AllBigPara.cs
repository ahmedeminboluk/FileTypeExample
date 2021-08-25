using ReadWrite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite.Models
{
    public class AllBigPara : IEntity
    {
        public List<BigPara> BigParas { get; set; }
    }
}
