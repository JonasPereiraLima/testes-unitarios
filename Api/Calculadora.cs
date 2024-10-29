namespace newTalents;

public class Calculadora
{
    private List<string> listaHistorico;
    private string data;

    public Calculadora(string data)
    {
        listaHistorico = new List<string>();
        this.data = data;
    }

    public int Somar(int number1, int number2)
    {
        int result = number1 + number2;
        AddHistorico(result);
        return result;
    }

    public int Subtrair(int number1, int number2)
    {
        int result = number1 - number2;
        AddHistorico(result);
        return result;
    }

    public int Multiplicar(int number1, int number2)
    {
        int result = number1 * number2;
        AddHistorico(result);
        return result;
    }

    public int Dividir(int number1, int number2)
    {
        int result = number1 / number2;
        AddHistorico(result);
        return result;
    }

    public List<string> Historico()
    {
        listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
        return listaHistorico;
    }

    private void AddHistorico(int result)
    {
        listaHistorico.Insert(0, $"Res: {result} - data: {data}");
    }
}