## 📁 05-JogoAdivinhacao/README.md

```markdown
# 🎲 Projeto 05 - Jogo de Adivinhação

## 📖 Descrição
O computador sorteia um número secreto e você deve adivinhar! A cada tentativa, o jogo diz se o número é maior ou menor.

## 🎯 Objetivos de Aprendizado
- Trabalhar com classe `Random`
- Implementar lógica de jogo
- Usar loops com condições de parada
- Contar tentativas
- Validar entrada do usuário

## 📋 Requisitos

### Básico ✅
- [ ] Sortear número aleatório de 1 a 100
- [ ] Pedir palpite do usuário
- [ ] Informar se o número é maior ou menor
- [ ] Repetir até acertar
- [ ] Mostrar quantas tentativas levou

### Desafio Extra 🚀
- [ ] Limitar número máximo de tentativas
- [ ] Sistema de dificuldade (Fácil: 1-50, Médio: 1-100, Difícil: 1-500)
- [ ] Ranking de pontuação (menos tentativas = mais pontos)
- [ ] Opção de jogar novamente
- [ ] Salvar recorde de menor número de tentativas
- [ ] Adicionar dicas extras a cada 3 tentativas erradas
- [ ] Timer para adicionar desafio de tempo

## 💡 Dicas

```csharp
// Gerar número aleatório:
Random random = new Random();
int numeroSecreto = random.Next(1, 101); // 1 a 100

// Loop do jogo:
int tentativas = 0;
bool acertou = false;

while (!acertou)
{
    int palpite = Convert.ToInt32(Console.ReadLine());
    tentativas++;
    
    if (palpite < numeroSecreto)
        Console.WriteLine("O número é MAIOR!");
    else if (palpite > numeroSecreto)
        Console.WriteLine("O número é MENOR!");
    else
    {
        Console.WriteLine($"PARABÉNS! Você acertou em {tentativas} tentativas!");
        acertou = true;
    }
}
```

## 🎓 Exemplo de Saída

```
╔══════════════════════════════════╗
║   JOGO DA ADIVINHAÇÃO           ║
║   Adivinhe o número de 1 a 100  ║
╚══════════════════════════════════╝

Tentativa #1
Digite seu palpite: 50
❌ O número é MAIOR!

Tentativa #2
Digite seu palpite: 75
❌ O número é MENOR!

Tentativa #3
Digite seu palpite: 65
❌ O número é MAIOR!

Tentativa #4
Digite seu palpite: 68
✓ PARABÉNS! Você acertou!

═══════════════════════════════
Número secreto: 68
Tentativas: 4
Pontuação: 96 pontos
═══════════════════════════════

Jogar novamente? (S/N): n
```

## 🐛 Problemas Comuns

**Sempre sorteia o mesmo número?**
- Crie o objeto `Random` apenas uma vez, fora do loop

**Aceita números fora do intervalo?**
- Adicione validação antes de processar o palpite

## ▶️ Como Executar

```bash
cd 05-JogoAdivinhacao
dotnet run
```

## 🔗 Navegação
[← 04 - Lista de Compras](../04-ListaCompras/README.md) | [06 - Cadastro Alunos →](../06-CadastroAlunos/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```

---