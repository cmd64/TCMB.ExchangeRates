using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TCMB.ExchangeRates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum Languages
        {
            English,
            Türkçe
        }

        ResourceManager langRM = new ResourceManager("TCMB.ExchangeRates.Languages.tr-TR", typeof(Form1).Assembly);

        private string today = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                WebClient web = new WebClient();

                MemoryStream ms = new MemoryStream(web.DownloadData("http://www.tcmb.gov.tr/kurlar/today.xml"));
                doc.Load(ms);

                XmlNodeList nodes = doc.SelectNodes("//Currency");

                today = doc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value.Trim();

                cmbBoxLanguages.DataSource = Enum.GetValues(typeof(Languages));
                cmbBoxLanguages.SelectedIndex = 1;

                GetLstViewItems(nodes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedLanguage(cmbBoxLanguages.SelectedIndex);

            LoadLstViewColumns();
        }

        public void GetSelectedLanguage(int selectedLanguage)
        {
            if (selectedLanguage == (int)Languages.English)
            {
                langRM = new ResourceManager("TCMB.ExchangeRates.Languages.en-US", typeof(Form1).Assembly);
            }
            else if (selectedLanguage == (int)Languages.Türkçe)
            {
                langRM = new ResourceManager("TCMB.ExchangeRates.Languages.tr-TR", typeof(Form1).Assembly);
            }
            else
            {
                langRM = new ResourceManager("TCMB.ExchangeRates.Languages.tr-TR", typeof(Form1).Assembly);
            }

            this.Text = langRM.GetString("formTitle");
        }

        public void LoadLstViewColumns()
        {
            lblDate.Text = string.Format("{0} : {1}", langRM.GetString("lblDate"), today);

            lstViewCurrency.Columns.Clear();

            lstViewCurrency.Columns.Add(langRM.GetString("currencyCode"));
            lstViewCurrency.Columns.Add(langRM.GetString("unit"));
            lstViewCurrency.Columns.Add(langRM.GetString("currency"));
            lstViewCurrency.Columns.Add(langRM.GetString("forexBuying"));
            lstViewCurrency.Columns.Add(langRM.GetString("forexSelling"));
            lstViewCurrency.Columns.Add(langRM.GetString("banknoteBuying"));
            lstViewCurrency.Columns.Add(langRM.GetString("banknoteSelling"));

            lstViewCurrency.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstViewCurrency.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void GetLstViewItems(XmlNodeList nodes)
        {
            foreach (XmlNode node in nodes)
            {
                ExchangeRate kur = new ExchangeRate()
                {
                    CurrencyCode = node.Attributes["CurrencyCode"].Value.Trim(),
                    Unit = node["Unit"].InnerText.Trim(),
                    Currency = node["Isim"].InnerText.Trim(),
                    ForexBuying = node["ForexBuying"].InnerText.Trim(),
                    ForexSelling = node["ForexSelling"].InnerText.Trim(),
                    BanknoteBuying = node["BanknoteBuying"].InnerText.Trim(),
                    BanknoteSelling = node["BanknoteSelling"].InnerText.Trim()
                };

                ListViewItem li = new ListViewItem(kur.CurrencyCode);
                li.SubItems.Add(kur.Unit);
                li.SubItems.Add(kur.Currency);
                li.SubItems.Add(kur.ForexBuying);
                li.SubItems.Add(kur.ForexSelling);
                li.SubItems.Add(kur.BanknoteBuying);
                li.SubItems.Add(kur.BanknoteSelling);
                li.Tag = kur;
                lstViewCurrency.Items.Add(li);
            }
        }
    }
}
