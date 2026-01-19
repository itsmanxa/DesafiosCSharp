## 📁 01-CalculadoraSimples/README.md

```markdown
# 🔢 Projeto 01 - Calculadora Simples

## 📖 Descrição
Seu primeiro projeto em C#! Crie uma calculadora que realiza as quatro operações básicas: soma, subtração, multiplicação e divisão.

## 🎯 Objetivos de Aprendizado
- Usar `Console.ReadLine()` para ler entrada do usuário
- Usar `Console.WriteLine()` para exibir saída
- Trabalhar com variáveis (int, double)
- Implementar operadores matemáticos (+, -, *, /)
- Converter strings para números (`Convert.ToDouble()` ou `double.Parse()`)
- Usar condicionais básicas (if/else)
- Formatar saída de números

## 📋 Requisitos

### Básico ✅
- [ ] Solicitar dois números ao usuário
- [ ] Realizar soma dos dois números
- [ ] Realizar subtração dos dois números
- [ ] Realizar multiplicação dos dois números
- [ ] Realizar divisão dos dois números
- [ ] Exibir os resultados formatados

### Desafio Extra 🚀
- [ ] Tratar divisão por zero com mensagem de erro
- [ ] Permitir que o usuário escolha qual operação fazer (menu)
- [ ] Criar um loop para repetir operações sem fechar o programa
- [ ] Formatar resultados com 2 casas decimais
- [ ] Adicionar operação de potência e raiz quadrada
- [ ] Validar se a entrada é um número válido

## 💡 Dicas

```csharp
// Para ler um número do usuário:
Console.Write("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

// Para verificar divisão por zero:
if (numero2 == 0)
{
    Console.WriteLine("Erro: Divisão por zero não é permitida!");
}
else
{
    double divisao = numero1 / numero2;
}

// Para formatar com 2 casas decimais:
Console.WriteLine($"Resultado: {resultado:F2}");
```

## 🎓 Exemplo de Saída

```
=== CALCULADORA SIMPLES ===

Digite o primeiro número: 10
Digite o segundo número: 5

--- RESULTADOS ---
10.00 + 5.00 = 15.00
10.00 - 5.00 = 5.00
10.00 * 5.00 = 50.00
10.00 / 5.00 = 2.00

Pressione qualquer tecla para sair...
```

## 🐛 Problemas Comuns

**Erro ao converter string para número?**
- Certifique-se de usar ponto (.) como separador decimal, não vírgula

**Resultado estranho na divisão?**
- Use `double` em vez de `int` para ter casas decimais

## ▶️ Como Executar

```bash
cd 01-CalculadoraSimples
dotnet run
```

## 🔗 Próximo Projeto
[02 - Verificador de Idade →](../02-VerificadorIdade/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```

---