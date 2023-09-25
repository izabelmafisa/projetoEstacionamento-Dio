namespace Estacionamento.Models
{ public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void EntradaVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void SaidaVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoHora * horas; 

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} saiu e o preço total foi de: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não se encontra aqui. Verifique se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
        
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados: ");
                foreach (String carro in veiculos){
                    Console.WriteLine(carro);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos nesse estacionamento.");
            }
        }
    }
}