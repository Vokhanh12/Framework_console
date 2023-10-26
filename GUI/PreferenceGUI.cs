using System.Data;
using System.Runtime.CompilerServices;
using qlcc.BUS;

namespace qlcc.GUI
{
    public class PreferenceGUI
    {

        public static void addButton_Click()
        {

        }

        public static void saveButton_Click()
        {

        }

        public static void notButton_Click()
        {

        }

        public static void updateButton_Click()
        {

        }

        public static void deleteButton_Click()
        {

        }

        public static void LogInfoManagerDetails()
        {
            DataTable? dt = QuanLyChamCongBUS.TTNV("BV");

            int numItems = dt!.Rows.Count;


            for(int i = 0 ; i < numItems ; i++)
            {
                Console.Write($"{dt.Rows[i][0].ToString().PadRight(15)}");
                Console.Write($"{dt.Rows[i][1].ToString().PadRight(15)}");
                Console.Write($"{dt.Rows[i][2].ToString().PadRight(15)}");
                Console.Write($"{dt.Rows[i][3].ToString().PadRight(15)}");
                Console.Write($"{dt.Rows[i][4].ToString().PadRight(15)}");
                Console.Write($"{dt.Rows[i][5].ToString().PadRight(15)}");
                Console.Write($"{dt.Rows[i][6].ToString().PadRight(15)}");
                Console.WriteLine();

            }


        }    



    }
}