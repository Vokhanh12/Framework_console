namespace qlcc.control.ListviewControl
{
    public class Square
    {
        private int? _id;
        private int? _rowSize;
        public static int _columnSize = 3;

        private string? _Text;

        public Square(int id,string Text)
        {
            _id = id;
            _Text = Text;
            RowSize = Text.Length + 7;
        }

        public int? RowSize { get => _rowSize; set => _rowSize = value; }
        public int ColumnSize { get => _columnSize; set => _columnSize = value; }
        public string? Text {get => _Text; set => _Text = value;}
       

    }
}