using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistician
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        readonly string dataPathFilePath = Environment.CurrentDirectory.ToString() + "\\Path.txt";
        static string dataPath = "";
        const int dataTypeCount = 12;
        bool readyToChange = false;
        // chart
        const int monthCount = 12;
        readonly private string[] xList = new string[monthCount] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        const int chartCount = 2;
        Chart[] charts = new Chart[chartCount];
        // data
        static int dataCount = 0;
        List<string> date = new List<string>();
        HashSet<int> dateYears = new HashSet<int>();
        List<int> duration = new List<int>();
        List<int> gamePlayer = new List<int>();
        List<int> gameControl = new List<int>();
        List<int> bossTitle = new List<int>();
        List<int> player1FoundCardsCount = new List<int>();
        List<int> player2FoundCardsCount = new List<int>();
        List<int> player1UsedCardsCount = new List<int>();
        List<int> player2UsedCardsCount = new List<int>();
        List<int> player1DrewShapesCount = new List<int>();
        List<int> player2DrewShapesCount = new List<int>();
        List<int> winner = new List<int>();

        int[] yListDuration = new int[monthCount];
        int[] yList1FoundCardsCount = new int[monthCount];
        int[] yList2FoundCardsCount = new int[monthCount];
        int[] yList1UsedCardsCount = new int[monthCount];
        int[] yList2UsedCardsCount = new int[monthCount];
        int[] yList1DrewShapesCount = new int[monthCount];
        int[] yList2DrewShapesCount = new int[monthCount];

        private void FrmMain_Load(object sender, EventArgs e)
        {
            charts[0] = Chart1;
            charts[1] = Chart2;
            charts[0].ChartAreas[0].AxisX.MajorGrid.LineDashStyle = charts[1].ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            charts[0].ChartAreas[0].AxisY.MajorGrid.LineDashStyle = charts[1].ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            charts[0].Series[0].IsValueShownAsLabel = charts[1].Series[0].IsValueShownAsLabel = true;
            if (File.Exists(dataPathFilePath))
            {
                StreamReader steamReader = new StreamReader(dataPathFilePath);
                string str = steamReader.ReadLine();
                steamReader.Close();
                steamReader.Dispose();
                if (File.Exists(str))
                {
                    ReadData(str);
                }
            }
        }

        private void LoadData(string data)
        {
            string[] dataLine = data.Split('\n');
            int dataLineLength = dataLine.Length - 1;
            string[,] dataLineContent = new string[dataLineLength, dataTypeCount];
            dataCount = 0;
            for (int i = 0; i < dataLineLength; i++, dataCount++)
            {
                string[] line = dataLine[i].Split(',');
                date.Add(line[0]);
                //dateYears.Add(Convert.ToInt32(dataLineContent[i, 0].Split('/')[2]));
                dateYears.Add(Convert.ToInt32(line[0].Split('/')[2]));
                duration.Add(Convert.ToInt32(line[1]));
                gamePlayer.Add(Convert.ToInt32(line[2]));
                gameControl.Add(Convert.ToInt32(line[3]));
                bossTitle.Add(Convert.ToInt32(line[4]));
                player1FoundCardsCount.Add(Convert.ToInt32(line[5]));
                player2FoundCardsCount.Add(Convert.ToInt32(line[6]));
                player1UsedCardsCount.Add(Convert.ToInt32(line[7]));
                player2UsedCardsCount.Add(Convert.ToInt32(line[8]));
                player1DrewShapesCount.Add(Convert.ToInt32(line[9]));
                player2DrewShapesCount.Add(Convert.ToInt32(line[10]));
                winner.Add(Convert.ToInt32(line[11]));
                for (int j = 0; j < dataTypeCount; j++)
                {
                    dataLineContent[i, j] = line[j];
                }
            }
            // reset combo
            Combo_Year.Items.Clear();
            foreach (int year in dateYears)
            {
                Combo_Year.Items.Add(year);
            }
            // successfully load data
            if (Combo_Year.Items.Count > 0)
            {
                Combo_Year.SelectedIndex = Combo_Month.SelectedIndex = Combo_DataTarget.SelectedIndex = Combo_GamePlayer.SelectedIndex = Combo_GameControl.SelectedIndex = 0;
                readyToChange = true;
                refreshGraphToolStripMenuItem.Enabled = true;
                PrintData();
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void SetChartTitle(string str)
        {
            charts[0].Titles[0].Text = Combo_Year.SelectedItem.ToString() + " - Player1 - " + str;
            charts[1].Titles[0].Text = Combo_Year.SelectedItem.ToString() + " - Player2 - " + str;
        }

        private void PrintData()
        {
            for (int i = 0; i < monthCount; i++)
            {
                yListDuration[i] = yList1FoundCardsCount[i] = yList2FoundCardsCount[i] =
                    yList1UsedCardsCount[i] = yList2UsedCardsCount[i] = yList1DrewShapesCount[i] = yList2DrewShapesCount[i] = 0;
            }
            for (int i = 0; i < dataCount; i++)
            {
                if (date[i].Split('/')[2] == Combo_Year.SelectedItem.ToString())
                {
                    int currentMonth = Convert.ToInt32(date[i].Split('/')[0]) - 1;
                    yListDuration[currentMonth] += duration[i];
                    yList1FoundCardsCount[currentMonth] += player1FoundCardsCount[i];
                    yList2FoundCardsCount[currentMonth] += player2FoundCardsCount[i];
                    yList1UsedCardsCount[currentMonth] += player1UsedCardsCount[i];
                    yList2UsedCardsCount[currentMonth] += player2UsedCardsCount[i];
                    yList1DrewShapesCount[currentMonth] += player1DrewShapesCount[i];
                    yList2DrewShapesCount[currentMonth] += player2DrewShapesCount[i];
                }
            }
            switch (Combo_DataTarget.SelectedIndex)
            {
                case 0:
                    charts[0].Series["SeriesPrice"].Points.DataBindXY(xList, yListDuration);
                    charts[1].Series["SeriesPrice"].Points.DataBindXY(xList, yListDuration);
                    SetChartTitle("Duration");
                    break;
                case 1:
                    charts[0].Series["SeriesPrice"].Points.DataBindXY(xList, yList1FoundCardsCount);
                    charts[1].Series["SeriesPrice"].Points.DataBindXY(xList, yList2FoundCardsCount);
                    SetChartTitle("Found cards count");
                    break;
                case 2:
                    charts[0].Series["SeriesPrice"].Points.DataBindXY(xList, yList1UsedCardsCount);
                    charts[1].Series["SeriesPrice"].Points.DataBindXY(xList, yList2UsedCardsCount);
                    SetChartTitle("Used cards count");
                    break;
                case 3:
                    charts[0].Series["SeriesPrice"].Points.DataBindXY(xList, yList1DrewShapesCount);
                    charts[1].Series["SeriesPrice"].Points.DataBindXY(xList, yList2DrewShapesCount);
                    SetChartTitle("Drew shapes count");
                    break;
            }
        }

        private void ReadData(string path)
        {
            StreamReader steamReader = new StreamReader(Lbl_DataPath.Text = dataPath = path);
            LoadData(steamReader.ReadToEnd());
            steamReader.Close();
            steamReader.Dispose();
        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Import data",
                Filter = "TXT|*.txt",
                FileName = ""
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
            {
                ReadData(openFileDialog.FileName);
            }
            openFileDialog.Dispose();
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            PrintData();
        }

        private void Combo_GamePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Combo_GamePlayer.SelectedIndex)
            {
                case 0:
                    SplitContainer.Panel2Collapsed = true;
                    break;
                case 1:
                    SplitContainer.Panel1Collapsed = true;
                    break;
                case 2:
                    SplitContainer.Panel1Collapsed = SplitContainer.Panel2Collapsed = false;
                    break;
            }
        }

        private void Combo_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readyToChange)
            {
                PrintData();
            }
        }

        private void Combo_DataTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readyToChange)
            {
                PrintData();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintData();
        }

        private void aboutStatisticianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Statistician\n\nalpha\n\nAnthor: Zhenghao Li");
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // save data path file path
            try
            {
                FileStream fileStream = new FileStream(dataPathFilePath, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
                streamWriter.Write(dataPath);
                streamWriter.Flush();
                streamWriter.Close();
                fileStream.Close();
            }
            catch { }
        }
    }
}
