using System;
using System.Collections.Generic;
using System.Text;

namespace fraction
{
    class ComplexNumber
    {
        private double angle_;
        private double radius_;
        private double a_;
        private double b_;
        private bool hasError_;

        public ComplexNumber(double a, double b)
        {
            a_ = a;
            b_ = b;

            Refresh();
        }

        public ComplexNumber()
        {
            a_ = 1;
            b_ = 1;

            Refresh();
        }

        public double Module
        {
            get { return radius_; }
        }

        public double Re
        {
            get { return a_; }
            set
            {
                a_ = value;
                Refresh();
            }
        }

        public double Im
        {
            get { return b_; }
            set
            {
                b_ = value;
                Refresh();
            }
        }

        public double Angle
        {
            get { return angle_; }
        }

        public static ComplexNumber operator +(ComplexNumber cn1, ComplexNumber cn2)
        {
            ComplexNumber result = new ComplexNumber();

            result.a_ = cn1.a_ + cn2.a_;
            result.b_ = cn1.b_ + cn2.b_;

            if (!result.hasError_)
                return result;
            return null;
        }

        public static ComplexNumber operator -(ComplexNumber cn1, ComplexNumber cn2)
        {
            ComplexNumber result = new ComplexNumber();

            result.a_ = cn1.a_ - cn2.a_;
            result.b_ = cn1.b_ - cn2.b_;

            if (!result.hasError_)
                return result;
            return null;
        }

        public static ComplexNumber operator *(ComplexNumber cn1, ComplexNumber cn2)
        {
            ComplexNumber result = new ComplexNumber();

            result.Re = cn1.a_ * cn2.a_ - cn1.b_ * cn2.b_;
            result.Im = cn1.a_ * cn2.b_ + cn1.b_ * cn2.a_;

            if (!result.hasError_)
                return result;
            return null;
        }

        private void Refresh()
        {
            hasError_ = false;

            radius_ = Math.Sqrt(a_ * a_ + b_ * b_);

            if (radius_ != 0 && (a_ / radius_) != 0)
                angle_ = Math.Atan((b_ / radius_) / (a_ / radius_));
            else
                hasError_ = true;
        }

        public bool HasError
        {
            get { return hasError_; }
        }

        public override string ToString()
        {
            return string.Format("z = {0} + i * {1}", a_, b_);
        }
    }
}
