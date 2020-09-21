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

namespace Prb.ControlsAndEvents.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbLesuur.Items.Add(1);
            cmbLesuur.Items.Add(2);
            cmbLesuur.Items.Add(3);
            cmbLesuur.Items.Add(4);
            cmbLesuur.Items.Add(5);
            cmbLesuur.Items.Add(6);
            cmbLesuur.Items.Add(7);
            cmbLesuur.Items.Add(8);
            cmbLesuur.Items.Add(9);

            cmbDagVanDeWeek.Items.Add("maandag");
            cmbDagVanDeWeek.Items.Add("dinsdag");
            cmbDagVanDeWeek.Items.Add("woensdag");
            cmbDagVanDeWeek.Items.Add("donderdag");
            cmbDagVanDeWeek.Items.Add("vrijdag");
            cmbDagVanDeWeek.Items.Add("zaterdag");

            cmbNaamModule.Items.Add("PRB");
            cmbNaamModule.Items.Add("PRA");
            cmbNaamModule.Items.Add("DBS");
            cmbNaamModule.Items.Add("WFB");
            cmbNaamModule.Items.Add("WFA");

        }
        private void btnVatSamen1_Click(object sender, RoutedEventArgs e)
        {
            string lesUur = txtLesuur.Text;
            string dagVanDeWeek = txtDagVanDeWeek.Text;
            string naamModule = txtNaamModule.Text;
            tbkSamenvatting.Text = "Op " + dagVanDeWeek + " is er les " + naamModule + " op lesuur " + lesUur;
        }

        private void btnVatSamen2_Click(object sender, RoutedEventArgs e)
        {
            string lesUur = cmbLesuur.SelectedItem.ToString();
            string dagVanDeWeek = cmbDagVanDeWeek.SelectedItem.ToString();
            string naamModule = cmbNaamModule.SelectedItem.ToString();
            tbkSamenvatting.Text = "Op " + dagVanDeWeek + " is er les " + naamModule + " op lesuur " + lesUur;

        }

        private void btnVatSamen3_Click(object sender, RoutedEventArgs e)
        {
            string lesUur = txtLesuur.Text;
            string dagVanDeWeek = txtDagVanDeWeek.Text;
            string naamModule = txtNaamModule.Text;
            if (lesUur.Length == 0 || dagVanDeWeek.Length == 0 || naamModule.Length == 0)
                tbkSamenvatting.Text = "Invoer onvolledig";
            else
                tbkSamenvatting.Text = "Op " + dagVanDeWeek + " is er les " + naamModule + " op lesuur " + lesUur;

        }

        private void cmbLesuur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtLesuur.Text = cmbLesuur.SelectedItem.ToString();
            txtLesuur.IsEnabled = false;
        }

        private void cmbDagVanDeWeek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtDagVanDeWeek.Text = cmbDagVanDeWeek.SelectedItem.ToString();
            txtDagVanDeWeek.IsEnabled = false;
        }

        private void cmbNaamModule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtNaamModule.Text = cmbNaamModule.SelectedItem.ToString();
            txtNaamModule.IsEnabled = false;
        }


    }
}
