using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RAYKING
{
    public class Scene
    {
        public List<Figure> Figures;

        public Scene()
        {
            this.Figures = new List<Figure>();
        }

        public Scene(List<Figure> figures)
        {
            this.Figures = figures;
        }
    }
}
