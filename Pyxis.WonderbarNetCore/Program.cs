using System;
using System.Collections.Generic;
using System.Text; 

namespace WPFAndUWPDemo.MyWPFApp
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new WPFAndUWPDemo.UWPApp.App())
            {
                var app = new WPFAndUWPDemo.MyWPFApp.App();
               //app.InitializeComponent(); 
             
                app.Run();
            }
        }
    }
}
