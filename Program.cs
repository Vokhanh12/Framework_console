using System;
using System.ComponentModel;
using System.Data.SqlClient;
using qlcc.control;
using qlcc.control.ListviewControl;


namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // PreferenceGUI.LogInfoManagerDetails();
            Listview lv = new Listview();
            lv.addRow(new Square(1,"Nguyen Vo Khanh"));
            lv.addRow(new Square(2,"Nguyen Trung Khanh"));
            lv.addRow(new Square(2,"Nguyen Trung Khanh Huy"));
            lv.addRow(new Square(2,"Nguyen Trung Khanh Anh"));

            lv.show();

        }
    }
}