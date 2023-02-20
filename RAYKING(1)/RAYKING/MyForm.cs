using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RAYKING
{
    public partial class MyForm : Form
    {
        static int direction, forward;
        Scene scene;
        Player p;
        Bitmap bmp;
        static Graphics g;
        static Canvas c;
        int step;
        List<float> distances;
        float max;

        public MyForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            SceneCreator creator;

            creator         = new SceneCreator();
            step            = 3;
            p               = new Player(new PointF(100, 400), new PointF(100, 320));            
            c               = new Canvas(PCT_VIEW.Width/2, PCT_VIEW.Height/2);
            PCT_VIEW.Image  = c.BMP;

            bmp             = new Bitmap(PCT_SCENE.Width, PCT_SCENE.Height);
            g               = Graphics.FromImage(bmp);
            PCT_SCENE.Image = bmp;

            scene           = creator.scene;

            Render();
        }

        public void Render()
        {
            g.Clear(Color.Black);
            for (int f = 0; f < scene.Figures.Count; f++)
            { 
                for(int l= 0;l<scene.Figures[f].Lines.Count;l++)
                {
                    g.DrawLine(Pens.Gray, scene.Figures[f].Lines[l].a, scene.Figures[f].Lines[l].b);
                }
            }
            DrawPlayer();

            Verify();
            PCT_SCENE.Invalidate();
        }

        private void DrawPlayer()
        {
            g.FillEllipse(Brushes.Red, p.Pos.X - 3, p.Pos.Y - 3, 6, 6);
            for (int i = 0; i < p.looks.Count; i++)
            {
                g.DrawLine(Pens.Yellow, p.Pos, p.looks[i]);
            }
        }

        private void PCT_SCENE_MouseMove(object sender, MouseEventArgs e)
        {
            LBL_STATUS.Text = e.Location.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    direction -= step;
                    UpdateRotation();
                    break;
                case Keys.Right:
                    direction += step;
                    UpdateRotation();
                    break;
                case Keys.Up:
                    forward += step;
                    UpdatePosition();
                    break;
                case Keys.Down:
                    forward -= step;
                    UpdatePosition();
                    break;
                case Keys.Space:
                    break;
            }
            Render();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateRotation()
        {
            p.LookAt = Util.Instance.Rotate(p.Pos, p.LookAt, direction);
            p.UpdateRotations();
            direction = 0;
        }

        private void UpdatePosition()
        {
            float f  = (float)forward / 50;
            p.Pos    = Util.Instance.NextStep(p.Pos, p.LookAt, f);// update position of entity
            p.LookAt = Util.Instance.NextStep(p.LookAt, p.Pos, -f);// update position of entity

            if (Util.Instance.distance(p.Pos, p.LookAt) < 15) // it compensates the float error
            {
                if (f > 0)
                    p.LookAt = Util.Instance.NextStep(p.LookAt, p.Pos, -f);
                else
                    p.LookAt = Util.Instance.NextStep(p.LookAt, p.Pos, f);
            }
            p.UpdateRotations();
            forward = 0;
        }

        private void Verify()
        {
            PointF collision, valid;
            Figure figure;
            Line line, user;
            List<double> angles;

            PointF tmp;
            float dTemp, d;

            angles = new List<double>();
            valid = new PointF();
            distances = new List<float>();
            user = new Line(p.Pos, p.LookAt);
            max = 0;
            for (int a = 0; a < p.looks.Count; a++)
            {
                user.a = p.Pos;
                user.b = p.looks[a];

                tmp = new PointF(1500, 1500);
                dTemp = float.MaxValue;

                for (int f = 0; f < scene.Figures.Count; f++)
                {
                    figure = scene.Figures[f];
                    for (int l = 0; l < figure.Lines.Count; l++)
                    {
                        line = figure.Lines[l];
                        if (Util.Instance.Intersect(user, line))
                        {
                            collision = Util.Instance.FindPoint(user, line);
                            d = Util.Instance.distance(collision, p.Pos);
                            if (d < dTemp)
                            {
                                dTemp = d;
                                valid = collision;
                            }
                        }
                    }
                }
                g.FillEllipse(Brushes.Yellow, valid.X - 1, valid.Y - 1, 3, 3);/*
                float angle = p.angles[a];
                if (angle < 0) { angle += 2 * (float)Math.PI; }
                if (angle > 2 * (float)Math.PI) { angle -= 2 * (float)Math.PI; }
                distances.Add((float)(dTemp * (float)Math.Cos(angle / 57.3)));//*/
                distances.Add((float)(dTemp));
            }
        }
        
        private void TIMER_Tick(object sender, EventArgs e)
        {
            c.FastClear();
            Color color;
            int val;
            for (int i = 0; i < distances.Count; i++)
            {
                val = (int)(200 * (1 - (distances[i] )/ 500 ));//normalization of distances have to invert because further means smaller and darker
                if (val > 255)
                    val = 255;
                if (val < 0)
                    val = 0;
                color = Color.FromArgb(val, val, val);
                c.FillColumn(i, color);
            }

            PCT_VIEW.Invalidate();
        }

    }
}
