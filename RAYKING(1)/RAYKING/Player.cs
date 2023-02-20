using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RAYKING
{
    public class Player
    {
        public Line line;
        public PointF Pos, LookAt;//main lookAt
        public List<PointF> looks;
        public List<float> angles;
        private float[] angleR, angleL;
        private PointF[] looksR, looksL;

        public Player(PointF pos, PointF lookAt)
        {
            this.Pos    = pos;
            this.LookAt = lookAt;

            int tot = 150;
            looksR = new PointF[tot];
            looksL = new PointF[tot];

            angleR = new float[tot];
            angleL = new float[tot];
          
            looks = new List<PointF>();
            line = new Line(pos, lookAt);

            angles = new List<float>();
            UpdateRotations();
        }

        public void UpdateRotations()
        {
            float val;
            val = .2f;  
            looks.Clear();
            looksR[0] = Util.Instance.Rotate(Pos, LookAt, val);
            //angleR[0] = (float)Math.Cos((0) / 57.2958f) ;

            angleR[0] = 0;
            for (int i = 1; i < looksR.Length; i++)
            {
                looksR[i] = Util.Instance.Rotate(Pos, looksR[i - 1], val);
                //angleR[i] = (float)Math.Cos((i * val) / 57.2958f);
                angleR[i] = (i * val);
            }

            looksL[looksL.Length - 1] = Util.Instance.Rotate(Pos, LookAt, -val);
            angleL[0] = looksL.Length * val;
            for (int i = looksL.Length - 1; i > 0; i--)
            {
                looksL[i - 1] = Util.Instance.Rotate(Pos, looksL[i], -val);
                //angleL[looksL.Length - i] = (float)Math.Cos((i * val) / 57.2958f);
                angleL[looksL.Length - i] = (i * val);
            }
            angles.AddRange(angleL.ToArray());
            angles.AddRange(angleR.ToArray());
            looks.AddRange(looksL);
            looks.AddRange(looksR);
        }
        
    }
}
