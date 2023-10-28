using System.Data;
using qlcc.BUS;
using qlcc.control.ListviewControl;

namespace qlcc.control
{
    public class Listview
    {
        private Dictionary<int, List<Square>> map_num_square = new Dictionary<int, List<Square>>();
        private List<Square> _lstcolumn = new List<Square>();
        private List<Square> _lstrow = new List<Square>();

        private int[] maxSizeToRow = new int[100];




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

        public async void show()
        {
            Task t1 = new Task(
                () => {
                    Thread.Sleep(1500);
                    showRow(_lstrow);
                }
            );


            Task t2 = new Task(
                () => {
                    showColumn();
                }
            );

            t1.Start();
            t2.Start();
            
            t1.Wait();
            t2.Wait();


            Console.WriteLine("Hello");



        }


 
        private void showColumn()
        {


            DataTable? dt = QuanLyChamCongBUS.TTNV("BV");

            int numItems = dt!.Rows.Count;
            

            for(int i = 0; i<numItems; i++)
            {
                List<Square> lstCurrent = new List<Square>();

                lstCurrent.Add(new Square(i,dt.Rows[i][0].ToString()));
                 excuteGetMaxSize(dt.Rows[i][0].ToString(),0);

                lstCurrent.Add(new Square(i,dt.Rows[i][1].ToString()));
                 excuteGetMaxSize(dt.Rows[i][1].ToString(),1);
                 
                lstCurrent.Add(new Square(i,dt.Rows[i][2].ToString()));
                 excuteGetMaxSize(dt.Rows[i][2].ToString(),2);

                lstCurrent.Add(new Square(i,dt.Rows[i][3].ToString()));
                 excuteGetMaxSize(dt.Rows[i][3].ToString(),3);

                lstCurrent.Add(new Square(i,dt.Rows[i][4].ToString()));
                 excuteGetMaxSize(dt.Rows[i][4].ToString(),4);

                lstCurrent.Add(new Square(i,dt.Rows[i][5].ToString()));
                 excuteGetMaxSize(dt.Rows[i][5].ToString(),5);
                 
                lstCurrent.Add(new Square(i,dt.Rows[i][6].ToString()));
                 excuteGetMaxSize(dt.Rows[i][6].ToString(),6);

                map_num_square.Add(i,lstCurrent);    

              
               

            }

        

            for(int i = 0; i< numItems; i++)
            {
              int j = 0;
              List<Square> lstKey = map_num_square[i];
              List<Square> newLstKey = new List<Square>();
              foreach(var items in lstKey)
              {
                items.RowSize = maxSizeToRow[j]+15;
                j++;
                newLstKey.Add(items);
              }

              //--------bug---------
              Thread.Sleep(1500);
              showHelper(newLstKey);
              j=0;
            }

     

            for(int i = 0 ;i < 6 ;i++)
            {
             Console.WriteLine($"{maxSizeToRow[i]} ");

            }

        }

        private void showRow(List<Square> lstSquare)
        {

            List<Square> newLstSquare = new List<Square>();

            int k = 0;
      

            foreach(var item in lstSquare)
            {
                item.RowSize = maxSizeToRow[k] + 15;
                newLstSquare.Add(item);

                k++;
            }

        

            for(int i = 0; i < Square._columnSize; i++)
            {
                foreach(var items in newLstSquare)
                {
                    for(int j = 0 ; j < items.RowSize ; j++)
                    {
                        if(i != 1)
                         Console.Write(".");
                        else
                        {
                            Console.Write("--    ");
                            Console.Write($" {items.Text}");


                            for(int l = 0; l <  items.RowSize - items.Text.Length - 15 ; l++)
                            {
                                Console.Write(" ");
                            }

                            Console.Write("    --.");

                            break;
                        }


                    }

                }

                    Console.WriteLine();

            }

        }

         private void showHelper(List<Square> lstSquare)
        {
       
            for(int i = 0; i < Square._columnSize; i++)
            {
                foreach(var items in lstSquare)
                {
                    for(int j = 0 ; j < items.RowSize ; j++)
                    {
                        if(i != 1)
                         Console.Write(".");
                        else
                        {
                            Console.Write($"--     {items.Text}     --.");
                            break;
                        }

                    }

                    
                }

                Console.WriteLine();             

            }

        }

        private void excuteGetMaxSize(string Text,int index)
        {
            int? current;

            if(maxSizeToRow[index] < Text.Length)
            maxSizeToRow[index] = Text.Length;

        }



    }
}