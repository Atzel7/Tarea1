using System;

namespace Tarea1
{
    internal class rectangulo
    {
        private float b;
        private float h;

        public rectangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float CalcularArea()
        {
            return b * h;
        }

        public float CalcularPerimetro()
        {
            return 2 * (b + h);
        }
    }
}