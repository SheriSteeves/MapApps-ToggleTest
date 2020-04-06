using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;

namespace MahAppsToggleTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool _toggle1Checked = false;
        public bool Toggle1Checked
        {
            get { return _toggle1Checked; }
            set { _toggle1Checked = value; }
        }

        private bool _toggle2Checked = false;
        public bool Toggle2Checked
        {
            get { return _toggle2Checked; }
            set { _toggle2Checked = value; }
        }

        private bool _toggle3Checked = true;
        public bool Toggle3Checked
        {
            get { return _toggle3Checked; }
            set { _toggle3Checked = value; }
        }
    }

   

}
