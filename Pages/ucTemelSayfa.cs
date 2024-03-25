using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipApp.Pages
{
    public partial class ucTemelSayfa : UserControl
    {
        public ucTemelSayfa()
        {
            InitializeComponent();
        }

        public virtual async void Kaydet()
        {
            MessageBox.Show("Kayıt edilmesi için gerekli kayıt kodunu yazın.");
        }
    }
}
