using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Oyuncu> Karşıyaka = new List<Oyuncu> ;
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            string yeniPozisyon = CBoxPozisyon.SelectedItem.ToString();

            Oyuncu _oyuncu = new Oyuncu("Şehmuz");
            _oyuncu.formaNo = 9;
            _oyuncu.takimi = "Karşıyaka";
            _oyuncu.pozisyon = yeniPozisyon;
            MessageBox.Show(_oyuncu.adi);

            Oyuncu _oyuncu2 = new Oyuncu("şehmuz", "Karşıyaka", yeniPozisyon, 9);
            MessageBox.Show(oyuncu2.adi +" "+ _oyuncu2.takimi +" "+ _oyuncu2.formaNo);
            Oyuncu oyuncu2 = new Oyuncu("Şehmuz", "Altay", yeniPozisyon, 9);
            MessageBox.Show(oyuncu2.adi + " " + oyuncu2.takimi + " " + oyuncu2.pozisyon + " " + oyuncu2.formaNo);
        }
    }
}
