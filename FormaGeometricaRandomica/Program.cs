using FormaGeometricaRandomica.Model;

class Program
{
    static void Main(string[] args)
    {
        List<int> list;
        Random random = new Random();

        for (int i = 0; i <= 15; i++)
        {
            list = new List<int>();
            int quantidadeDeLados = random.Next(5);

            try
            {
                for (int j = 0; j < quantidadeDeLados; j++)
                {
                    list.Add(random.Next(1, 40));
                }
                switch (quantidadeDeLados)
                {
                    case 3:
                        FormaGeometrica triangulo = new Triangulo(list);
                        Console.WriteLine(triangulo.ToString());
                        break;

                    case 4:
                        FormaGeometrica quadrilatero = new Quadrilatero(list);
                        Console.WriteLine(quadrilatero.ToString());
                        break;

                    case 5:
                        FormaGeometrica pentagono = new Pentagono(list);
                        Console.WriteLine(pentagono.ToString());
                        break;

                    default:
                        throw new Exception($"---------- Uma forma geometrica necessita de ao menos 3 lados, porem foram encontradas somente {quantidadeDeLados}. ----------");
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(400);
        }
    }
}