using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;
using System.IO;
using static WindowsFormsApp1.Form1;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;

namespace WindowsFormsApp1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            categoryImportBox.Items.AddRange(new object[] { "Мебель", "Стройматериалы", "Товары_для_дома", "Садовая_техника", "Декор", "Инструменты", "Крепежные_изделия" });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            string[] massive = File.ReadAllLines(@"tyrue.txt");
            Tovar[] tovars = new Tovar[massive.Length];
            int CountGoods = massive.Length;
            for (int i = 0; i < massive.Length; i++)
            {
                string[] masiveDivaded = new string[100];
                masiveDivaded = massive[i].Split(' ');
                Tovar tovar = new Tovar();
                tovar.SettterId(Convert.ToInt32(masiveDivaded[0]));
                tovar.SetterName(masiveDivaded[1]);
                tovar.SetValue(Convert.ToInt32(masiveDivaded[2].ToString()));
                tovar.SetPrice(Convert.ToInt32(masiveDivaded[3].ToString()));
                tovar.SetMatrial(masiveDivaded[4]);
                tovar.SetMasa(Convert.ToDouble(masiveDivaded[5]));
                tovar.SetDesk(masiveDivaded[6]);
                tovars[i] = tovar;

            }
            double MassMeb = 0;
            double MassStroi = 0;
            double MassDom = 0;
            double MassTech = 0;
            double MassDeck = 0;
            double MasssInst = 0;
            double MassKrep = 0;
            for (int i = 0; i < tovars.Length; i++)
            {
                if (tovars[i].GetterDesk() == "Мебель")
                {
                    MassMeb += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Стройматериалы")
                {
                    MassStroi += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Товары_для_дома")
                {
                    MassDom += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Садовая_техника")
                {
                    MassTech += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Декор")
                {
                    MassDeck += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Инструменты")
                {
                    MasssInst += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Крепежные_изделия")
                {
                    MassKrep += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }

            }
            double ValMeb = 0;
            double ValStroi = 0;
            double ValDom = 0;
            double ValTech = 0;
            double ValDeck = 0;
            double ValInst = 0;
            double ValKrep = 0;
            for (int i = 0; i < tovars.Length; i++)
            {
                if (tovars[i].GetterDesk() == "Мебель")
                {
                    ValMeb += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Стройматериалы")
                {
                    ValStroi += tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Товары_для_дома")
                {
                    ValDom += tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Садовая_техника")
                {
                    ValTech += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Декор")
                {
                    ValDeck += tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Инструменты")
                {
                    ValInst += tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Крепежные_изделия")
                {
                    ValKrep += tovars[i].GetterValue();
                }

            }
            double CashMeb = 0;
            double CashStroi = 0;
            double CashDom = 0;
            double CashTech = 0;
            double CashDeck = 0;
            double CashInst = 0;
            double CashKrep = 0;
            for (int i = 0; i < tovars.Length; i++)
            {
                if (tovars[i].GetterDesk() == "Мебель")
                {
                    CashMeb += tovars[i].GetterPrice() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Стройматериалы")
                {
                    CashStroi += tovars[i].GetterPrice() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Товары_для_дома")
                {
                    CashDom += tovars[i].GetterPrice() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Садовая_техника")
                {
                    CashTech += tovars[i].GetterPrice() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Декор")
                {
                    CashDeck += tovars[i].GetterPrice() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Инструменты")
                {
                    CashInst += tovars[i].GetterPrice() * tovars[i].GetterValue();
                }
                if (tovars[i].GetterDesk() == "Крепежные_изделия")
                {
                    CashKrep += tovars[i].GetterMasa() * tovars[i].GetterValue();
                }

            }
            if (categoryImportBox.Text == "Мебель")
            {
                int counterMeb = 0;
                worksheet.Range[1, 1].Value = "Отчёт по категории мебель";
                worksheet.Range[2, 1].Value = "ID";
                worksheet.Range[2, 2].Value = "Название";
                worksheet.Range[2, 3].Value = "Масса";
                worksheet.Range[2, 4].Value = "Колличество";
                worksheet.Range[2, 5].Value = "Цена";
                worksheet.Range[2,6].Value = "Материал";
                for (int i = 0; i < tovars.Length; i++)
                {
                    if (tovars[i].GetterDesk() == "Мебель")
                    {
                        worksheet.Range[counterMeb + 3, 1].Value = tovars[i].GetterId().ToString();
                        worksheet.Range[counterMeb + 3, 2].Value = tovars[i].GetterName().ToString();
                        worksheet.Range[counterMeb + 3, 3].Value = tovars[i].GetterMasa().ToString();
                        worksheet.Range[counterMeb + 3, 4].Value = tovars[i].GetterValue().ToString();
                        worksheet.Range[counterMeb + 3, 5].Value = tovars[i].GetterPrice().ToString();
                        worksheet.Range[counterMeb + 3, 6].Value = tovars[i].GetterMaterial().ToString();
                        counterMeb++;
                    }
                }
                counterMeb += 4;
                worksheet.Range[counterMeb, 1].Value = "Общая стоимость";
                worksheet.Range[counterMeb, 2].Value = CashMeb.ToString();
                worksheet.Range[counterMeb+1, 1].Value = "Общая масса";
                worksheet.Range[counterMeb+1, 2].Value = MassMeb.ToString();
                worksheet.Range[counterMeb+2, 1].Value = "Общее количество";
                worksheet.Range[counterMeb+2, 2].Value = ValMeb.ToString();
            }
            if (categoryImportBox.Text == "Стройматериалы")
            {
                int counterBuild = 0;
                worksheet.Range[1, 1].Value = "Отчёт по категории Стройматериалы";
                worksheet.Range[2, 1].Value = "ID";
                worksheet.Range[2, 2].Value = "Название";
                worksheet.Range[2, 3].Value = "Масса";
                worksheet.Range[2, 4].Value = "Колличество";
                worksheet.Range[2, 5].Value = "Цена";
                worksheet.Range[2, 6].Value = "Материал";
                for (int i = 0; i < tovars.Length; i++)
                {
                    if (tovars[i].GetterDesk() == "Стройматериалы")
                    {
                        worksheet.Range[counterBuild + 3, 1].Value = tovars[i].GetterId().ToString();
                        worksheet.Range[counterBuild + 3, 2].Value = tovars[i].GetterName().ToString();
                        worksheet.Range[counterBuild + 3, 3].Value = tovars[i].GetterMasa().ToString();
                        worksheet.Range[counterBuild + 3, 4].Value = tovars[i].GetterValue().ToString();
                        worksheet.Range[counterBuild + 3, 5].Value = tovars[i].GetterPrice().ToString();
                        worksheet.Range[counterBuild + 3, 6].Value = tovars[i].GetterMaterial().ToString();
                        counterBuild++;
                    }
                }
                counterBuild+=4;
                worksheet.Range[counterBuild, 1].Value = "Общая стоимость";
                worksheet.Range[counterBuild, 2].Value = CashStroi.ToString();
                worksheet.Range[counterBuild + 1, 1].Value = "Общая масса";
                worksheet.Range[counterBuild + 1, 2].Value = MassStroi.ToString();
                worksheet.Range[counterBuild + 2, 1].Value = "Общее количество";
                worksheet.Range[counterBuild+2, 2].Value = ValStroi.ToString();
            }
            if (categoryImportBox.Text == "Товары_для_дома")
            {
                int countHome = 0;
                worksheet.Range[1, 1].Value = "Отчёт по категории Товары_для_дома";
                worksheet.Range[2, 1].Value = "ID";
                worksheet.Range[2, 2].Value = "Название";
                worksheet.Range[2, 3].Value = "Масса";
                worksheet.Range[2, 4].Value = "Колличество";
                worksheet.Range[2, 5].Value = "Цена";
                worksheet.Range[2, 6].Value = "Материал";
                for (int i = 0; i < tovars.Length; i++)
                {
                    if (tovars[i].GetterDesk() == "Товары_для_дома")
                    {
                        worksheet.Range[countHome + 3, 1].Value = tovars[i].GetterId().ToString();
                        worksheet.Range[countHome + 3, 2].Value = tovars[i].GetterName().ToString();
                        worksheet.Range[countHome + 3, 3].Value = tovars[i].GetterMasa().ToString();
                        worksheet.Range[countHome + 3, 4].Value = tovars[i].GetterValue().ToString();
                        worksheet.Range[countHome + 3, 5].Value = tovars[i].GetterPrice().ToString();
                        worksheet.Range[countHome + 3, 6].Value = tovars[i].GetterMaterial().ToString();
                        countHome++;
                    }
                }
                countHome+=4;
                worksheet.Range[countHome, 1].Value = "Общая стоимость";
                worksheet.Range[countHome, 2].Value = CashDom.ToString();
                worksheet.Range[countHome + 1, 1].Value = "Общая масса";
                worksheet.Range[countHome + 1, 2].Value = MassDom.ToString();
                worksheet.Range[countHome + 2, 1].Value = "Общее количество";
                worksheet.Range[countHome+2, 2].Value = ValDom.ToString();
            }
            if (categoryImportBox.Text == "Садовая_техника")
            {
                int countGarden = 0;
                worksheet.Range[1, 1].Value = "Отчёт по категории Садовая_техника";
                worksheet.Range[2, 1].Value = "ID";
                worksheet.Range[2, 2].Value = "Название";
                worksheet.Range[2, 3].Value = "Масса";
                worksheet.Range[2, 4].Value = "Колличество";
                worksheet.Range[2, 5].Value = "Цена";
                worksheet.Range[2, 6].Value = "Материал";
                for (int i = 0; i < tovars.Length; i++)
                {
                    if (tovars[i].GetterDesk() == "Садовая_техника")
                    {
                        worksheet.Range[countGarden + 3, 1].Value = tovars[i].GetterId().ToString();
                        worksheet.Range[countGarden + 3, 2].Value = tovars[i].GetterName().ToString();
                        worksheet.Range[countGarden + 3, 3].Value = tovars[i].GetterMasa().ToString();
                        worksheet.Range[countGarden + 3, 4].Value = tovars[i].GetterValue().ToString();
                        worksheet.Range[countGarden + 3, 5].Value = tovars[i].GetterPrice().ToString();
                        worksheet.Range[countGarden + 3, 6].Value = tovars[i].GetterMaterial().ToString();
                        countGarden++;
                    }
                }
                countGarden+=4;
                worksheet.Range[countGarden, 1].Value = "Общая стоимость";
                worksheet.Range[countGarden, 2].Value = CashTech.ToString();
                worksheet.Range[countGarden + 1, 1].Value = "Общая масса";
                worksheet.Range[countGarden + 1, 2].Value = MassTech.ToString();
                worksheet.Range[countGarden + 2, 1].Value = "Общее количество";
                worksheet.Range[countGarden+2, 2].Value = ValTech.ToString();
            }
            if (categoryImportBox.Text == "Декор")
            {
                int countDeckor = 0;
                worksheet.Range[1, 1].Value = "Отчёт по категории Декор";
                worksheet.Range[2, 1].Value = "ID";
                worksheet.Range[2, 2].Value = "Название";
                worksheet.Range[2, 3].Value = "Масса";
                worksheet.Range[2, 4].Value = "Колличество";
                worksheet.Range[2, 5].Value = "Цена";
                worksheet.Range[2, 6].Value = "Материал";
                for (int i = 0; i < tovars.Length; i++)
                {
                    if (tovars[i].GetterDesk() == "Декор")
                    {
                        worksheet.Range[countDeckor + 3, 1].Value = tovars[i].GetterId().ToString();
                        worksheet.Range[countDeckor + 3, 2].Value = tovars[i].GetterName().ToString();
                        worksheet.Range[countDeckor + 3, 3].Value = tovars[i].GetterMasa().ToString();
                        worksheet.Range[countDeckor + 3, 4].Value = tovars[i].GetterValue().ToString();
                        worksheet.Range[countDeckor + 3, 5].Value = tovars[i].GetterPrice().ToString();
                        worksheet.Range[countDeckor + 3, 6].Value = tovars[i].GetterMaterial().ToString();
                        countDeckor++;
                    }
                }
                countDeckor+=4;
                worksheet.Range[countDeckor, 1].Value = "Общая стоимость";
                worksheet.Range[countDeckor, 2].Value = CashDeck.ToString();
                worksheet.Range[countDeckor + 1, 1].Value = "Общая масса";
                worksheet.Range[countDeckor + 1, 2].Value = MassDeck.ToString();
                worksheet.Range[countDeckor + 2, 1].Value = "Общее количество";
                worksheet.Range[countDeckor+2, 2].Value = ValDeck.ToString();
            }
            if (categoryImportBox.Text == "Инструменты")
            {
                int countInstr = 0;
                worksheet.Range[1, 1].Value = "Отчёт по категории Инструменты";
                worksheet.Range[2, 1].Value = "ID";
                worksheet.Range[2, 2].Value = "Название";
                worksheet.Range[2, 3].Value = "Масса";
                worksheet.Range[2, 4].Value = "Колличество";
                worksheet.Range[2, 5].Value = "Цена";
                worksheet.Range[2, 6].Value = "Материал";
                for (int i = 0; i < tovars.Length; i++)
                {
                    if (tovars[i].GetterDesk() == "Инструменты")
                    {
                        worksheet.Range[countInstr + 3, 1].Value = tovars[i].GetterId().ToString();
                        worksheet.Range[countInstr + 3, 2].Value = tovars[i].GetterName().ToString();
                        worksheet.Range[countInstr + 3, 3].Value = tovars[i].GetterMasa().ToString();
                        worksheet.Range[countInstr + 3, 4].Value = tovars[i].GetterValue().ToString();
                        worksheet.Range[countInstr + 3, 5].Value = tovars[i].GetterPrice().ToString();
                        worksheet.Range[countInstr + 3, 6].Value = tovars[i].GetterMaterial().ToString();
                        countInstr++;
                    }
                }
                countInstr+=4;
                worksheet.Range[countInstr, 1].Value = "Общая стоимость";
                worksheet.Range[countInstr, 2].Value = CashInst.ToString();
                worksheet.Range[countInstr + 1, 1].Value = "Общая масса";
                worksheet.Range[countInstr + 1, 2].Value = MasssInst.ToString();
                worksheet.Range[countInstr + 2, 1].Value = "Общее количество";
                worksheet.Range[countInstr+2, 2].Value = ValInst.ToString();
            }
            if (categoryImportBox.Text == "Крепежные_изделия")
            {
                int countCrep = 0;
                worksheet.Range[1, 1].Value = "Отчёт по категории Крепежные_изделия";
                worksheet.Range[2, 1].Value = "ID";
                worksheet.Range[2, 2].Value = "Название";
                worksheet.Range[2, 3].Value = "Масса";
                worksheet.Range[2, 4].Value = "Колличество";
                worksheet.Range[2, 5].Value = "Цена";
                worksheet.Range[2, 6].Value = "Материал";
                for (int i = 0; i < tovars.Length; i++)
                {
                    if (tovars[i].GetterDesk() == "Крепежные_изделия")
                    {
                        worksheet.Range[countCrep + 3, 1].Value = tovars[i].GetterId().ToString();
                        worksheet.Range[countCrep + 3, 2].Value = tovars[i].GetterName().ToString();
                        worksheet.Range[countCrep + 3, 3].Value = tovars[i].GetterMasa().ToString();
                        worksheet.Range[countCrep + 3, 4].Value = tovars[i].GetterValue().ToString();
                        worksheet.Range[countCrep + 3, 5].Value = tovars[i].GetterPrice().ToString();
                        worksheet.Range[countCrep + 3, 6].Value = tovars[i].GetterMaterial().ToString();
                        countCrep++;
                    }
                }
                countCrep+=4;
                worksheet.Range[countCrep, 1].Value = "Общая стоимость";
                worksheet.Range[countCrep, 2].Value = CashKrep.ToString();
                worksheet.Range[countCrep + 1, 1].Value = "Общая масса";
                worksheet.Range[countCrep + 1, 2].Value = MassKrep.ToString();
                worksheet.Range[countCrep + 2, 1].Value = "Общее количество";
                worksheet.Range[countCrep+2, 2].Value = ValKrep.ToString();
            }


            worksheet.AllocatedRange.AutoFitColumns();
            workbook.SaveToFile("Отчет_Категория.xls", ExcelVersion.Version2007);
            MessageBox.Show("Отчет импортирован в Excel", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult result = MessageBox.Show("Хотите открыть отчет Excel?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var newProcessInfo = new ProcessStartInfo();
                newProcessInfo.FileName = @"Excel.exe";
                newProcessInfo.Arguments = @"Отчет_Категория.xls";
                Process process = new Process();
                process.StartInfo = newProcessInfo;
                process.Start();
                process.WaitForExit();

            }
            if (result == DialogResult.No)
            {

            }
        }

        Point lastPoint;

        private void Report_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Report_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
