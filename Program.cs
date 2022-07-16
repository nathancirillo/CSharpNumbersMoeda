using System.Globalization;

namespace NumbersMoeda
{
    static class Program
    {
        static void Main(string[]args)
        {
            // na maioria das vezes o melhor valor para trabalhar com moeda é decimal 
            // isso acontece, pois a precisão dele é maior. 

            Console.Clear(); 

            decimal valor = 10.25m; 
            System.Console.WriteLine($"Valor sem formatação: {valor}");

            // FORTAMAÇÃO DE MOEDA
            // no brasil não usamos ponto na moeda e sim vírgula. Podemos continuar usando 
            // o método toString() e o string.Format() passando a culture. 
            
            //formatação para o brasil
            var cultureBR = new CultureInfo("pt-BR"); 
            System.Console.WriteLine($"Valor formatado BR: {valor.ToString(cultureBR)}");
            System.Console.WriteLine("Com string.Format() = " + string.Format("{0:C}", valor));

            //formatação para o eua -> outra forma de criação (mais prática)           
            System.Console.WriteLine(
            @$"Valor formatado EN: {valor.ToString(CultureInfo.CreateSpecificCulture("en-US"))}
            ");

            //formatação usando formatadores: 
            //G -> padrão especifica como número com separador de milhar apenas (genérico)
            //N -> também formata para número com separador de milhar e casas decimais
            //F -> precisão maior
            //P -> formata para percentual
            //C -> vem de currency -> deixa a moeda na frente
            //E04 -> para números muito grande cria um padrão: 1,0250E+001
            
            //brasil 
            System.Console.WriteLine(
            $@"Valor BR com Formatter: {valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))
            }");

            //espanha
            System.Console.WriteLine(
            $@"Valor ES com Formatter: {valor.ToString("C", CultureInfo.CreateSpecificCulture("es-ES"))
            }");

            //eua
            System.Console.WriteLine(
            $@"Valor ES com Formatter: {valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
            }");   


            // ARREDONDAMENTO DE VALORES EM MOEDAS
            // devemos usar para isso a classe Math. Os métodos de arredondamento são: 
            // Round -> arredonda para cima ou para baixo (para cima ou para baixo)
            // Floor -> arredonda para baixo (para baixo)
            // Ceiling -> arredonda para cima (para cima)
            decimal newValue = 10536.25m;
            System.Console.WriteLine("Round: " + Math.Round(newValue));
            System.Console.WriteLine("Floor: " + Math.Floor(newValue));
            System.Console.WriteLine("Ceiling: " + Math.Ceiling(newValue));

        }
    }
}