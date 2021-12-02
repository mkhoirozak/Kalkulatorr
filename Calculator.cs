using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Kalkulator
    {
        public string Hasilnya { get; set; }
    }
}
namespace Calculator
{
    public partial class HasilHitung : Form
    public HasilHitung()
    {
        InitializeComponent();
        initialisasilv();
    }

    private void initialisasilv()
    {
        lvHasil.View = view.Details;

        lvHasil.Columns.Add(**, 10, HorizontalAlignment.Left);
        lvHasil.Columns.Add(**, 200, HorizontalAligment.Left);

    }

    private void Frmcalc_OnCalculated(Kalkulator calc)
    {
        listDariHasil.Add(calc);

        ListViewItem item = new ListViewItem();
        item.Subitems.Add(calc.Hasilnya);

        lvHasil.Item.Add(item);
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
}   