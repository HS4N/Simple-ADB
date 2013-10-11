/* Made by HS4N
*  Follow me on twitter http://twitter.com/HS4N
*  Thanks! */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading; 

namespace SplashScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();  
            Thread.Sleep(5000); 
            InitializeComponent();
            t.Abort(); 
            
        }

        public void SplashScreen()
        {
            Application.Run(new Form2());  
        }
    }
}
