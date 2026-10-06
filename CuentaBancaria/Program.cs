class CuentaBancaria
{
    private double _saldo;

    public CuentaBancaria(double saldoInicial)
    {
        _saldo = saldoInicial;
    }

    public void Depositar(double monto)
    {
        _saldo += monto;
    }

    public void Retirar(double monto)
    {
        if (monto <= _saldo)
        {
            _saldo -= monto;
            Console.WriteLine("Retiro realizado correctamente.");
        }
        else
        {
            Console.WriteLine("No hay suficiente saldo.");
        }
    }

    public double Saldo
    {
        get { return _saldo; }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el saldo inicial: ");
        double saldoInicial = Convert.ToDouble(Console.ReadLine());

        CuentaBancaria cuenta = new CuentaBancaria(saldoInicial);

        Console.Write("Ingrese la cantidad que desea depositar: ");
        double deposito = Convert.ToDouble(Console.ReadLine());

        cuenta.Depositar(deposito);

        Console.Write("Ingrese la cantidad que desea retirar: ");
        double retiro = Convert.ToDouble(Console.ReadLine());

        cuenta.Retirar(retiro);

        Console.WriteLine("Saldo actual: " + cuenta.Saldo);
    }
}