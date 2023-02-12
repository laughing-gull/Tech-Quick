using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management;
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
using Tech_Quick.InfoClasses.Hardware_Category;

namespace Tech_Quick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HardwareBuilder _hardwareBuilder = new HardwareBuilder();
        InfoCPU InfoCPU;


        public MainWindow()
        {
            InitializeComponent();
            HardwareBuilder hardwareBuilder = new HardwareBuilder();
        }

        private void OpenSystemView(object sender, RoutedEventArgs e)
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                this.TempWrapPanelContent.Children.Add(_hardwareBuilder.createInfoCPU(obj).getControlInfoControl());
            }



        }

    }
}
