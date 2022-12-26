using BilgiOtel_Entity;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtelDAL
{
    public class NesneDoldurma
    {
        /// <summary>
        /// Verilen Tabloya göre listview doldurma
        /// </summary>
        /// <param name="dt">Veritabanından istediğimiz ölçüde doldurduğumuz tablo</param>
        /// <param name="list">Dolmasını istediğimiz listview</param>
        public void listdordurmalisteyegore(DataTable dt, ListView list)
        {   
           list.Items.Clear();
           list.Columns.Clear();
           list.GridLines = true;
           list.FullRowSelect = true;
           list.View = View.Details;
            foreach (var item in dt.Columns)
            {
                list.Columns.Add(item.ToString(),100); 
            }
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem ekle = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    ekle.SubItems.Add(row[i].ToString());
                }
                list.Items.Add(ekle);
            }

        }
        public void herhangibircombo(ComboBox cmb, string spname,string sqlType)
        {
            List<KeyValuePair<object, string>> a = new List<KeyValuePair<object, string>>();
            SqlDataReader deneme = BilgiOtelHelperSQL.myExecuteReader(spname, null, sqlType);
            while (deneme.Read())
            {
                a.Add(new KeyValuePair<object, string>((object)deneme[0], (string)deneme[1]));
            }
            cmb.DataSource = a.ToList();
            cmb.ValueMember="Key";  
            cmb.DisplayMember="Value";
            deneme.Close();
        }

        /// <summary>
        /// Verilen listview'i belirtilen stored proc doğrultusunda doldurma
        /// </summary>
        /// <param name="list">Doldurmak istediğiniz listview adı</param>
        /// <param name="spname">sql de yazılan proc adı </param>
        /// <param name="spparametreleri">stored proc de parametre varsa doldurulabilir</param>
        public void listviewdoldur(ListView list,string spname, SqlParameter[] spparametreleri,string sqlType)
        {
            list.Items.Clear();
            list.Columns.Clear();
            list.GridLines = true;
            list.FullRowSelect = true;
            list.View = View.Details;
            SqlDataReader okuyucu = BilgiOtelHelperSQL.myExecuteReader(spname, spparametreleri,sqlType);

            for (int i = 0; i < okuyucu.FieldCount; i++)
            {
                list.Columns.Add(okuyucu.GetName(i), 100);
            }
            while (okuyucu.Read())
            {
                ListViewItem ekleme = new ListViewItem(okuyucu[0].ToString());
                for (int i = 1; i < okuyucu.FieldCount; i++)
                {
                    ekleme.SubItems.Add(okuyucu[i].ToString());
                }
                list.Items.Add(ekleme);
            }
            okuyucu.Close();
        
        }
        #region Form-Panel-Gruopbox Temizleme
        public void FromTemizleme(Form frm)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }

                else if (item is ListView)
                {

                    (item as ListView).Items.Clear();
                    (item as ListView).Columns.Clear();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Today;
                }
                else if (item is GroupBox)
                {
                    grtemizleme((GroupBox)item);
                    
                }
                else if (item is Panel)
                {
                    paneltemiz((Panel)item);

                }
            }



        }

        public void grtemizleme(GroupBox gr)
        {
            foreach (Control item in gr.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }

                else if (item is ListView)
                {

                    (item as ListView).Items.Clear();
                    (item as ListView).Columns.Clear();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Today;
                }
                else if (item is GroupBox)
                {
                    grtemizleme((GroupBox)item);

                }
                else if (item is Panel)
                {
                    paneltemiz((Panel)item);

                }
            }

        }
        public void paneltemiz(Panel pn)
        {
            foreach (Control item in pn.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }

                else if (item is ListView)
                {

                    (item as ListView).Items.Clear();
                    (item as ListView).Columns.Clear();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Today;
                }
                else if (item is GroupBox)
                {
                    grtemizleme((GroupBox)item);

                }
                else if (item is Panel)
                {
                    paneltemiz((Panel)item);

                }



            }


        }

        #endregion
        //public List<KeyValuePair<int, string>> bircomboDoldur(string spname,ComboBox cmb)
        //{
        //    List<KeyValuePair<int, string>> doluListe = new List<KeyValuePair<int, string>>();
        //    SqlDataReader deneme = BilgiOtelHelperSQL.myExecuteReader(spname, null, "sp");
        //    while (deneme.Read())
        //    {
        //        doluListe.Add(new KeyValuePair<int, string>((int)deneme[0], (string)deneme[1]));

        //    }


        //    deneme.Close();

        //    return doluListe;


        //}


        public void ismeGoreComboSectirme(ComboBox cmb, string tablodakideger)
        {
            List<KeyValuePair<int, string>> liste2 = (List<KeyValuePair<int, string>>)cmb.DataSource;
            //cmb.SelectedValue = liste2.FirstOrDefault(w => w.Value == tablodakideger).Key;
            for (int i = 0; i < liste2.Count(); i++)
            {
                if (liste2[i].Value == tablodakideger)
                {
                    cmb.SelectedValue = liste2[i].Key;
                    break;
                }
            }
        }

        #region DataTable verileri Formdaki nesnelerin tabindexlerine uyuşu ile doldurma (Tabloda ülke,il,ilce String Değer olarak Gönderiliyor!!)
        public void FormDoldurma(Form frm, DataTable Dtable)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text=Dtable.Rows[(item as TextBox).TabIndex].ToString();
                }
                else if (item is ComboBox)
                {
                    ismeGoreComboSectirme((item as ComboBox), Dtable.Rows[(item as TextBox).TabIndex].ToString());
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = Convert.ToBoolean(Dtable.Rows[(item as CheckBox).TabIndex]);
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = Convert.ToDateTime(Dtable.Rows[(item as DateTimePicker).TabIndex].ToString());
                }
            }

        }
        #endregion


        public SqlParameter[] degeriparametreyapma(string parametrename,string parametrevalue)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter
                {
                    ParameterName= parametrename,
                    Value=parametrevalue
                }
            };

            return sqlParameters;

        }

    }
}
