using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graph = graphBox.CreateGraphics();
            graph.Clear(Color.White);
            
            Graphics histo = histoBox.CreateGraphics();
            histo.Clear(Color.White);


            int hackerNum = int.Parse(hacker.Text);
            int serverNum = int.Parse(server.Text);
            float probNum = float.Parse(probability.Text);


            float lineWidth = graphBox.Width / (float)serverNum;
            float lineHeight = graphBox.Height / (float)serverNum;

            List<int> totalScores = DrawGraph(graph, serverNum, hackerNum, probNum, lineWidth, lineHeight);
            DrawHistogram1(histo, hackerNum, serverNum, totalScores, lineHeight);

        }


        private List<int> DrawGraph(Graphics graph, int servers, int hackers, float prob, float width, float height)
        {
            List<int> totalscores = new List<int>();

            float lineWidth = width / servers;
            float stepHeight = (float)Math.Sqrt(1f / servers);  //sqared step

            Random rnd = new Random();
            

            for (int i = 0; i < hackers; i++)
            {
                Pen p = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
                PointF point = new PointF(0, graphBox.Height / 2);
                int score = 0;

                for (int j = 0; j < servers; j++) {

                    if (rnd.NextDouble() < prob)
                    {
                        PointF up = new PointF(point.X, point.Y - stepHeight * height);
                        graph.DrawLine(p, point, up);
                        point = up;
                        PointF upRight = new PointF(point.X + width, point.Y);
                        graph.DrawLine(p, point, upRight);
                        point = upRight;
                        score++;
                    }
                    else
                    {
                        PointF down = new PointF(point.X, point.Y + stepHeight * height);
                        graph.DrawLine(p, point, down);
                        point = down;
                        PointF downRight = new PointF(point.X + width, point.Y);
                        graph.DrawLine(p, point, downRight);
                        point = downRight;
                    }
                
                }
                totalscores.Add(score);

            }
            return totalscores;
        }

        private void DrawHistogram1(Graphics graph, int hackers, int servers, List<int> scores, float height)
        {
            Pen p = new Pen(Color.White);

            Pen penna = new Pen(Color.Black);

            var g = scores.GroupBy(i => i).OrderBy(group => group.Key);


            var m1 = scores.GroupBy(i => i).OrderByDescending(group => group.Count()).First().Count();

            int diffScores = scores.Distinct().Count();

            float scoreHeigth = (histoBox.Width * 0.3f) / (float)m1;
            float scoreWidth = (histoBox.Height * 0.6f) / (float)diffScores;

            float startPoint = histoBox.Height * 0.9f;

            foreach (var grp in g)
            {

                SolidBrush brush = new SolidBrush(Color.Coral);


                RectangleF rect = new RectangleF(0, graphBox.Height - height * grp.Key - height / 2, scoreHeigth * grp.Count(), height);

                graph.FillRectangle(brush, rect);
                graph.DrawRectangle(p, 0f, graphBox.Height - height * grp.Key - height / 2, scoreHeigth * grp.Count(), height);

            }
        }
    }
}
