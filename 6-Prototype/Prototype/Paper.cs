namespace Prototype
{
    class Paper : Cloneable
    {
        private string name;
        public Paper() { }
        public Paper(string name)
        {
            this.name = name;
        }
        public Cloneable createClone()
        {
            Paper newPaper = new Paper();
            newPaper.name = this.name;
            // newPaper と this を重ねて、this の形に切り抜く
            return newPaper;
        }
    }
}