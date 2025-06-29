# Sistema de Validação com Variáveis Booleanas

## Sobre o Projeto

Sistema educacional em **C#** que demonstra o uso prático de variáveis `bool` através de um fluxo de validação de acesso com múltiplas verificações.

## Objetivo

Ensinar conceitos fundamentais de programação:
- Uso de variáveis booleanas (`bool`)
- Operadores lógicos (`&&`, `||`, `!`)
- Validação de entrada de dados
- Estruturas condicionais

## Funcionalidades

- Validação de idade (18+ anos)
- Verificação de nome válido
- Confirmação de documento
- Aceitação de termos de uso
- Interface colorida no console
- Análise estatística dos resultados

## Como Executar

```bash
# Clone o projeto
git clone https://github.com/nicoly-rsousa/sistemaLoginbool.git

# Execute
dotnet run
```

**Pré-requisito:** .NET SDK 6.0+

## Exemplo de Uso

```
Digite seu nome: Nicoly
Digite sua idade: 25
Possui documento válido? (S/N): S
Aceita os termos de uso? (S/N): S

RESULTADO FINAL: True
ACESSO LIBERADO para Nicoly!

## Conceitos Demonstrados

**Variáveis Bool:**
csharp
bool idadeValida = idade >= 18;
bool acessoLiberado = idadeValida && nomeValido && temDocumento;
```

**Validação de Entrada:**
csharp
while (!int.TryParse(Console.ReadLine(), out idade))
    Console.Write("Digite uma idade válida: ");


## Estrutura

- **Program.cs** - Código principal
- **ObterRespostaSimNao()** - Método auxiliar para entrada S/N
- Interface em 5 etapas bem definidas
- Tratamento de erros e validações

---

**Projeto educacional para demonstração de conceitos / programação em C#**