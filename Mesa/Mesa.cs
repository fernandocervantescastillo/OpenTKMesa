using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mesa
{
    class Mesa:Objeto
    {

        float alto, ancho, largo;
        float x0, y0, z0;

        public Mesa(float largo, float ancho, float alto, float x0, float y0, float z0)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.largo = largo;
            this.x0 = x0;
            this.y0 = y0;
            this.z0 = z0;
        }

        public void draw()
        {
            float ez = 0.1f * alto;
            float ey = 0.15f * ancho;
            float ex = 0.1f * largo;



            Cubo c1 = new Cubo(ex, ancho-ey, ez, x0, y0, z0);
            c1.draw();

            Cubo c2 = new Cubo(ex, ancho-ey, ez, x0+largo-ex, y0, z0); 
            c2.draw();

            Cubo c3 = new Cubo(ex, ancho - ey, ez, x0, y0, z0 + alto - ez);
            c3.draw();

            Cubo c4 = new Cubo(ex, ancho-ey, ez, x0+largo - ex, y0, z0+alto-ez);
            c4.draw();

            Cubo c5 = new Cubo(largo, ey, alto, x0, y0+ancho-ey, z0);
            c5.draw();
        }
    }
}
