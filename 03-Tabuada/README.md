## 📁 03-Tabuada/README.md

```markdown
# ✖️ Projeto 03 - Tabuada

## 📖 Descrição
Crie um programa que gera e exibe a tabuada de qualquer número escolhido pelo usuário.

## 🎯 Objetivos de Aprendizado
- Trabalhar com loops (`for`, `while`, `do-while`)
- Usar contadores e incrementos
- Formatar saída de forma organizada
- Combinar strings e números na saída

## 📋 Requisitos

### Básico ✅
- [ ] Solicitar um número ao usuário
- [ ] Exibir a tabuada desse número de 1 a 10
- [ ] Formatar a saída de forma legível

### Desafio Extra 🚀
- [ ] Permitir que o usuário escolha até qual número quer a tabuada (ex: de 1 até 15)
- [ ] Gerar tabuada de múltiplos números de uma vez (ex: de 1 a 5)
- [ ] Adicionar menu para escolher diferentes operações (soma, subtração, multiplicação, divisão)
- [ ] Salvar a tabuada em um arquivo de texto
- [ ] Criar formatação visual bonita (usando caracteres especiais)
- [ ] Permitir gerar novamente sem fechar o programa

## 💡 Dicas

```csharp
// Loop for básico:
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

// Para formatar de forma alinhada:
Console.WriteLine($"{numero,3} x {i,2} = {resultado,4}");

// Loop while alternativo:
int i = 1;
while (i <= 10)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
    i++;
}
```

## 🎓 Exemplo de Saída

```
=== GERADOR DE TABUADA ===

Digite o número para gerar a tabuada: 7
Até qual número deseja ir? (1-20): 10

╔════════════════════╗
║   TABUADA DO 7     ║
╠════════════════════╣
║  7 x  1 =   7      ║
║  7 x  2 =  14      ║
║  7 x  3 =  21      ║
║  7 x  4 =  28      ║
║  7 x  5 =  35      ║
║  7 x  6 =  42      ║
║  7 x  7 =  49      ║
║  7 x  8 =  56      ║
║  7 x  9 =  63      ║
║  7 x 10 =  70      ║
╚════════════════════╝

Gerar outra tabuada? (S/N): n
```

## 🐛 Problemas Comuns

**Loop infinito?**
- Certifique-se de incrementar o contador (`i++`)

**Tabuada não alinha direito?**
- Use formatação com largura fixa: `{numero,3}`

## ▶️ Como Executar

```bash
cd 03-Tabuada
dotnet run
```

## 🔗 Navegação
[← 02 - Verificador de Idade](../02-VerificadorIdade/README.md) | [04 - Lista de Compras →](../04-ListaCompras/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```

---