using ReadWrite.Interfaces;

namespace ReadWrite
{
    public class BigPara : IEntity
    {
        public string Title { get; set; }
        public string Spot { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
        public int Order { get; set; }
    }
}
