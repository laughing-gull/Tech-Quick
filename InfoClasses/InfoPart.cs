using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Tech_Quick.InfoClasses
{
    internal class InfoPart
    {
        private String header;

        private String footer;

        private BitmapImage icon;

        private InfoControl info;

        public InfoPart(String header, String footer, BitmapImage icon) 
        { 
            this.header= header;
            this.footer= footer;
            this.icon= icon;



            this.info = new InfoControl(this.header, this.footer.ToString(), icon);
        }

        public InfoControl getControlInfoControl()
        {
            return info;
        }
    }
}
