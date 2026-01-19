## 📁 09-JogoDaVelha/README.md

```markdown
# ⭕ Projeto 09 - Jogo da Velha

## 📖 Descrição
Implementação completa do clássico jogo da velha para dois jogadores com detecção de vitória e empate.

## 🎯 Objetivos de Aprendizado
- Trabalhar com **arrays bidimensionais** (matriz)
- Implementar lógica complexa de jogo
- Validar jogadas
- Detectar padrões (vitória em linhas, colunas, diagonais)
- Criar interface visual no console

## 📋 Requisitos

### Básico ✅
- [ ] Tabuleiro 3x3
- [ ] Alternância entre jogadores (X e O)
- [ ] Validar jogadas (posição válida e vazia)
- [ ] Detectar vitória em:
  - Linhas (3 em sequência horizontal)
  - Colunas (3 em sequência vertical)
  - Diagonais (2 diagonais possíveis)
- [ ] Detectar empate (tabuleiro cheio sem vencedor)
- [ ] Exibir tabuleiro atualizado após cada jogada

### Desafio Extra 🚀
- [ ] Placar de vitórias (X vs O)
- [ ] Opção de jogar novamente sem fechar
- [ ] Destacar linha/coluna/diagonal vencedora
- [ ] Modo contra IA (computador joga automaticamente)
- [ ] Níveis de dificuldade da IA (fácil, médio, difícil)
- [ ] Histórico das últimas 5 partidas
- [ ] Animações e cores
- [ ] Permitir escolher símbolo (não apenas X e O)

## 💡 Dicas

```csharp
// Criar tabuleiro:
char[,] tabuleiro = new char[3, 3];

// Inicializar tabuleiro vazio:
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        tabuleiro[i, j] = ' ';

// Exibir tabuleiro:
public static void ExibirTabuleiro(char[,] tab)
{
    Console.Clear();
    Console.WriteLine("     1   2   3");
    Console.WriteLine("   ┌───┬───┬───┐");
    for (int i = 0; i < 3; i++)
    {
        Console.Write($" {i+1} │");
        for (int j = 0; j < 3; j++)
        {
            Console.Write($" {tab[i,j]} │");
        }
        Console.WriteLine();
        if (i < 2)
            Console.WriteLine("   ├───┼───┼───┤");
    }
    Console.WriteLine("   └───┴───┴───┘");
}

// Verificar vitória em linha:
public static bool VerificarLinha(char[,] tab, char jogador)
{
    for (int i = 0; i < 3; i++)
    {
        if (tab[i,0] == jogador && tab[i,1] == jogador && tab[i,2] == jogador)
            return true;
    }
    return false;
}

// Verificar diagonal:
public static bool VerificarDiagonal(char[,] tab, char jogador)
{
    // Diagonal principal
    if (tab[0,0] == jogador && tab[1,1] == jogador && tab[2,2] == jogador)
        return true;
    // Diagonal secundária
    if (tab[0,2] == jogador && tab[1,1] == jogador && tab[2,0] == jogador)
        return true;
    return false;
}

// Verificar empate:
public static bool VerificarEmpate(char[,] tab)
{
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
            if (tab[i,j] == ' ')
                return false; // Ainda há espaço
    return true;
}
```

## 🎓 Exemplo de Saída

```
╔════════════════════════════╗
║   JOGO DA VELHA v2.0       ║
║   X: João  vs  O: Maria    ║
╚════════════════════════════╝

     1   2   3
   ┌───┬───┬───┐
 1 │ X │ O │   │
   ├───┼───┼───┤
 2 │ O │ X │   │
   ├───┼───┼───┤
 3 │   │   │ X │
   └───┴───┴───┘

Vez de: X (João)
Digite linha (1-3): 3
Digite coluna (1-3): 1

     1   2   3
   ┌───┬───┬───┐
 1 │ X │ O │   │
   ├───┼───┼───┤
 2 │ O │ X │   │
   ├───┼───┼───┤
 3 │ X │   │ X │
   └───┴───┴───┘

╔════════════════════════════╗
║  ★ VITÓRIA DE X (João)! ★  ║
╚════════════════════════════╝

Diagonal vencedora!

═══ PLACAR GERAL ═══
X (João): 3 vitórias
O (Maria): 2 vitórias
Empates: 1
════════════════════

Jogar novamente? (S/N): n
```

## 🐛 Problemas Comuns

**Jogada em posição ocupada?**
- Valide se `tabuleiro[linha, coluna] == ' '` antes de aceitar

**Não detecta vitória?**
- Verifique todas as condições: 3 linhas + 3 colunas + 2 diagonais

**Índice fora do array?**
- Lembre-se: arrays começam em 0, mas é mais intuitivo mostrar 1-3 ao usuário
- Subtraia 1 do input: `linha = input - 1`

## ▶️ Como Executar

```bash
cd 09-JogoDaVelha
dotnet run
```

## 🔗 Navegação
[← 08 - Sistema Biblioteca](../08-SistemaBiblioteca/README.md) | [10 - Sistema Bancário →](../10-SistemaBancario/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```

---