using qlcc.control.ListviewControl;

namespace qlcc.control
{
    public class Listview
    {
        
        private List<Square> _lstcolumn = new List<Square>();
        private List<Square> _lstrow = new List<Square>();


        public Listview()
        {
           
        }

       

        public List<Square> Column { get => _lstcolumn; set => _lstcolumn = value; }
        public List<Square> Row { get => _lstrow; set => _lstrow = value; }



        public void addColumn(Square square)
        {
            _lstcolumn.Add(square);
        }


        public void addRow(Square square)
        {
            _lstrow.Add(square);
        }

        public void show()
        {
            
            showRow();

            Console.WriteLine();

            showColumn();






        }

        private void showColumn()
        {

            foreach(var items in _lstcolumn)
            {

                




            }


        }

        private void showRow()
        {
             for(int i = 0; i < Square._columnSize; i++)
            {
                foreach(var items in _lstrow)
                {
                    for(int j = 0 ; j < items.RowSize ; j++)
                    {
                        if(i != 1)
                         Console.Write(".");
                        else
                        {
                            Console.Write($"-- {items.Text} --.");
                            break;
                        }

                    }

                    
                }

                Console.WriteLine();             

            }

        }



    }
}