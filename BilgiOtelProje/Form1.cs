using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiOtelDAL;
using BilgiOtel_Entity;

namespace BilgiOtelProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NesneDoldurma nesne = new NesneDoldurma();
            nesne.Combodoldur(cmbulke);
            
           /* int personelID = 1;
            SatisDAL satis = new SatisDAL();
            Satis deneme = new Satis();
            deneme.OdaId = 5;
            int SatısID=(int)satis.OdaSatis(deneme,personelID);

            Musteri m =new Musteri();
            Misafir mis = new Misafir();
            m.MusteriID = 5;
            mis.MisafirId = 10;

            for (int i = 0; i < 3; i++)
            {
                m.MusteriID = i;
                mis.MisafirId = i + 1;

                satis.OdaSatisAraTablo(m, mis, SatısID, deneme);


            }*/



















        }
    }
}
