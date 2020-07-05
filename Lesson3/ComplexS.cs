using System;

struct ComplexS
{
    public double im;
    public double re;

    //  в C# в структурах могут храниться также действия над данными
    public ComplexS Plus(ComplexS x)
    {
        ComplexS y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    //  Пример произведения двух комплексных чисел
    public ComplexS Multi(ComplexS x)
    {
        ComplexS y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    /// <summary>
    /// Метод вычитания комплексных чисел.
    /// </summary>
    public ComplexS Minus(ComplexS x)
    {
        ComplexS y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }


    public new string ToString => $"{(re == 0 ? "" : re.ToString())}{(im >= 0 && re != 0 ? "+" : "")}{(im != -1 ? im.ToString() : "-")}i";
}