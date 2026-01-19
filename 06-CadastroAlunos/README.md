## 📁 06-CadastroAlunos/README.md

```markdown
# 🎓 Projeto 06 - Cadastro de Alunos

## 📖 Descrição
Sistema de cadastro de alunos com controle de notas, cálculo de média e aprovação/reprovação.

## 🎯 Objetivos de Aprendizado
- Criar e usar **classes** personalizadas
- Trabalhar com **propriedades** e **métodos**
- Usar `List<T>` com objetos customizados
- Implementar lógica de negócio em métodos
- Organizar código em múltiplos arquivos

## 📋 Requisitos

### Básico ✅
- [ ] Criar classe `Aluno` com: Nome, Idade, Lista de Notas
- [ ] Adicionar método para calcular média
- [ ] Cadastrar múltiplos alunos
- [ ] Exibir lista de alunos com suas médias
- [ ] Mostrar status: Aprovado (>=7) ou Reprovado (<7)

### Desafio Extra 🚀
- [ ] Ordenar alunos por média (maior para menor)
- [ ] Filtrar apenas aprovados ou reprovados
- [ ] Adicionar matrícula (código único)
- [ ] Permitir editar notas de um aluno
- [ ] Calcular média geral da turma
- [ ] Encontrar maior e menor média
- [ ] Salvar dados em arquivo JSON
- [ ] Gerar relatório formatado

## 💡 Dicas

```csharp
// Arquivo Aluno.cs:
public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; }
    
    public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Notas = new List<double>();
    }
    
    public double CalcularMedia()
    {
        if (Notas.Count == 0) return 0;
        return Notas.Average(); // Precisa: using System.Linq;
    }
    
    public string ObterStatus()
    {
        double media = CalcularMedia();
        return media >= 7 ? "Aprovado" : "Reprovado";
    }
}

// No Program.cs:
List<Aluno> alunos = new List<Aluno>();

// Adicionar aluno:
Aluno novoAluno = new Aluno("João", 16);
novoAluno.Notas.Add(8.5);
novoAluno.Notas.Add(7.0);
novoAluno.Notas.Add(9.0);
alunos.Add(novoAluno);

// Listar alunos:
foreach (var aluno in alunos)
{
    Console.WriteLine($"{aluno.Nome} - Média: {aluno.CalcularMedia():F2} - {aluno.ObterStatus()}");
}
```

## 🎓 Exemplo de Saída

```
╔═══════════════════════════════════╗
║   SISTEMA DE CADASTRO - ALUNOS    ║
╠═══════════════════════════════════╣
║  1 - Cadastrar aluno              ║
║  2 - Listar alunos                ║
║  3 - Buscar aluno                 ║
║  4 - Relatório geral              ║
║  5 - Sair                         ║
╚═══════════════════════════════════╝

Opção: 2

═════════════ LISTA DE ALUNOS ═════════════
┌────────────────────────────────────────┐
│ Nome: João Silva                       │
│ Idade: 16 anos                         │
│ Notas: 8.5 | 7.0 | 9.0               │
│ Média: 8.17                            │
│ Status: ✓ APROVADO                     │
└────────────────────────────────────────┘

┌────────────────────────────────────────┐
│ Nome: Maria Santos                     │
│ Idade: 15 anos                         │
│ Notas: 6.0 | 5.5 | 6.5               │
│ Média: 6.00                            │
│ Status: ✗ REPROVADO                    │
└────────────────────────────────────────┘

Total de alunos: 2
Aprovados: 1 (50%)
Reprovados: 1 (50%)
```

## 🐛 Problemas Comuns

**Erro "Object reference not set to an instance"?**
- Inicialize a lista de notas no construtor: `Notas = new List<double>();`

**Média dá zero ou NaN?**
- Verifique se há notas na lista antes de calcular

## ▶️ Como Executar

```bash
cd 06-CadastroAlunos
dotnet run
```

## 🔗 Navegação
[← 05 - Jogo Adivinhação](../05-JogoAdivinhacao/README.md) | [07 - Conversor Moedas →](../07-ConversorMoedas/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```
