using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RAYKING
{
    public class SceneCreator
    {
        public Scene scene;

        public SceneCreator()
        {
            scene = new Scene();
            int aX = 120;
            int bX = 150;
            int cY = 300;
            int dY = 100;

            int eX = 450;
            int eY = 449;

            Figure fig = new Figure();
            fig.Lines.Add(new Line(new PointF(50, 100), new PointF(100, 100)));
            fig.Lines.Add(new Line(new PointF(100, 100), new PointF(100, 200)));
            fig.Lines.Add(new Line(new PointF(50, 100), new PointF(50, 120)));
            fig.Lines.Add(new Line(new PointF(80, 120), new PointF(50, 120)));
            fig.Lines.Add(new Line(new PointF(80, 120), new PointF(80, 200)));
            fig.Lines.Add(new Line(new PointF(100, 200), new PointF(80, 200)));//*/
            scene.Figures.Add(fig);
            fig = new Figure();
            fig.Lines.Add(new Line(new PointF(aX, dY), new PointF(bX, dY)));
            fig.Lines.Add(new Line(new PointF(aX, cY), new PointF(bX, cY)));
            fig.Lines.Add(new Line(new PointF(bX, dY), new PointF(bX, cY)));
            fig.Lines.Add(new Line(new PointF(aX, dY), new PointF(aX, cY)));//*/
            scene.Figures.Add(fig);
            fig = new Figure();
            fig.Lines.Add(new Line(new PointF(0, 0), new PointF(450, 0)));
            fig.Lines.Add(new Line(new PointF(eY, 0), new PointF(eY, eY)));
            fig.Lines.Add(new Line(new PointF(eY, eY), new PointF(0, eY)));
            fig.Lines.Add(new Line(new PointF(0, eY), new PointF(0, 0)));//*/
            scene.Figures.Add(fig);// outter walls

            fig = new Figure();
            fig.Lines.Add(new Line(new PointF(50, 80), new PointF(150, 80)));
            fig.Lines.Add(new Line(new PointF(50, 50), new PointF(150, 50)));
            scene.Figures.Add(fig);

            fig = new Figure();
            fig.Lines.Add(new Line(new PointF(80, 220), new PointF(50, 220)));
            fig.Lines.Add(new Line(new PointF(80, 250), new PointF(50, 250)));
            scene.Figures.Add(fig);
            
            fig = new Figure();
            fig.Lines.Add(new Line(new PointF(175, 150), new PointF(250, 150)));
            fig.Lines.Add(new Line(new PointF(175, 250), new PointF(250, 250)));    
            scene.Figures.Add(fig);

            fig = new Figure();
            fig.Lines.Add(new Line(new PointF(300, 120), new PointF(300, 300)));
            fig.Lines.Add(new Line(new PointF(175, 250), new PointF(250, 250)));
            scene.Figures.Add(fig);

            fig = new Figure();
            fig.Lines.Add(new Line(new PointF(150, 350), new PointF(50, 350)));
            fig.Lines.Add(new Line(new PointF(150, 320), new PointF(50, 320)));
            scene.Figures.Add(fig);
        }
    }
}
