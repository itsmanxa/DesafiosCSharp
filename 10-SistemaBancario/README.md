# 🏦 Projeto 10 - Sistema Bancário

## 📖 Descrição
Sistema bancário completo com diferentes tipos de contas, operações financeiras, persistência de dados e tratamento de exceções.

## 🎯 Objetivos de Aprendizado
- Implementar **herança** (Conta → ContaCorrente, ContaPoupança)
- Usar **polimorfismo** (métodos sobrescritos)
- Criar **classes abstratas**
- Trabalhar com **interfaces**
- Implementar **exceções customizadas**
- Persistir dados em **arquivo JSON**
- Validar regras de negócio complexas

## 📋 Requisitos

### Básico ✅
- [ ] Classe abstrata `Conta` com: Número, Saldo, Titular
- [ ] `ContaCorrente`: herda de Conta, tem limite de cheque especial
- [ ] `ContaPoupanca`: herda de Conta, rende juros mensais
- [ ] Classe `Cliente`: Nome, CPF, Lista de Contas
- [ ] Operações:
  - Criar conta
  - Depositar
  - Sacar
  - Transferir entre contas
  - Consultar saldo e extrato
- [ ] Validações básicas (saldo suficiente, etc.)

### Desafio Extra 🚀
- [ ] Autenticação com senha
- [ ] Histórico completo de transações com data/hora
- [ ] Conta Salário (sem taxa, limite de saques)
- [ ] Taxa de manutenção mensal
- [ ] Rendimento automático da poupança
- [ ] Limite diário de saque
- [ ] Agendamento de transferências
- [ ] Relatórios detalhados (PDF, Excel)
- [ ] Exceções customizadas:
  - `SaldoInsuficienteException`
  - `ContaNaoEncontradaException`
  - `LimiteExcedidoException`

## 💡 Dicas

```csharp
// Arquivo Conta.cs (classe abstrata):
public abstract class Conta
{
    public int Numero { get; set; }
    public decimal Saldo { get; protected set; } // Protected: só modifica internamente
    public string Titular { get; set; }
    public List<string> Historico { get; set; }
    
    public Conta(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
        Saldo = 0;
        Historico = new List<string>();
    }
    
    public virtual void Depositar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("Valor deve ser positivo!");
            
        Saldo += valor;
        RegistrarTransacao($"Depósito: +{valor:C}");
    }
    
    public abstract bool Sacar(decimal valor); // Cada tipo implementa diferente
    
    protected void RegistrarTransacao(string descricao)
    {
        string registro = $"{DateTime.Now:dd/MM/yyyy HH:mm} - {descricao}";
        Historico.Add(registro);
    }
}

// Arquivo ContaCorrente.cs:
public class ContaCorrente : Conta
{
    public decimal LimiteChequeEspecial { get; set; }
    
    public ContaCorrente(int numero, string titular, decimal limite) 
        : base(numero, titular)
    {
        LimiteChequeEspecial = limite;
    }
    
    public override bool Sacar(decimal valor)
    {
        if (valor <= 0)
            return false;
            
        decimal saldoDisponivel = Saldo + LimiteChequeEspecial;
        
        if (valor > saldoDisponivel)
        {
            Console.WriteLine("Saldo insuficiente!");
            return false;
        }
        
        Saldo -= valor;
        RegistrarTransacao($"Saque: -{valor:C}");
        return true;
    }
}

// Arquivo ContaPoupanca.cs:
public class ContaPoupanca : Conta
{
    public decimal TaxaRendimento { get; set; } // Ex: 0.005 (0.5% ao mês)
    
    public ContaPoupanca(int numero, string titular) 
        : base(numero, titular)
    {
        TaxaRendimento = 0.005m;
    }
    
    public override bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Saldo)
            return false;
            
        Saldo -= valor;
        RegistrarTransacao($"Saque: -{valor:C}");
        return true;
    }
    
    public void AplicarRendimento()
    {
        decimal rendimento = Saldo * TaxaRendimento;
        Saldo += rendimento;
        RegistrarTransacao($"Rendimento: +{rendimento:C}");
    }
}

// Exceção customizada:
public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() 
        : base("Saldo insuficiente para realizar a operação!") { }
}

// Usar JSON para salvar (precisa: using System.Text.Json;):
string json = JsonSerializer.Serialize(contas, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText("contas.json", json);

// Carregar JSON:
string json = File.ReadAllText("contas.json");
var contas = JsonSerializer.Deserialize<List<Conta>>(json);
```

## 🎓 Exemplo de Saída

```
╔════════════════════════════════════════╗
║   🏦 BANCO DIGITAL v3.0                ║
║   Bem-vindo ao Sistema Bancário        ║
╚════════════════════════════════════════╝

[1] Criar conta
[2] Acessar conta
[3] Sair

Opção: 2

CPF: 123.456.789-00
Senha: ****

✓ Login realizado com sucesso!

═══════════════════════════════════════
Bem-vindo, João Silva!
───────────────────────────────────────
Conta Corrente #1001
Saldo: R$ 1.500,00
Limite disponível: R$ 500,00
Saldo total: R$ 2.000,00
═══════════════════════════════════════

[1] Consultar saldo
[2] Depositar
[3] Sacar
[4] Transferir
[5] Extrato
[6] Voltar

Opção: 3

Valor do saque: 200

═══════════════════════════════════════
✓ Saque realizado com sucesso!
───────────────────────────────────────
Valor: R$ 200,00
Novo saldo: R$ 1.300,00
Data: 20/01/2026 14:35
═══════════════════════════════════════

Opção: 5

═══════════════════════════════════════
         EXTRATO DETALHADO
───────────────────────────────────────
Conta: 1001 - João Silva
Período: Últimas 10 transações
───────────────────────────────────────
19/01/2026 10:00 - Depósito: +R$ 1.500,00
19/01/2026 14:30 - Saque: -R$ 100,00
20/01/2026 09:15 - Transferência para conta 1002: -R$ 300,00
20/01/2026 14:35 - Saque: -R$ 200,00
───────────────────────────────────────
Saldo atual: R$ 1.300,00
═══════════════════════════════════════
```

## 🐛 Problemas Comuns

**Erro ao salvar/carregar JSON?**
- Certifique-se de que as classes são serializáveis
- Use `JsonSerializer` do namespace `System.Text.Json`

**Herança não funcionando?**
- Verifique se usou `: base(parametros)` no construtor da classe filha

**Polimorfismo não funciona?**
- Use `virtual` no método da classe base e `override` na derivada

## ▶️ Como Executar

```bash
cd 10-SistemaBancario
dotnet run
```

## 🔗 Navegação
[← 09 - Jogo da Velha](../09-JogoDaVelha/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído

## 🎉 Parabéns!

Se chegou até aqui, você completou todos os 10 desafios e está pronto para projetos mais complexos!

### Próximos passos:
- Refatore seus projetos aplicando padrões de design
- Adicione testes unitários (xUnit)
- Crie APIs REST com ASP.NET Core
- Desenvolva aplicações desktop com WPF/WinForms
- Explore Blazor para aplicações web

**Continue praticando e bons estudos! 🚀**