using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mesa
{
    class Cubo:Objeto
    {

        float alto, ancho, largo;
        float x0, y0, z0;

        public Cubo()
        {

        }

        public Cubo(float largo, float ancho, float alto, float x0, float y0, float z0)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.largo = largo;
            this.x0 = x0;
            this.y0 = y0;
            this.z0 = z0;
        }

        public Cubo(float alto, float ancho, float largo)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.largo = largo;
        }

        public void draw()
        {
            GL.Begin(PrimitiveType.Quads);
                GL.Color3(1.0f, 1.0f, 1.0f);
                GL.Vertex3(x0 + largo, y0 + ancho, z0 + alto);
                GL.Vertex3(x0 + largo, y0, z0 + alto);
                GL.Vertex3(x0, y0, z0 + alto);
                GL.Vertex3(x0, y0 + ancho, z0 + alto);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
                GL.Color3(1.0f, 0.0f, 0.0f);
                GL.Vertex3(x0, y0, z0);
                GL.Vertex3(x0, y0, z0 + alto);
                GL.Vertex3(x0 + largo, y0, z0 + alto);
                GL.Vertex3(x0 + largo, y0, z0);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
                GL.Color3(0.0f, 1.0f, 0.0f);
                GL.Vertex3(x0, y0, z0);
                GL.Vertex3(x0, y0 + ancho, z0);
                GL.Vertex3(x0, y0 + ancho, z0 + alto);
                GL.Vertex3(x0, y0, z0+alto);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
                GL.Color3(0.0f, 0.0f, 1.0f);
                GL.Vertex3(x0, y0+ancho, z0);
                GL.Vertex3(x0 + largo, y0 + ancho, z0);
                GL.Vertex3(x0 + largo, y0 + ancho, z0 + alto);
                GL.Vertex3(x0, y0 + ancho, z0 + alto);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
                GL.Color3(1.0f, 1.0f, 0.0f);
                GL.Vertex3(x0 + largo, y0, z0);
                GL.Vertex3(x0 + largo, y0, z0 + alto);
                GL.Vertex3(x0 + largo, y0 + ancho, z0 + alto);
                GL.Vertex3(x0+largo, y0+ancho, z0);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
                GL.Color3(0.0f, 1.0f, 1.0f);
                GL.Vertex3(x0, y0 + ancho, z0);
                GL.Vertex3(x0, y0, z0);
                GL.Vertex3(x0 + largo, y0, z0);
                GL.Vertex3(x0 + largo, y0 + ancho, z0);
            GL.End();
        }
    }
}
