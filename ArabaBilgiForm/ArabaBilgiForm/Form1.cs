using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArabaBilgiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            // TextBox'lardan alınan veriler
            string marka = MarkatextBox.Text;
            string model = ModeltextBox.Text;
            string renk = RenktextBox.Text;
            string kapiSayisi = KapıSayısıtextBox.Text;
            string pencereSayisi = PencereSayısıtextBox.Text;
            string yakit = YakıttextBox.Text;

            // Verileri MessageBox ile gösterme
            MessageBox.Show(
                $"Marka: {marka}\n" +
                $"Model: {model}\n" +
                $"Renk: {renk}\n" +
                $"Kapı Sayısı: {kapiSayisi}\n" +
                $"Pencere Sayısı: {pencereSayisi}\n" +
                $"100 km’de Yaktığı Yakıt: {yakit} Litre",
                "Araba Bilgileri",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}