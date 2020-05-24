using System;
using System.Data;

public class Evaluator
{
    public double Evaluate(string expression)
    {
        DataTable table = new DataTable();
        object obj = table.Compute(expression, null);
        double res = Math.Round(Convert.ToDouble(obj), 6);
        return res;
    }
}