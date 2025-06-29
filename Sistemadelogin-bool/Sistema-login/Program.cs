using System;

namespace SistemaValidacaoAcesso
{
    /// <summary>
    /// Sistema de Validação de Acesso com Variáveis Booleanas
    /// Programa educacional demonstrando o uso de bool em C#
    /// Autor: Desenvolvido para fins educacionais
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // PASSO 1: Apresentação do sistema
            Console.WriteLine("=" + new string('=', 48)); //interface
            Console.WriteLine("SISTEMA DE VALIDAÇÃO DE ACESSO");
            Console.WriteLine("=" + new string('=', 48));//interface
            Console.WriteLine();

            // PASSO 2: Coleta de dados do usuário
            Console.WriteLine(" ETAPA 1: Coleta de Informações");
            Console.WriteLine(new string('-', 30));//interface

            // Entrada de dados básicos com validação
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Digite sua idade: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
            {
                Console.Write("Por favor, digite uma idade válida:");
            }

            Console.WriteLine();

            // PASSO 3: Verificações usando variáveis booleanas
            Console.WriteLine(" ETAPA 2: Verificações de Segurança");
            Console.WriteLine(new string('-', 35));

            // Verificação 1: Idade mínima (18 anos)
            bool idadeValida = idade >= 18;
            Console.WriteLine($" Idade >= 18 anos: {idadeValida}");

            // Verificação 2: Nome não pode estar vazio
            bool nomeValido = !string.IsNullOrEmpty(nome) && nome.Length >= 2;
            Console.WriteLine($"Nome válido (min. 2 caracteres): {nomeValido}");

            // Verificação 3: Pergunta sobre documentação
            Console.Write("Possui documento válido? (S/N): ");
            bool temDocumento = ObterRespostaSimNao();
            Console.WriteLine($"Documento válido: {temDocumento}");

            // Verificação 4: Pergunta sobre termos de uso
            Console.Write("Aceita os termos de uso? (S/N): ");
            bool aceitaTermos = ObterRespostaSimNao();
            Console.WriteLine($"Termos aceitos: {aceitaTermos}");

            // Verificação 5: Verificação adicional de segurança
            Console.Write("É primeira vez no sistema? (S/N): ");
            bool primeiroAcesso = ObterRespostaSimNao();
            Console.WriteLine($"Primeiro acesso: {primeiroAcesso}");

            Console.WriteLine();

            // PASSO 4: Combinação lógica das verificações
            Console.WriteLine("ETAPA 3: Processamento das Condições");
            Console.WriteLine(new string('-', 38));

            // Exibição individual das condições
            Console.WriteLine($"• Idade válida: {idadeValida}");
            Console.WriteLine($"• Nome válido: {nomeValido}");
            Console.WriteLine($"• Tem documento: {temDocumento}");
            Console.WriteLine($"• Aceita termos: {aceitaTermos}");
            Console.WriteLine($"• Primeiro acesso: {primeiroAcesso}");
            Console.WriteLine();

            // Combinação de condições obrigatórias
            bool condicoesBasicas = idadeValida && nomeValido && temDocumento && aceitaTermos;
            Console.WriteLine($"Condições básicas atendidas: {condicoesBasicas}");

            // Verificação adicional para primeiro acesso
            bool verificacaoAdicional = !primeiroAcesso || (primeiroAcesso && condicoesBasicas);
            Console.WriteLine($"Verificação adicional: {verificacaoAdicional}");

            // Resultado final combinando todas as verificações
            bool acessoLiberado = condicoesBasicas && verificacaoAdicional;
            Console.WriteLine();
            Console.WriteLine($"RESULTADO FINAL: {acessoLiberado}");

            Console.WriteLine();

            // PASSO 5: Decisão final baseada no resultado booleano
            Console.WriteLine(" ETAPA 4: Decisão de Acesso");
            Console.WriteLine(new string('-', 26));

            if (acessoLiberado)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"ACESSO LIBERADO para {nome}!");
                Console.WriteLine("Bem-vindo(a) ao sistema!");

                // Informações adicionais baseadas nas condições
                if (primeiroAcesso)
                {
                    Console.WriteLine("Como é seu primeiro acesso, você receberá um tutorial.");
                }
                else
                {
                    Console.WriteLine("Acesso de usuário recorrente identificado.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ACESSO NEGADO!");
                Console.WriteLine("Motivos da negação:");

                // Análise detalhada dos motivos da negação
                if (!idadeValida)
                    Console.WriteLine("  • Idade insuficiente (mínimo 18 anos)");
                if (!nomeValido)
                    Console.WriteLine("  • Nome inválido ou muito curto");
                if (!temDocumento)
                    Console.WriteLine("  • Documento válido não apresentado");
                if (!aceitaTermos)
                    Console.WriteLine("  • Termos de uso não aceitos");
            }

            // Reset da cor do console
            Console.ResetColor();
            Console.WriteLine();

            // PASSO 6: Estatísticas finais
            Console.WriteLine("ETAPA 5: Estatísticas da Validação");
            Console.WriteLine(new string('-', 35));

            int condicoesAtendidas = 0;
            if (idadeValida) condicoesAtendidas++;
            if (nomeValido) condicoesAtendidas++;
            if (temDocumento) condicoesAtendidas++;
            if (aceitaTermos) condicoesAtendidas++;

            double percentualSucesso = (condicoesAtendidas / 4.0) * 100;

            Console.WriteLine($"Condições atendidas: {condicoesAtendidas}/4");
            Console.WriteLine($"Percentual de sucesso: {percentualSucesso:F1}%");
            Console.WriteLine($"Status final: {(acessoLiberado ? "APROVADO" : "REPROVADO")}");

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        /// <summary>
        /// Método auxiliar para obter resposta Sim/Não do usuário
        /// Retorna: true para Sim, false para Não
        /// </summary>

        static bool ObterRespostaSimNao()
        {
            string resposta;
            do
            {
                resposta = Console.ReadLine()?.Trim().ToUpper() ?? "";

                if (resposta == "S" || resposta == "SIM")
                    return true;
                else if (resposta == "N" || resposta == "NAO" || resposta == "NÃO")
                    return false;
                else
                    Console.Write("Resposta inválida. Digite S para Sim ou N para Não: ");

            } while (true);
        }
    }
}