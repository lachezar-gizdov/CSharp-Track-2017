namespace ConnectedAreasInMatrix
{
    public class Area
    {
        public Area(int size, int row, int col)
        {
            this.Size = size;
            this.Row = row;
            this.Col = col;
        }

        public int Size { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public override string ToString()
        {
            return string.Format(
                "({0}, {1}), size: {2}",
                this.Row,
                this.Col,
                this.Size);
        }
    }
}
