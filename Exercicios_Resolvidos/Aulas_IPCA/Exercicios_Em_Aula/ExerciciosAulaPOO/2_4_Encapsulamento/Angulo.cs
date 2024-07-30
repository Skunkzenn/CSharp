using System;

namespace Course;

class Angulo
{
    private double _grau;
    private double _radiano;


    public Angulo()
    {
        _grau = 0;
        _radiano = 0;
    }

    public double Grau
    {
        get { return _grau = _radiano / (180.00 * Math.PI); }
        set { _grau = value; }
    }

    public double Radiano 
    { 
        get { return _radiano = _grau / (Math.PI * 180.00); } 
        set { _radiano = value; }
    }

    public override string ToString()
    {
        return $"Cos({_grau} graus) =" + Grau + $"\nPI/2 = {_radiano} graus = " + Radiano;
    }
}