using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuadraticEquation
{
    using System;
    /// <summary>
    /// This class is used to model a Quadratic Equation.
    /// </summary>
    /// <parama>A represents coefficient of x square</parama>
    /// <paramb> B represents coefficient of X</paramb>
    /// <paramc>C represents constant of quadratic equation</paramc>
    class QuadraticEquation1
    {
        int A;
        int B;
        int C;
        double Discriminant;
        double X1;
        double X2;
        Boolean status = true;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public QuadraticEquation1(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double ComputeDisc()
        {
            Discriminant = Math.Pow(B, 2) - 4*A*C;
            return Discriminant;
        } 

        public void ComputeSolution()
        {
            if(Discriminant == 0)
            {
                X1 = -B / (2 * A);
                X2 = X1;
            }
            else if (Discriminant > 0)
            {
                X1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                X2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
            }
            else
            {
                status = false;
            }
        }
        public string DisplaySolution()
        {
            //Console.WriteLine($"Quadratic Equation with  A: {0}   B: {1}  C: {2}", A, B, C);
            if (status)
            {
                if (X1 == X2)
                {
                    return string.Format($"The equation has one root: {X1}");
                }
                else
                {
                    return string.Format($"Root X1 = {X1}, Root X2 = {X2}");
                }
            }
            else
            {
                return string.Format("Equation has no real roots!");
            }
            
        }
    }

    class QuadraticEquation2
    {
        int A;
        int B;
        int C;
        double Discriminant;
        double X1;
        double X2;
        Boolean status = true;

        public QuadraticEquation2(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double ComputeDisc()
        {
            Discriminant = Math.Pow(B, 2) - 4 * A * C;
            return Discriminant;
        }

        public void ComputeSolution()
        {
            if (Discriminant == 0)
            {
                if (A == 0)
                {

                    status = false;

                }
                else
                {
                    X1 = -B / (2 * A);
                    X2 = X1;
                }

            }
            else if (Discriminant > 0)
            {
                if (A == 0)
                {

                    status = false;

                }
                else
                {
                    X1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                    X2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                }

            }
            else
            {
                status = false;
            }
        }
        public string DisplaySolution()
        {
            //Console.WriteLine($"Quadratic Equation with  A: {0}   B: {1}  C: {2}", A, B, C);
            ComputeDisc();
            ComputeSolution();
            if (status)
            {
                if (X1 == X2)
                {
                    return string.Format($"The equation has one root: {X1}");
                }
                else
                {
                    return string.Format($"Root X1 = {X1}, Root X2 = {X2}");
                }
            }
            else
            {
                return string.Format("Equation has no real roots!");
            }

        }
    }

    class QuadraticEquation3
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        double Discriminant;
        double X1;
        double X2;
        Boolean status = true;

        public QuadraticEquation3(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public QuadraticEquation3()
        {
            
        }
        public double ComputeDisc()
        {
            Discriminant = Math.Pow(B, 2) - 4 * A * C;
            return Discriminant;
        }

        public void ComputeSolution()
        {
            if (Discriminant == 0)
            {
                if (A == 0)
                {

                    status = false;

                }
                else
                {
                    X1 = -B / (2 * A);
                    X2 = X1;
                }

            }
            else if (Discriminant > 0)
            {
                if (A == 0)
                {

                    status = false;

                }
                else
                {
                    X1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                    X2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                }

            }
            else
            {
                status = false;
            }
        }
        public void DisplaySolution()
        {
            //Console.WriteLine($"Quadratic Equation with  A: {0}   B: {1}  C: {2}", A, B, C);
            ComputeDisc();
            ComputeSolution();
            if (status)
            {
                if (X1 == X2)
                {
                    Console.WriteLine($"The equation has one root: {X1}");
                }
                else
                {
                    Console.WriteLine($"Root X1 = {X1}");
                    Console.WriteLine($"Root X2 = {X2}");
                }
            }
            else
            {
                Console.WriteLine("Equation has no real roots!");
            }

        }
    }

    class QuadraticEquation4
    {
        private int A;
        private int B;
        private int C;

        double Discriminant;
        double X1;
        double X2;
        Boolean status = true;

        public QuadraticEquation4(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public QuadraticEquation4()
        {

        }
        public int pA
        {
            get
            {
                return this.A;
            }

            set
            {
                this.A = value;
            }
        }

        public int pB
        {
            get
            {
                return this.B;
            }

            set
            {
                this.B = value;
            }
        }

        public int pC
        {
            get
            {
                return this.C;
            }

            set
            {
                this.C = value;
            }
        }


        public double ComputeDisc()
        {
            Discriminant = Math.Pow(B, 2) - 4 * A * C;
            return Discriminant;
        }

        public void ComputeSolution()
        {
            if (Discriminant == 0)
            {
                if (A == 0)
                {

                    status = false;

                }
                else
                {
                    X1 = -B / (2 * A);
                    X2 = X1;
                }

            }
            else if (Discriminant > 0)
            {
                if (A == 0)
                {

                    status = false;

                }
                else
                {
                    X1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                    X2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                }

            }
            else
            {
                status = false;
            }
        }
        public void DisplaySolution()
        {
            //Console.WriteLine($"Quadratic Equation with  A: {0}   B: {1}  C: {2}", A, B, C);
            ComputeDisc();
            ComputeSolution();
            if (status)
            {
                if (X1 == X2)
                {
                    Console.WriteLine($"The equation has one root: {X1}");
                }
                else
                {
                    Console.WriteLine($"Root X1 = {X1}");
                    Console.WriteLine($"Root X2 = {X2}");
                }
            }
            else
            {
                Console.WriteLine("Equation has no real roots!");
            }

        }
    }
}
