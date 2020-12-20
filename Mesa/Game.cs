using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Mesa
{
    class Game : GameWindow
    {

        float t = 0;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Title = "Hello OpenTK!";

            GL.ClearColor(Color.CornflowerBlue);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);


            Matrix4 modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);


            Mesa mesa = new Mesa(0.9f, 0.8f, 0.9f, -1f, -0.5f, 2.1f);
            mesa.draw();


            SwapBuffers();

        }

        protected override void OnResize(EventArgs e)
        {
            /* OpenGL needs to be told how to adjust for the new window size, so we need some code that handles it. */
            base.OnResize(e);

            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }
    }
}
