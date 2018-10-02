using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class Siparis : Form
    {
        ListBox lstArac;

        public Siparis()
        {
            InitializeComponent();
        }

        public Siparis(ListBox gelenlstArac)
        {
            InitializeComponent();
            this.lstArac = gelenlstArac;
            decimal toplamTutar=0;
            for (int i = 0; i < lstArac.Items.Count; i++)
            {
                Arac arac =(Arac)lstArac.Items[i];
                toplamTutar += Convert.ToDecimal(arac.FaturaTutari);
            }
            lblMeblag.Text = toplamTutar.ToString("C");
        }
    }
}
