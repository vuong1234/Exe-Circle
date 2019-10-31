using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rec
    {
        private float Lenght = 1;
        private float Width = 1;

        public Rec()
        {

        }

        public Rec(float Lenght, float Width)
        {
            this.Lenght = Lenght;
            this.Width = Width;
        }

        public float  GetLenght()
        {
            return Lenght;
        }

        public void SetLenght(float NewLenght)
        {
            Lenght = NewLenght;
        }

        public float GetWidth()
        {
            return Width;
        }

        public void SetWidth(float NewWidth)
        {
            Width = NewWidth;
        }

        public double GetArea()
        {
            return this.Width * this.Lenght;
        }

        public double GetPerimeter()
        {
            return (this.Lenght + this.Width) * 2;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
