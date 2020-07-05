using System;


class ComplexC
{
    // Поля приватные.
    private double im;
    // По умолчанию элементы приватные, поэтому private можно не писать.
    double re;

    // Конструктор без параметров.
    public ComplexC()
    {
        im = 0;
        re = 0;
    }

    // Конструктор, в котором задаем поля.    
    // Специально создадим параметр re, совпадающий с именем поля в классе.
    public ComplexC(double _im, double re)
    {
        // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
        im = _im;
        // Чтобы показать, что к полю нашего класса присваивается параметр,
        // используется ключевое слово this
        // Поле параметр
        this.re = re;
    }
    public ComplexC Plus(ComplexC x2)
    {
        ComplexC x3 = new ComplexC();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }

    public ComplexC Minus(ComplexC x2)
    {
        ComplexC x3 = new ComplexC();
        x3.im = x2.im - im;
        x3.re = x2.re - re;
        return x3;
    }

    //  Пример произведения двух комплексных чисел
    public ComplexC Multi(ComplexC x)
    {
        ComplexC y = new ComplexC();
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    // Свойства - это механизм доступа к данным класса.
    public double Im
    {
        get { return im; }
        set
        {
            // Для примера ограничимся только положительными числами.
            if (value >= 0) im = value;
        }
    }

    // Специальный метод, который возвращает строковое представление данных.
    //Заменил метод свойством.
    public new string ToString => $"{(re == 0 ? "" : re.ToString())}{(im >= 0 && re != 0 ? "+" : "")}{(im != -1 ? im.ToString() : "-")}i";

}