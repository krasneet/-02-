using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Box
    {
        private int l;
        private int b;
        private int h;

         public int L
        {

            get 
            {
                return l;
            }
            set
            {
                if (value > 0) l = value;
            }

        }

        public int B
        {
            get
            {
                return b;
            }

            set
            {
                if (value > 0) b = value;
            }

        }


        public int H
        {
            get
            {
                return h;
            }
            set
            {
                if (value > 0)
                    h = value;
            }
        }

        public Box()
        {
            L = 0;
            B = 0;
            H = 0;
        }

        public Box(int d, int s, int w)
        {
            L = d;
            B = s;
            H = w;
        }

        public void Show()
        {
            Console.WriteLine($"l = {L}, b ={B}, h={H}");
            return;
        }

        public int Volum()
        {
            int v = l * b * h;
            return v;
        }
        
    }
}
