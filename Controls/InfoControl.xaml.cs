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

namespace Tech_Quick
{
    /// <summary>
    /// Interaction logic for InfoControl.xaml
    /// </summary>
    public partial class InfoControl : UserControl
    {




        public InfoControl()
        {
            InitializeComponent();
            this.descriptiveIcon.Source = new BitmapImage(new Uri("/Images/CogPlaceHolder.png", UriKind.Relative));
            this.descriptiveHeader.Text = "Temporay Filler Header";
            this.primaryInfo.Text = "Temoray Filler Info";
        }

        public InfoControl(String header, String primaryInfo, BitmapImage icon)
        {
            InitializeComponent();
            this.descriptiveIcon.Source = icon;
            this.descriptiveHeader.Text = header;
            this.primaryInfo.Text = primaryInfo;
        }

        private void OpenFullInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Image clicked!");
        }
    }
}
