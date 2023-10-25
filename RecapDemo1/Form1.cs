using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }


        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0; //yükseklik değeri
            int left = 0; //sol değer
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    this.Controls.Add(buttons[i, j]); //butonu ekrana koyar
                    //buraya kadar üst üste eklenmiş 64 buton koyar. Bizim ikinci butonu 50 karakter sonra başlatmamız lazım.
                    buttons[i, j].Left = left; //İlk sekiz buton için left ve top 0.
                    buttons[i, j].Top = top;
                    left += 50; //ikinci buttonu +50 karakter yazdırdım.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }
                top += 50; //İkinci satıra geçtiğinde top'ı 50 arttır demek.
                left = 0; //ikinci satıra geçtiğimde lefti sıfırlamam lazım. Şimdi top'ı arrtırmam lazım.

            }
            //buttons.Width = 50; //butonun genişliği
            //buttons.Height = 50; //butonun yüksekliği
            //buttons.Text = "My Button"; //butonun adı
        }
    }
}
