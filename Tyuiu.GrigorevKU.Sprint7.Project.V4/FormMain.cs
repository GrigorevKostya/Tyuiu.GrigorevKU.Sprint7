using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GrigorevKU.Sprint7.Project.V4.Lib;

namespace Tyuiu.GrigorevKU.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            DataService ds = new DataService();
        }
    }
    
}
