using System.Data;
using System.Runtime.CompilerServices;
using qlcc.BUS;
using qlcc.control;
using qlcc.control.ListviewControl;

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
     

            Listview lv = new Listview();

            lv.addRow(new Square(0,"MaNV"));
            lv.addRow(new Square(1,"HoTen"));
            lv.addRow(new Square(2,"GioiTinh"));
            lv.addRow(new Square(3,"hsluong"));
            lv.addRow(new Square(4,"ngaysinh"));
            lv.addRow(new Square(5,"noisinh"));
            lv.addRow(new Square(6,"klcv"));


            lv.show();


        }    



    }
}