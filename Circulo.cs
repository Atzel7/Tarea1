using System;

namespace Tarea1
{
    internal class circulo
    {
        public float r;

        public circulo(float r)
        {
            this.r = r;
        }

        public float CalcularArea()
        {
            return 3.14f * (r * r);
        }

        public float CalcularPerimetro()
        {
            return 2 * 3.14f * r;
        }
    }
}