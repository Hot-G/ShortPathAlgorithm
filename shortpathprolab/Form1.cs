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

namespace shortpathprolab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = MapImage.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(drawcolor, 3);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        public struct Position
        {
            public double x;
            public double y;
        }

        Random rastgele = new Random();
        string[] cityname = new string[81];
        Position[] citypositions = new Position[81];
        double[,] SolvedCityDistance = new double[81, 81];
        double[,] finaluzaklik;
        private Graphics g;
        Color drawcolor = new Color();
        private Pen pen;
        List<int> visiting = new List<int>();
        List<int> visitcompleted = new List<int>();

        private int FindCityPlate(string name)
        {
            for (int i = 0; i < 81; i++)
                if (name == cityname[i])
                    return i;

            return -1;
        }

        void Dijkstra(double[,] cost, int startnode, int endnode)
        {
            double[] distance = new double[81];
            double[] pred = new double[81];
            bool[] visited = new bool[81];
            int count, nextnode = 0, i, j;
            double mindistance;

            for (i = 0; i < 81; i++)
            {
                distance[i] = cost[startnode, i];
                pred[i] = startnode;
                visited[i] = false;
            }

            distance[startnode] = 0;
            visited[startnode] = true;
            count = 1;
            while (count < 80)
            {
                mindistance = double.PositiveInfinity;

                for (i = 0; i < 81; i++)
                    if (distance[i] < mindistance && !visited[i])
                    {
                        mindistance = distance[i];
                        nextnode = i;
                    }

                visited[nextnode] = true;

                for (i = 0; i < 81; i++)
                    if (!visited[i])
                        if (mindistance + cost[nextnode, i] < distance[i])
                        {
                            distance[i] = mindistance + cost[nextnode, i];
                            pred[i] = nextnode;
                        }
                count++;
            }

            j = endnode;

            List<int> temp = new List<int>();
            temp.Add(j);
            do
            {
                j = Convert.ToInt32(pred[j]);
                temp.Add(j);
            } while (j != startnode);
            for (int l = temp.Count - 2; l >= 0; l--)
                visitcompleted.Add(temp[l]);

        }

        //TÜM ŞEHİRLERİN BİRBİRLERİNE OLAN UZAKLIĞI
        public static void Solve(ref double[,] matrix)
        {
            for (int i = 0; i < 81; i++)
            {
                for (int j = 0; j < 81; j++)
                {
                    for (int k = 0; k < 81; k++)
                    {
                        matrix[j, k] = Math.Min(matrix[j, k], matrix[j, i] + matrix[i, k]);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ŞEHİR EKLEME PANELİNİ MERKEZE AL
            AddCityPanel.Location = new Point(this.Width / 2 - 150, this.Height / 2 - 235);

            string[] lines = File.ReadAllLines(@"komsu.txt");

            //HARİTA ÜZERİNDEKİ KONUMLARI ÇEK
            string[] positionlines = File.ReadAllLines(@"cityposition.txt");

            for (int i = 0, y = 0; i < 81; i++, y += 2)
            {
                citypositions[i].x = Convert.ToDouble(positionlines[y]);
                citypositions[i].y = Convert.ToDouble(positionlines[y + 1]);
            }

            string[] uzaklıklar = File.ReadAllLines(@"mesafe.txt");
            finaluzaklik = new double[81, 81];

            for (int i = 0; i < lines.Length; i++)
            {
                cityname[i] = lines[i].Split(',')[0];
                CityNames.Items.Add(cityname[i]);
            }

            CityNames.SelectedIndex = 0;

            for (int i = 0; i < 81; i++)
            {
                for (int j = 0; j < 81; j++)
                {
                    finaluzaklik[i, j] = double.PositiveInfinity;
                }
                string[] sehirler = lines[i].Split(',');
                string[] tempuzaklik = uzaklıklar[i].Split(' ');
                for (int k = 0; k < sehirler.Length; k++)
                {
                    finaluzaklik[i, FindCityPlate(sehirler[k])] = Convert.ToDouble(tempuzaklik[k]);
                }
            }

            for (int i = 0; i < 81; i++)
                for (int j = 0; j < 81; j++)
                    SolvedCityDistance[i, j] = finaluzaklik[i, j];

            //ŞEHİRLERİN BİRBİRLERİNE OLAN UZAKLIKLARINI BUL
            Solve(ref SolvedCityDistance);

        }

        private void addcitytolistBtn_Click(object sender, EventArgs e)
        {
            if (Array.IndexOf(cityname, CityNames.SelectedItem) > -1 && visiting.Count < 10 && !visiting.Contains(CityNames.SelectedIndex) && CityNames.SelectedIndex != 40)
            {
                CityList.Items.Add(CityNames.SelectedItem);
                visiting.Add(CityNames.SelectedIndex);
            }
        }

        private void RemoveCityToListBtn_Click(object sender, EventArgs e)
        {
            int selectedindex = CityList.SelectedIndex;
            if(selectedindex != -1)
            {
                CityList.Items.RemoveAt(selectedindex);
                visiting.RemoveAt(selectedindex);
            }
        }

        int selectedcity;
        int nextcity;
        double mindistance;

        private void FindPathBtn_Click(object sender, EventArgs e)
        {
            AddCityPanel.Visible = false;
            DrawPathBorder.Visible = true;
            drawcolor = Color.FromArgb(255,rastgele.Next(0, 255), rastgele.Next(0, 255), rastgele.Next(0, 255));
            pen.Color = drawcolor;
            VisitedCityList.Items.Add("*** GÜZERGAH ***");
            visitcompleted.Add(40);
            selectedcity = 40;
            int n = visiting.Count;

            //******** EN KISASINI BUL **********//
            for (int j = 0;j < n; j++)
            {
                mindistance = double.PositiveInfinity;
                for (int i = 0; i < visiting.Count; i++)
                {
                    if (SolvedCityDistance[selectedcity, visiting[i]] < mindistance)
                    {
                        mindistance = SolvedCityDistance[selectedcity, visiting[i]];
                        nextcity = visiting[i];
                    }
                }

                Dijkstra(finaluzaklik, selectedcity, nextcity);
                visiting.Remove(nextcity);
                selectedcity = nextcity;
            }

            Dijkstra(finaluzaklik, selectedcity, 40);

            for (int i = 0; i < visitcompleted.Count; i++)
            {
                VisitedCityList.Items.Add(cityname[visitcompleted[i]]);
            }
            counter = 0;
            DrawTimer.Start();
        }
        int counter;
        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            g.DrawLine(pen, Convert.ToInt64(citypositions[visitcompleted[counter]].x * MapImage.Width), Convert.ToInt64(citypositions[visitcompleted[counter]].y * MapImage.Height), Convert.ToInt64(citypositions[visitcompleted[counter + 1]].x * MapImage.Width), Convert.ToInt64(citypositions[visitcompleted[counter + 1]].y * MapImage.Height));
            counter++;
            VisitedCityList.SelectedIndex = counter + 1;
            if (CityList.Items.Contains(cityname[visitcompleted[counter]]))
            {
                g.DrawString(cityname[visitcompleted[counter]], new Font("Arial", 12, FontStyle.Bold),new SolidBrush(drawcolor), new Point(Convert.ToInt32(citypositions[visitcompleted[counter]].x * MapImage.Width), Convert.ToInt32(citypositions[visitcompleted[counter]].y * MapImage.Height - 20)));
                g.DrawRectangle(pen, Convert.ToInt32(citypositions[visitcompleted[counter]].x * MapImage.Width) - 3, Convert.ToInt32(citypositions[visitcompleted[counter]].y * MapImage.Height) - 3, 6, 6);
                drawcolor = Color.FromArgb(255,rastgele.Next(0, 255), rastgele.Next(0, 255), rastgele.Next(0, 255));
                pen.Color = drawcolor;
            }

            if (counter == visitcompleted.Count- 1)
                DrawTimer.Stop();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DrawTimer.Stop();
            CityList.Items.Clear();
            VisitedCityList.Items.Clear();
            visiting.Clear();
            visitcompleted.Clear();
            DrawPathBorder.Visible = false;
            AddCityPanel.Visible = true;
        }
    }
}
