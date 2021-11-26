namespace paper_io
{
    class Coordinate
    {
        private int x;
        private int y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Coordinate() { }
        public int X
        {
            get { return (x); }
            set { x = value; }
        }
        public int Y
        {
            get { return (y); }
            set { x = value; }
        }
    }
}
