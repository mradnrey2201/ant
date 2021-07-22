using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//заметки
namespace itog_zach
{
    public partial class frm : Form
    {

        ///ПЕРЕМЕННЫЕ ДЛЯ МУРАВЬИНОГО АЛГОРИТМА//////////////////////////////////////////////////////////
        int[] path, tabu, risovanie;
        double[] prob;
        int curCity, nextCity, pathIndex;
        double pathLength;
        const int  MAX_CITIES = 100, CITY_POINT_RADIUS = 5, Q = 1000;
        const double A = 1.0, B = 1.0, RO = 0.5;
        //  int[,] tMasCitiesInt=new int[1, MAX_CITIES];
        // double[,] tMasCitiesDouble = new double[1, MAX_CITIES];

        //  public struct tCity
        // {
        //    private int x, y;
        //     public tCity(int x,int y)
        //     {
        //         this.x=x;
        //        this.y=y;
        //     }
        //  }
        // public struct tAnt
        // {
        //      private int[] path, tabu;

        //      private double[] prob;
        //      private int curCity, nextCity, pathIndex;
        //     private  double pathLength;
        //    public tAnt(int[] path, int [] tabu, int curCity, int nextCity, int pathIndex, double[] prob, double pathLength)
        /* {
             for (int i= 0; i < MAX_CITIES; i++)
             {
                 this.path[i] = path[i];
                 this.curCity = curCity;
                 this.nextCity = nextCity;
                 this.pathIndex = pathIndex;
                 this.pathLength = pathLength;
             }

         }*/


        // public tAnt(int curCity)
        // {
        //      curCity = curCity;
        //   }

        // }
        // public static tAnt[] ants = new tAnt[MAX_CITIES];
        // tCity[] cities = new tCity[MAX_CITIES];
        double[,] u, rasstoyanie, pheromones;

        int[] bestPath;
        int nCities, nAnts, citySelected;
        double bestPathLenght;
        // Book[] books = new Book[5000];
        // Book[] books = new Book[5000];
        //for (int i = 0; i< 10; i++)
        //{
        //   books[i].title = "Книга " + i.ToString();
        //   books[i].price = i* 10;
        //}

        double[,] coord, killog, coord_easy;













        

        //пременные ------------------------
        int factorial, n, m, x_home, y_home;   // значение факториала

        private void btn_ant_Click(object sender, EventArgs e)
        {
            AntSimulate();
            // g.Clear(Color.Transparent);
            //  picturebox1.Invalidate();
            Refresh();


            var gr= picturebox1.CreateGraphics();
           
            Pen p1 = new Pen(Color.Lime, 2.0f);
             gr.DrawLine(p1, Convert.ToInt16(coord[0, 0] * 2), Convert.ToInt16(coord[1, 0]), Convert.ToInt16(coord[0, path[1]] * 2), Convert.ToInt16(coord[1, path[1]]));
            for(int i = 1; i < 9;i++)
            {
                if (path[i + 1] == 0)
                {
                    p1.Color = Color.Blue;
                    g.DrawLine(p1, Convert.ToInt16(coord[0, path[i]] * 2), Convert.ToInt16(coord[1, path[i]]), Convert.ToInt16(coord[0, path[i] + 1] * 2+20), Convert.ToInt16(coord[1, path[i] + 1]+50));
                }
                else
                {
                    p1.Color = Color.Lime;
                    g.DrawLine(p1, Convert.ToInt16(coord[0, path[i]] * 2), Convert.ToInt16(coord[1, path[i]]), Convert.ToInt16(coord[0, path[i] + 1] * 2), Convert.ToInt16(coord[1, path[i] + 1]));
                }
              
           
            }

            bestPathLenght= Math.Round(bestPathLenght, 2);

            lbl_hard.Text = bestPathLenght.ToString();
           
        }

        private void picturebox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();

        private void pic_home_Click(object sender, EventArgs e)
        {

        }



        //---------------------------------
        //массивы---------------------------
        Graphics g;

        private void btn_simple_Click(object sender, EventArgs e)
        {//счет порядка
            Refresh(); 
            double distance = 0;
            Boolean next = false;
            double ves;
             g = picturebox1.CreateGraphics();
            Pen p = new Pen(Color.Pink, 2.0f);
            g.DrawLine(p, Convert.ToInt16(coord[0, 0] * 2), Convert.ToInt16(coord[1, 0]), Convert.ToInt16(coord[0, 1] * 2), Convert.ToInt16(coord[1, 1]));
        
            ves = killog[0, 0] + killog[0, 1];
            if (ves < Convert.ToInt16(txt_gruzopod.Text))
            {
                next = true;
            }
            for (int i = 1; i < n; i++)
            {
                if (next)
                {
                    p.Color = Color.Red;
                    
                    g.DrawLine(p, Convert.ToInt16(coord[0, i] * 2), Convert.ToInt16(coord[1, i]), Convert.ToInt16(coord[0, i + 1] * 2), Convert.ToInt16(coord[1, i + 1]));
                    distance += rasstoyanie[0, i];
                    if (ves + killog[0, i + 1] > Convert.ToInt16(txt_gruzopod.Text))
                    {
                        next = false;
                    }
                    else
                    {
                        ves += killog[0, i + 1];
                    }
                }
                else
                {
                    p.Color = Color.Black;
                    g.DrawLine(p, Convert.ToInt16(coord[0, i] * 2) + 10, Convert.ToInt16(coord[1, i]) + 10, Convert.ToInt16(coord[0, 0] * 2) + 10, Convert.ToInt16(coord[1, 0]) + 10);
                   
                    distance += rasstoyanie[0, i];
                    p.Color = Color.Red;
                    g.DrawLine(p, Convert.ToInt16(coord[0, 0] * 2) + 50, Convert.ToInt16(coord[1, 0]) + 50, Convert.ToInt16(coord[0, i + 1] * 2) + 50, Convert.ToInt16(coord[1, i + 1]) + 50);
                  
                   
                    next = true;
                    ves = 0;
                }



            }
            p.Color = Color.Blue;
            g.DrawLine(p, Convert.ToInt16(coord[0, n - 1] * 2), Convert.ToInt16(coord[1, n - 1]), Convert.ToInt16(coord[0, 0] * 2), Convert.ToInt16(coord[1, 0]));
            distance += coord[0, 4];





            distance = Math.Round(distance, 2);

            lbl_simple.Text = distance.ToString();
        }

        private void btn_tochki_Click(object sender, EventArgs e)
        {
            picturebox1.Controls.Clear();
            picturebox1.Invalidate();
            n = Convert.ToInt16(txt_kolvo.Text);
            x_home = pic_home.Location.X;
            y_home = pic_home.Location.Y;
            for (int i = 1; i < n; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(50, 50);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                //pic.Location = new Point(x_home, y_home);
                pic.Location = new Point(Convert.ToInt16(coord[0, i] * 2), Convert.ToInt16(coord[1, i]));
                var bmp = new Bitmap(itog_zach.Properties.Resources.znak);
                pic.Image =bmp;
                pic.BackColor = Color.Transparent;

                picturebox1.Controls.Add(pic);
            }
            // pb.SizeMode = PictureBoxSizeMode.StretchImage;
            // flowLayoutPanel1.Controls.Add(pb);
            // picturebox.Add(pb);


        }

        //-----------------------------------
        public frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // рисование видео 
        private void btn_enter_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txt_kolvo.Text);
            path = new int[n*2];
            tabu = new int[n+1];
            prob = new double[n + 1];
            pheromones = new double[n, n];
            rasstoyanie = new double[n, n];
            u = new double[n, n];
            //кол-во вариантов

            dgv_coord.Rows.Clear();
            for (int i = 1; i < n + 1; i++)
            {
                dgv_coord.Rows.Add(new DataGridViewRow());
            }

            factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            factorial = factorial / 2;

            lbl_kolvovar.Text = factorial.ToString();
            //---------
            //DGV COORDINATES
            coord = new double[2, n + 1];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    coord[i, j] = rnd.Next(10, 400);
                }
            }
            coord[0, 0] = 0;
            coord[1, 0] = 0;
            //DGV COORD
            dgvPrint(coord, dgv_coord, 0, null);

            //----------------
            //DGV KILLOGRAMS
            //кол-во вариантов
            m = Convert.ToInt16(txt_gruzopod.Text);
            dgv_killog.Rows.Clear();
            for (int i = 1; i < n + 1; i++)
            {
                dgv_killog.Rows.Add(new DataGridViewRow());
            }
            killog = new double[1, n + 1];
            for (int i = 0; i < n; i++)
            {
                killog[0, i] = rnd.Next(5, m);
            }
            dgvPrint(killog, dgv_killog, 0, null);
            //DGV RASSTOYANIE
            dgv_rasstoyanie.Rows.Clear();
            dgv_rasstoyanie.Columns.Clear();
            for (int i = 1; i < n + 1; i++)
            {

                dgv_rasstoyanie.Columns.Add(new DataGridViewTextBoxColumn());
            }
            for (int i = 1; i < n + 1; i++)
            {
                dgv_rasstoyanie.Rows.Add(new DataGridViewRow());
            }
            //rasstoyanie = new double[n, n];
            double x1, x2, y1, y2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) { rasstoyanie[i, j] = 0; }
                    else
                    {
                        x1 = coord[0, i];
                        y1 = coord[1, i];
                        x2 = coord[0, j];
                        y2 = coord[1, j];
                        rasstoyanie[i, j] = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                    }
                }
            }
            dgvPrint(rasstoyanie, dgv_rasstoyanie, 0, null);
        }
        //VOIDES====================================================================================================================================
        // DGV PRINT-----------------
        void dgvPrint(double[,] mas, DataGridView dgv, int bound, string zag)
        {
            int up1 = mas.GetUpperBound(0);
            int up2 = mas.GetUpperBound(1);

            dgv.Rows.Clear();
            for (int i = 1; i <= up2; i++)
            {
                dgv.Rows.Add(new DataGridViewRow());
            }
            if (bound > 0)
            {
                dgv[0, 0].Value = zag;
                dgv[0, 1].Value = "Вероятность f/s";
            }

            for (int i = bound; i <= up1 + bound; i++)
            {
                for (int j = 0; j <= up2; j++)
                {
                    dgv[i, j].Value = mas[i - bound, j].ToString("0.##");
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////voids and functions/////////////////////////////////
        double correct = 0;
        public void CalcVisibility()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    u[i, j] = 1 / rasstoyanie[i, j];
                }
            }
        }
        //---------------------------------------------------------------------------
        public void InitPheromone()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    pheromones[i, j] = 1.0 / (double)n;
                }
            }
        }
        //---------------------------------------------------------------------------
        public void InitAnts()
        {

            //int iCity;
            //  nAnts = n;
            for (int k = 0; k < n; k++)
            {
                path[k] = 0;
                tabu[k] = 0;
                prob[k] = 0;
            }
        }
        //---------------------------------------------------------------------------
        //function antProduct!!!!!!!!!!!!
        private double AntProduct(int a, int b)
        {


            // x =(Math.Pow(u[a, b],A))*(Math.Pow(pheromones[a, b], B));
            //задать вопрос тут
            if ((a != 0) || (b != 0))
            {

                double x1 = 0;
                x1 = u[a, b] * pheromones[a, b];
                return x1;
            }
            else
            {
                return 0.000001;
            }
        }

        //---------------------------------------------------------------------------
        private void Danger(int i, int j)
        {
            u[i, j] = u[i, j] / 2;
        }
        bool yorn;
        private void CalcAntProbabiliries(int i, int k, bool yorn)
        {

            double denom, d;
            denom = 0;
            for (int j = 0; j < n; j++)
            {
                if (tabu[j] == 0)
                {
                    denom += (double)AntProduct(i, j);
                }
            }
            for (int j = 0; j < n; j++)
            {
                if (tabu[j] == 0)
                {
                    if (yorn)
                    {
                        prob[j] = (double)AntProduct(i, j) / (double)denom;
                    }
                    else
                    {
                        prob[j] = (double)AntProduct(i, j) / (double)(2 * denom);
                    }
                }
                else
                {
                    prob[j] = 0;
                }
            }

        }
        //----------------------------------------------------------------------------
        private int AntSelectNextCity(int i, int k, bool yorn)
        {
            int c = 0;
            int j, icity;
            double p, p0;
            CalcAntProbabiliries(i, k, yorn);
            p = rnd.Next(1, 1000);
            p /= 1000;
            p0 = 0;
            icity = 0;
            while (p0 <= p && icity < n)
            {
                icity += 1;
                lbl_hard.Text = icity.ToString();
                p0 += prob[icity];

            }
            if (icity == n)
            { icity -= 1;
                if (tabu[icity] == 1) { 
                while (tabu[icity] == 1 && icity>0)
                {
                    icity--;
                }
               }
            }
            return icity ;
        }
        //--------------------------------------------------------------------------
        //ДОДЕЛАТЬ ДО КОНЦА
        private void AntMakePath(int k)
        {
            pathIndex = 0;
            correct = 0;
            for (int i = 0; i < n; i++)
            {
                if ((correct + killog[0, i]) <= 25)
                {
                    yorn = true;
                    correct += killog[0, i];
                }
                else
                {
                    correct = 0;
                    yorn = false;
                }


                nextCity = AntSelectNextCity(curCity, k, yorn);
                if (!yorn)
                {
                    path[pathIndex] = 0;
                    pathIndex += 1;
                }
                path[pathIndex] = nextCity;
             
                pathIndex += 1;


               
                tabu[nextCity] = 1;



                pathLength += rasstoyanie[curCity, nextCity];
                curCity = nextCity;

                //pathLength+=rasstoyanie[]
            }
            pathLength += rasstoyanie[curCity, path[0]];
        }
        //----------------------------------------------------------------------------
        private void CalcPheromones()
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    pheromones[i, j] = (1 - RO) * pheromones[i, j];
                    for (int l = 0; l < n; l++)
                    {
                        pheromones[i, j] += Q / pathLength;
                    }
                }
            }
        }
        //---------------------------------------------------------------------------
        //
        private void AntSimulate()
        {

            CalcVisibility();
            InitPheromone();
            bestPathLenght = 10000000;
            for (int t = 0; t <Convert.ToInt16(textBox1.Text); t++)
            {
                InitAnts();
                for (int k = 0; k < n; k++)
                {
                    for (int u = 0; u < n; u++)
                    {
                        tabu[u] = 0;
                            }
                        AntMakePath(k);

                    if (pathLength < bestPathLenght)
                    {
                        bestPathLenght = pathLength;
                        
                        bestPath = path;

                    }
                    
                    CalcPheromones();
                    pathLength = 0;
                }
            }
        }


    }
}
