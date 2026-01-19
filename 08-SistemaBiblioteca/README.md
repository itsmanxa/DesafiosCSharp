## 📁 08-SistemaBiblioteca/README.md

```markdown
# 📚 Projeto 08 - Sistema de Biblioteca

## 📖 Descrição
Sistema completo de gerenciamento de biblioteca com cadastro de livros, usuários e controle de empréstimos.

## 🎯 Objetivos de Aprendizado
- Trabalhar com **múltiplas classes** inter-relacionadas
- Implementar **encapsulamento** (propriedades privadas)
- Usar **composição** (classe contém outra classe)
- Validar regras de negócio
- Gerenciar estados de objetos

## 📋 Requisitos

### Básico ✅
- [ ] Classe `Livro`: Título, Autor, ISBN, Disponível
- [ ] Classe `Usuario`: Nome, CPF, LivrosEmprestados (lista)
- [ ] Cadastrar livros
- [ ] Cadastrar usuários
- [ ] Emprestar livro (marca como indisponível)
- [ ] Devolver livro (marca como disponível)
- [ ] Listar livros disponíveis
- [ ] Validação: não emprestar livro já emprestado

### Desafio Extra 🚀
- [ ] Adicionar data de empréstimo e devolução
- [ ] Calcular e cobrar multa por atraso (R$ 2,00/dia)
- [ ] Limitar número de livros por usuário (máx 3)
- [ ] Histórico de empréstimos
- [ ] Buscar livros por título ou autor
- [ ] Renovar empréstimo (estender prazo)
- [ ] Reservar livro que está emprestado
- [ ] Relatórios (livros mais emprestados, usuários inadimplentes)

## 💡 Dicas

```csharp
// Arquivo Livro.cs:
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public bool Disponivel { get; set; }
    public string EmprestadoPara { get; set; } // CPF do usuário
    
    public Livro(string titulo, string autor, string isbn)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Disponivel = true;
    }
}

// Arquivo Usuario.cs:
public class Usuario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public List<string> LivrosEmprestados { get; set; } // ISBNs
    
    public Usuario(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
        LivrosEmprestados = new List<string>();
    }
    
    public bool PodeEmprestar()
    {
        return LivrosEmprestados.Count < 3; // Limite de 3 livros
    }
}

// Arquivo Biblioteca.cs (classe de gerenciamento):
public class Biblioteca
{
    private List<Livro> livros = new List<Livro>();
    private List<Usuario> usuarios = new List<Usuario>();
    
    public bool EmprestarLivro(string isbn, string cpf)
    {
        var livro = livros.Find(l => l.ISBN == isbn);
        var usuario = usuarios.Find(u => u.CPF == cpf);
        
        if (livro == null || usuario == null)
            return false;
            
        if (!livro.Disponivel)
        {
            Console.WriteLine("Livro não disponível!");
            return false;
        }
        
        if (!usuario.PodeEmprestar())
        {
            Console.WriteLine("Usuário atingiu limite de empréstimos!");
            return false;
        }
        
        livro.Disponivel = false;
        livro.EmprestadoPara = cpf;
        usuario.LivrosEmprestados.Add(isbn);
        return true;
    }
}
```

## 🎓 Exemplo de Saída

```
╔═══════════════════════════════════════╗
║   SISTEMA DE BIBLIOTECA v1.0          ║
╠═══════════════════════════════════════╣
║  1 - Cadastrar livro                  ║
║  2 - Cadastrar usuário                ║
║  3 - Emprestar livro                  ║
║  4 - Devolver livro                   ║
║  5 - Listar livros disponíveis        ║
║  6 - Consultar usuário                ║
║  7 - Sair                             ║
╚═══════════════════════════════════════╝

Opção: 3

═══ EMPRESTAR LIVRO ═══
CPF do usuário: 123.456.789-00
ISBN do livro: 978-85-333-0227-3

✓ Empréstimo realizado com sucesso!

Detalhes:
───────────────────────────────────
Livro: O Senhor dos Anéis
Autor: J.R.R. Tolkien
Usuário: João Silva
Data empréstimo: 20/01/2026
Data devolução: 03/02/2026 (14 dias)
───────────────────────────────────

Opção: 6

Digite o CPF: 123.456.789-00

═══════════════════════════════════
DADOS DO USUÁRIO
───────────────────────────────────
Nome: João Silva
CPF: 123.456.789-00

Livros emprestados (1/3):
  1. O Senhor dos Anéis - Devolução: 03/02/2026
═══════════════════════════════════
```

## 🐛 Problemas Comuns

**Livro emprestado múltiplas vezes?**
- Sempre verifique `livro.Disponivel` antes de emprestar

**Usuário não consegue devolver?**
- Certifique-se de remover o ISBN da lista de empréstimos do usuário

**Dados perdidos ao reiniciar?**
- Implemente salvamento em arquivo (JSON ou TXT)

## ▶️ Como Executar

```bash
cd 08-SistemaBiblioteca
dotnet run
```

## 🔗 Navegação
[← 07 - Conversor Moedas](../07-ConversorMoedas/README.md) | [09 - Jogo da Velha →](../09-JogoDaVelha/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```

---