using System;

namespace ComplexTool
{
    public enum ComplexType
    {
        Algebra,
        Polar
    }
    internal class Complex
    {
        private const double Tolerance = 1E-6;
        public int DecimalPlaces;
        private double _x, _y, _module, _degree;
        public static Exception DivideZero { get; set; }
        public double X
        {
            set
            {
                _x = value;
                _module = Math.Sqrt(_x * _x + _y * _y);
                _degree = Math.Atan2(_y, _x);
            } 
            get => _x; 
        }
        public double Y
        {
            set
            {
                _y = value;
                _module = Math.Sqrt(_x * _x + _y * _y);
                _degree = Math.Atan2(_y, _x);
            }
            get => _y;
        }

        public double Module
        {
            set
            {
                _module = value;
                _x = _module * Math.Cos(_degree);
                _y = _module * Math.Sin(_degree);
            }
            get => _module;
        }
        public double Degree
        {
            set
            {
                _degree = value * (Math.PI / 180);
                _x = _module * Math.Cos(_degree);
                _y = _module * Math.Sin(_degree);
            }
            get => _degree / (Math.PI / 180);
        }

        public double ShowX => Math.Round(X, DecimalPlaces);
        public double ShowY => Math.Round(Y, DecimalPlaces);
        public double ShowModule => Math.Round(Module, DecimalPlaces);
        public double ShowDegree => Math.Round(Degree, DecimalPlaces);

        public static Complex operator +(Complex complex1, Complex complex2)
            => new Complex
            {
                X = complex1.X + complex2.X,
                Y = complex1.Y + complex2.Y,
                DecimalPlaces = complex1.DecimalPlaces
            };

        public static Complex operator -(Complex complex1, Complex complex2)
            => new Complex
            {
                X = complex1.X - complex2.X,
                Y = complex1.Y - complex2.Y,
                DecimalPlaces = complex1.DecimalPlaces
            };

        public static Complex operator *(Complex complex1, Complex complex2)
            => new Complex
            { 
                X = complex1.X * complex2.X - complex1.Y * complex2.Y,
                Y = complex1.X * complex2.Y + complex1.Y * complex2.X,
                DecimalPlaces = complex1.DecimalPlaces
            };

        public static Complex operator /(Complex complex1, Complex complex2)
        {
            if (Math.Abs(complex2.X) < Tolerance && Math.Abs(complex2.Y) < Tolerance)
            {
                throw DivideZero;
            }
            var denominator = complex2.X * complex2.X +
                              complex2.Y * complex2.Y;
            var readMolecular = complex1.X * complex2.X +
                                complex1.Y * complex2.Y;
            var imaginaryMolecular = complex1.Y * complex2.X -
                                     complex1.X * complex2.Y;
            return new Complex
            {
                X= readMolecular / denominator,
                Y = imaginaryMolecular / denominator,
                DecimalPlaces = complex1.DecimalPlaces
            };
        }

        public void Copy(Complex complex)
        {
            X = complex.X;
            Y = complex.Y;
            DecimalPlaces = complex.DecimalPlaces;
        }

        public void ToZero()
        {
            X = 0;
            Y = 0;
        }

        public string ShowString()
        {
            var complexStr = "";
            var realStr = Math.Abs(X) < Tolerance ? "" : $"{Math.Round(X, DecimalPlaces)}";
            var imaginaryStr = Math.Abs(Y) < Tolerance ? "" : $" {Math.Round(Y, DecimalPlaces)} * j";
            if (realStr != "")
            {
                complexStr += realStr;
                if (imaginaryStr != "")
                {
                    complexStr += $" +{imaginaryStr}";
                }
            }
            else
            {
                if (imaginaryStr != "")
                {
                    complexStr += imaginaryStr;
                }
            }
            if (complexStr == "")
            {
                complexStr = "0";
            }
            return complexStr;
        }
    }
}
