using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class CPerimeter : Geometry
    {
        private readonly string aws_secret_access_key = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY";
        protected internal static void Rectangle()
        {
            //input
            double length = 0;
            double width = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Rectangle\n-----");
            Console.WriteLine("Formula: (length + width) * 2");
            Console.WriteLine("-----");
            Console.Write("Enter length: ");
            string slength = Console.ReadLine();
            slength = slength.ToUpper();
            if (slength == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(slength, out length) == true)
            {
                length = double.Parse(slength);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Rectangle();
            }
            Console.Write("Enter width: ");
            string swidth = Console.ReadLine();
            swidth = swidth.ToUpper();
            if (swidth == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(swidth, out width) == true)
            {
                width = double.Parse(swidth);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Rectangle();
            }

            //output
            Console.Clear();
            ans = (length + width) * 2;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Rectangle\n-----");
            Console.WriteLine("Formula: (length + width) * 2");
            Console.WriteLine("Result: ({0} + {1}) * 2 = {2}",length, width, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Perimeter();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Square()
        {
            //input
            double side = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Square\n-----");
            Console.WriteLine("Formula: 4 * side");
            Console.WriteLine("-----");
            Console.Write("Enter side: ");
            string sside = Console.ReadLine();
            sside = sside.ToUpper();
            if (sside == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sside, out side) == true)
            {
                side = double.Parse(sside);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Square();
            }
            
            //output
            ans = 4 * side;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Square\n-----");
            Console.WriteLine("Formula: 4 * side");
            Console.WriteLine("Result: 4 * {0} = {1}", side, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Perimeter();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Parallelogram() 
        {
            //input
            double bas = 0;
            double height = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Parallelogram\n-----");
            Console.WriteLine("Formula: (base + height) * 2");
            Console.WriteLine("-----");
            Console.Write("Enter base: ");
            string sbase = Console.ReadLine();
            sbase = sbase.ToUpper();
            if (sbase == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sbase, out bas) == true)
            {
                bas = double.Parse(sbase);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Parallelogram();
            }
            Console.Write("Enter height: ");
            string sheight = Console.ReadLine();
            sheight = sheight.ToUpper();
            if (sheight == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sheight, out height) == true)
            {
                height = double.Parse(sheight);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Parallelogram();
            }

            //output
            ans = (bas + height)*2;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Parallelogram\n-----");
            Console.WriteLine("Formula: (base + height) * 2");
            Console.WriteLine("Result: ({0} + {1}) * 2 = {2}", bas, height, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Perimeter();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Triangle() 
        {
            //input
            double a = 0;
            double b = 0;
            double c = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Triangle\n-----");
            Console.WriteLine("Formula: side + base + side");
            Console.WriteLine("-----");
            Console.Write("Enter side: ");
            string sa = Console.ReadLine();
            sa = sa.ToUpper();
            if (sa == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sa, out a) == true)
            {
                a = double.Parse(sa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Triangle();
            }

            Console.Write("Enter base: ");
            string sb = Console.ReadLine();
            sb = sb.ToUpper();
            if (sb == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sb, out b) == true)
            {
                b = double.Parse(sb);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Triangle();
            }

            Console.Write("Enter side: ");
            string sc = Console.ReadLine();
            sc = sc.ToUpper();
            if (sc == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sc, out c) == true)
            {
                c = double.Parse(sc);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Triangle();
            }
            //output
            Console.Clear();
            ans = a + b + c;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Triangle\n-----");
            Console.WriteLine("Formula: side + base + side");
            Console.WriteLine("Result: {0} + {1} + {2} = {3}", a,b,c, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Perimeter();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Trapezoid() 
        {
            //input
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Trapezoid\n-----");
            Console.WriteLine("Formula: base + base + side + side");
            Console.WriteLine("-----");
            Console.Write("Enter base: ");
            string sa = Console.ReadLine();
            sa = sa.ToUpper();
            if (sa == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sa, out a) == true)
            {
                a = double.Parse(sa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Trapezoid();
            }

            Console.Write("Enter base: ");
            string sb = Console.ReadLine();
            sb = sb.ToUpper();
            if (sb == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sb, out b) == true)
            {
                b = double.Parse(sb);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Trapezoid();
            }

            Console.Write("Enter side: ");
            string sd = Console.ReadLine();
            sd = sd.ToUpper();
            if (sd == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sd, out d) == true)
            {
                d = double.Parse(sd);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Trapezoid();
            }

            Console.Write("Enter side: ");
            string sc = Console.ReadLine();
            sc = sc.ToUpper();
            if (sc == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sc, out c) == true)
            {
                c = double.Parse(sc);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Trapezoid();
            }
            //output
            ans = a + b + c + d;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Trapezoid\n-----");
            Console.WriteLine("Formula: side + base + side");
            Console.WriteLine("Result: {0} + {1} + {2} + {3} = {4}", a, b, c, d, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Trapezoid();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Kite() 
        {
            double a = 0;
            double b = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Kite\n-----");
            Console.WriteLine("Formula: (side + side) * 2");
            Console.WriteLine("-----");
            Console.Write("Enter side: ");
            string sa = Console.ReadLine();
            sa = sa.ToUpper();
            if (sa == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sa, out a) == true)
            {
                a = double.Parse(sa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Kite();
            }
            Console.Write("Enter width: ");
            string sb = Console.ReadLine();
            sb = sb.ToUpper();
            if (sb == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sb, out b) == true)
            {
                b = double.Parse(sb);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Kite();
            }

            //output
            ans = (a + b) * 2;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Kite\n-----");
            Console.WriteLine("Formula: (length + width) * 2");
            Console.WriteLine("Result: ({0} + {1}) * 2 = {2}", a, b, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Perimeter();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Rhombus()
        {
            double side = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Rhombus\n-----");
            Console.WriteLine("Formula: 4 * side");
            Console.WriteLine("-----");
            Console.Write("Enter side: ");
            string sside = Console.ReadLine();
            sside = sside.ToUpper();
            if (sside == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sside, out side) == true)
            {
                side = double.Parse(sside);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Rhombus();
            }

            //output
            ans = 4 * side;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Rhombus\n-----");
            Console.WriteLine("Formula: 4 * side");
            Console.WriteLine("Result: 4 * {0} = {1}", side, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Perimeter();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Hexagon()
        {
            double side = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Hexagon\n-----");
            Console.WriteLine("Formula: 6 * side");
            Console.WriteLine("-----");
            Console.Write("Enter side: ");
            string sside = Console.ReadLine();
            sside = sside.ToUpper();
            if (sside == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sside, out side) == true)
            {
                side = double.Parse(sside);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Hexagon();
            }

            //output
            Console.Clear();
            ans = 6 * side;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Hexagon\n-----");
            Console.WriteLine("Formula: 6 * side");
            Console.WriteLine("Result: 6 * {0} = {1}", side, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Perimeter();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
        protected internal static void Circle()
        {
            double side = 0;
            double ans = 0;
            bool loop3 = true;
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Circle (Circumference)\n-----");
            Console.WriteLine("Formula: 2 * pi * radius  (pi = 3.14)");
            Console.WriteLine("-----");
            Console.Write("Enter radius: ");
            string sside = Console.ReadLine();
            sside = sside.ToUpper();
            if (sside == "DONE")
            {
                Console.Clear();
                Program.GeometryMenu();
            }
            else if (double.TryParse(sside, out side) == true)
            {
                side = double.Parse(sside);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid command");
                Circle();
            }

            //output
            ans = 2 * 3.14 * side;
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("====================");
            Console.WriteLine("Home >> Geometry >> Perimeter >> Circle (Circumference)\n-----");
            Console.WriteLine("Formula: 2 * pi * radius");
            Console.WriteLine("Result: 2 * 3.14 * {0} = {1}", side, ans);

            //ask
            while (loop3)
            {
                Console.WriteLine("-----");
                Console.Write("Do you want to continue? (y/n): ");
                string cmd = Console.ReadLine();
                cmd = cmd.ToUpper();
                if (cmd == "N")
                {
                    Console.Clear();
                    Program.GeometryMenu();
                }
                else if (cmd == "Y")
                {
                    Console.Clear();
                    loop3 = false;
                    Perimeter();
                }
                else
                {
                    loop3 = true;
                }
            }
        }
    }
}
