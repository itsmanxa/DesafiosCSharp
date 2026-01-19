## 📁 02-VerificadorIdade/README.md

```markdown
# 👶 Projeto 02 - Verificador de Idade

## 📖 Descrição
Classifique pessoas em categorias baseadas na idade informada: criança, adolescente, adulto ou idoso.

## 🎯 Objetivos de Aprendizado
- Usar estruturas condicionais (if/else if/else)
- Trabalhar com operadores relacionais (>, <, >=, <=)
- Validar entrada de dados
- Usar operadores lógicos (&&, ||, !)
- Concatenar e interpolar strings

## 📋 Requisitos

### Básico ✅
- [ ] Solicitar a idade do usuário
- [ ] Classificar em:
  - **Criança**: 0-12 anos
  - **Adolescente**: 13-17 anos
  - **Adulto**: 18-59 anos
  - **Idoso**: 60+ anos
- [ ] Exibir a classificação

### Desafio Extra 🚀
- [ ] Validar se a idade é um número válido (não negativo, não maior que 150)
- [ ] Pedir o nome da pessoa e personalizar a mensagem
- [ ] Adicionar subcategorias (bebê 0-2, criança 3-12, jovem adulto 18-25, etc.)
- [ ] Permitir verificar várias pessoas em sequência (loop)
- [ ] Informar quantos anos faltam para a próxima categoria
- [ ] Adicionar cores no console para cada categoria

## 💡 Dicas

```csharp
// Estrutura de condicionais encadeadas:
if (idade >= 0 && idade <= 12)
{
    Console.WriteLine("Você é uma criança!");
}
else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("Você é um adolescente!");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("Você é um adulto!");
}
else if (idade >= 60)
{
    Console.WriteLine("Você é um idoso!");
}

// Para validar entrada:
if (idade < 0 || idade > 150)
{
    Console.WriteLine("Idade inválida! Digite um valor entre 0 e 150.");
}

// Para mudar cor do texto:
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Criança!");
Console.ResetColor();
```

## 🎓 Exemplo de Saída

```
=== VERIFICADOR DE IDADE ===

Digite seu nome: João
Digite sua idade: 25

---------------------------------
Olá, João!
Você tem 25 anos.
Classificação: ADULTO

Faltam 35 anos para a próxima categoria (Idoso).
---------------------------------

Deseja verificar outra pessoa? (S/N): n
```

## 🐛 Problemas Comuns

**Não está entrando na condição certa?**
- Verifique a ordem dos `if/else if` - o primeiro que for verdadeiro será executado

**Aceitando idades negativas?**
- Adicione validação antes de classificar

## ▶️ Como Executar

```bash
cd 02-VerificadorIdade
dotnet run
```

## 🔗 Navegação
[← 01 - Calculadora](../01-CalculadoraSimples/README.md) | [03 - Tabuada →](../03-Tabuada/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```

---