using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RAYKING
{
    public class Util
    {
        static Util instance;
        float t;

        public static Util Instance
        {
            get
            {
                if (instance == null)
                    instance = new Util();
                return Util.instance;
            }
        }
        public bool Intersect(Line a, Line b)
        {
            float den, u;

            den = (b.a.X - b.b.X) * (a.a.Y - a.b.Y) - (b.a.Y - b.b.Y) * (a.a.X - a.b.X);
            if (den == 0)
                return false;

            t = ((b.a.X - a.a.X) * (a.a.Y - a.b.Y) - (b.a.Y - a.a.Y) * (a.a.X - a.b.X)) / den;
            u = -((b.a.X - b.b.X) * (b.a.Y - a.a.Y) - (b.a.Y - b.b.Y) * (b.a.X - a.a.X)) / den;

            if (t > 0 && t < 1 && u > 0)
                return true;

            return false;
        }

        public PointF FindPoint(Line a, Line b)
        {
            float x = b.a.X + t * (b.b.X - b.a.X);
            float y = b.a.Y + t * (b.b.Y - b.a.Y);

            return new PointF(x, y);
        }


        public float distance(PointF a, PointF b)
        {
            float x,y;
            x = a.X-b.X;
            y = a.Y-b.Y;

            return (float)Math.Sqrt((x * x) + (y * y));
        }

        public PointF NextStep(PointF position, PointF direction, float alpha)
        {
            PointF res;

            res = new PointF();
            res.X = ((1 - alpha) * position.X) + ((alpha) * direction.X);
            res.Y = ((1 - alpha) * position.Y) + ((alpha) * direction.Y);

            return res;
        }

        public PointF Rotate(PointF a, PointF b, float angle)
        {
            if (angle > 360)
                angle = 360;

            if (angle < -360)
                angle = 0;

            b.X -= a.X;
            b.Y -= a.Y;

            PointF c = new PointF();
            angle = angle / 57.2958f;

            c.X = (float)((b.X * Math.Cos(angle)) - (b.Y * Math.Sin(angle)));
            c.Y = (float)((b.X * Math.Sin(angle)) + (b.Y * Math.Cos(angle)));

            c.X += a.X;
            c.Y += a.Y;

            return c;
        }

        public float Dot(PointF a, PointF b)
        {
            return (a.X * b.X) + (a.Y * b.Y);
        }

        public float Mag(PointF a)
        {
            return (float)Math.Sqrt((a.X * a.X) + (a.Y * a.Y));
        }
    }
}
