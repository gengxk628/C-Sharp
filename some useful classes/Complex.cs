///
///A class to operate on complex numbers
///Programming by Geng Xinkuang
///email: 1326846851@qq.com
///
using System;
using System.Collections.Generic;

namespace Complex
{
    /// <summary>
    /// 操作复数的类
    /// A class to operate on complex numbers
    /// 
    /// @author Geng Xinkuang
    /// @version 1.0
    /// </summary>
    public class Complex:IComparable
    {
        private double rp = 0.0;
        private double ip = 0.0;
        private static double eps = 0.0;
        //
        // 摘要:
        //     复数的实部
        public double RealPart
        {
            get
            {
                return rp;
            }
            set
            {
                rp = value;
            }
        }
        //
        // 摘要:
        //     复数的虚部
        public double ImaginaryPart
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }
        //
        // 摘要:
        //     复数的缺省精度
        public static double Eps
        {
            get
            {
                return eps;
            }
            set
            {
                eps = value;
            }
        }
        //
        // 摘要:
        //     基本构造函数
        public Complex()
        {

        }
        //
        // 摘要:
        //     指定值构造函数
        //
        // 参数:
        //   rp:
        //     复数的实部
        //
        //   ip:
        //     复数的虚部
        public Complex(double rp, double ip)
        {
            this.rp = rp;
            this.ip = ip;
        }
        //
        // 摘要:
        //     拷贝构造函数
        //
        // 参数:
        //   sc:
        //     源复数
        public Complex(Complex sc)
        {
            rp = sc.rp;
            ip = sc.ip;
        }
        public static implicit operator double(Complex c)
        {
            return c.Abs();
        }
        public static implicit operator Complex(double c)
        {
            return new Complex(c, 0);
        }
        //
        // 摘要:
        //     将复数转化为"a+bi"形式的字符串
        //
        // 返回结果:
        //     string类型，"a+bi"形式的字符串
        public override string ToString()
        {
            string s;
            if (ip >= 0)
            {
                s = rp.ToString() + "+" + ip.ToString() + "i";
            }
            else
            {
                s = rp.ToString() + ip.ToString() + "i";
            }
            return s;
        }
        //
        // 摘要:
        //     为复数设置值
        //
        // 参数:
        //   c:
        //     要赋值的复数
        //
        // 返回结果:
        //     Complex类型，赋值的结果
        public Complex SetValue(Complex c)
        {
            rp = c.rp;
            ip = c.ip;
            return this;
        }
        //
        // 摘要:
        //     为复数设置值
        //
        // 参数:
        //   rp:
        //     复数的实部
        //
        //   ip:
        //     复数的虚部
        public void SetValue(double rp, double ip)
        {
            this.rp = rp;
            this.ip = ip;
        }
        //
        // 摘要:
        //     计算复数的共轭复数
        //
        // 返回结果:
        //     Complex类型，该复数的共轭复数
        public Complex Conjugate()
        {
            return new Complex(rp, -ip);
        }
        //
        // 摘要:
        //     计算复数的模
        //
        // 返回结果:
        //     double类型，该复数的模
        public double Abs()
        {
            return Math.Sqrt(rp * rp + ip * ip);
        }
        //
        // 摘要:
        //     重载 - 运算符
        //
        // 参数:
        //   c:
        //     需要取相反的复数
        //
        // 返回结果:
        //     取相反的复数
        public static Complex operator -(Complex c)
        {
            return new Complex(-c.rp, -c.ip);
        }
        //
        // 摘要:
        //     重载 + 运算符
        //
        // 参数:
        //   c1:
        //     加数
        //   c2:
        //     加数
        //
        // 返回结果:
        //     两个复数相加的结果
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1);
            return c.Add(c2);
        }
        //
        // 摘要:
        //     重载 - 运算符
        //
        // 参数:
        //   c1:
        //     减数
        //   c2:
        //     减数
        //
        // 返回结果:
        //     两个复数相减的结果
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1);
            return c.Subtract(c2);
        }
        //
        // 摘要:
        //     重载 * 运算符
        //
        // 参数:
        //   c1:
        //     乘数
        //   c2:
        //     乘数
        //
        // 返回结果:
        //     两个复数相乘的结果
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1);
            return c.Multiply(c2);
        }
        //
        // 摘要:
        //     重载 / 运算符
        //
        // 参数:
        //   c1:
        //     被除数
        //   c2:
        //     除数
        //
        // 返回结果:
        //     两个复数相除的结果
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1);
            return c.Divide(c2);
        }
        //
        // 摘要:
        //     将该复数加上另外一个复数c
        //
        // 参数:
        //   c:
        //     要相加的复数
        //
        // 返回结果:
        //     Complex类型，相加的结果
        public Complex Add(Complex c)
        {
            this.rp += c.rp;
            this.ip += c.ip;
            return this;
        }
        //
        // 摘要:
        //     将该复数减去另外一个复数c
        //
        // 参数:
        //   c:
        //     要相减的复数
        //
        // 返回结果:
        //     Complex类型，相减的结果
        public Complex Subtract(Complex c)
        {
            this.rp -= c.rp;
            this.ip -= c.ip;
            return this;
        }
        //
        // 摘要:
        //     将该复数乘上另外一个复数c
        //
        // 参数:
        //   c:
        //     要相乘的复数
        //
        // 返回结果:
        //     Complex类型，相乘的结果
        public Complex Multiply(Complex c)
        {
            double a, b;
            a = this.rp * c.rp - this.ip * c.ip;
            b = this.rp * c.ip + this.ip * c.rp;
            this.rp = a;
            this.ip = b;
            return this;
        }
        //
        // 摘要:
        //     将该复数除以另外一个复数c
        //
        // 参数:
        //   c:
        //     要相除的复数
        //
        // 返回结果:
        //     Complex类型，相除的结果
        public Complex Divide(Complex c)
        {
            double a, b;
            a = (this.rp * c.rp + this.ip * c.ip) / (c.rp * c.rp + c.ip * c.ip);
            b = (this.ip * c.rp - this.rp * c.ip) / (c.rp * c.rp + c.ip * c.ip);
            this.rp = a;
            this.ip = b;
            return this;
        }
        //
        // 摘要:
        //     计算复数辐角的余弦值
        //
        // 返回结果:
        //     double类型，复数辐角的余弦值
        public double Cos()
        {
            return rp / Math.Sqrt(rp * rp + ip * ip);
        }
        //
        // 摘要:
        //     计算复数辐角的正弦值
        //
        // 返回结果:
        //     double类型，复数辐角的正弦值
        public double Sin()
        {
            return ip / Math.Sqrt(rp * rp + ip * ip);
        }
        //
        // 摘要:
        //     计算复数辐角的正切值
        //
        // 返回结果:
        //     double类型，复数辐角的正切值
        public double Tan()
        {
            return ip / rp;
        }
        //
        // 摘要:
        //     计算复数辐角
        //
        // 返回结果:
        //     double类型，复数辐角
        public double Argument()
        {
            return Math.Atan2(ip, rp);
        }
        //
        // 摘要:
        //     计算复数的自然对数
        //
        // 返回结果:
        //     Complex类型，复数的自然对数
        public Complex Log()
        {
            return new Complex(Math.Log(Abs()), Argument());
        }
        //
        // 摘要:
        //     重载 ^ 运算符
        //
        // 参数:
        //   c:
        //     底数
        //   x:
        //     指数
        //
        // 返回结果:
        //     c的x次幂
        public static Complex operator ^(Complex c, double x)
        {
            double arg = c.Argument() * x;
            double r = Math.Pow(c.Abs(), x);
            return new Complex(r * Math.Cos(arg), r * Math.Sin(arg));
        }
        //
        // 摘要:
        //     重载 ^ 运算符
        //
        // 参数:
        //   c1:
        //     底数
        //   c2:
        //     指数
        //
        // 返回结果:
        //     c1的c2次幂
        public static Complex operator ^(Complex c1, Complex c2)
        {
            Complex x = c2 * c1.Log();
            double arg = x.ip;
            double r = Math.Exp(x.rp);
            return new Complex(r * Math.Cos(arg), r * Math.Sin(arg));
        }
        //
        // 摘要:
        //     计算复数的实数次幂
        //
        // 参数:
        //   x:
        //     幂指数
        //
        // 返回结果:
        //     Complex类型，复数的x次幂
        public Complex Pow(double x)
        {
            double arg = Argument()*x;
            double r = Math.Pow(Abs(), x);
            return new Complex(r * Math.Cos(arg), r * Math.Sin(arg));
        }
        //
        // 摘要:
        //     计算复数的复数次幂
        //
        // 参数:
        //   c:
        //     幂指数
        //
        // 返回结果:
        //     Complex类型，复数的c次幂
        public Complex Pow(Complex c)
        {
            Complex x = c * Log();
            double arg = x.ip;
            double r = Math.Exp(x.rp);
            return new Complex(r * Math.Cos(arg), r * Math.Sin(arg));
        }
        //
        // 摘要:
        //     实现IComparable接口
        public int CompareTo(object obj)
        {
            Complex c = obj as Complex;
            if(c == null)
            {
                throw new ArgumentException("CompareTo（Complex）");
            }
            if (Math.Abs(Abs() - c.Abs()) < eps)
            {
                return 0;
            }
            if (Abs() > c.Abs())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
