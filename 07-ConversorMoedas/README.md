## 📁 07-ConversorMoedas/README.md

```markdown
# 💱 Projeto 07 - Conversor de Moedas

## 📖 Descrição
Conversor completo que permite conversão entre múltiplas moedas usando taxas de câmbio armazenadas.

## 🎯 Objetivos de Aprendizado
- Trabalhar com `Dictionary`
- Criar métodos com parâmetros e retorno
- Formatar valores monetários
- Implementar cálculos de conversão
- Organizar dados em estruturas complexas

## 📋 Requisitos

### Básico ✅
- [ ] Suportar pelo menos 5 moedas (BRL, USD, EUR, GBP, JPY)
- [ ] Armazenar cotações em Dictionary
- [ ] Permitir conversão entre qualquer par de moedas
- [ ] Exibir resultado formatado com símbolo da moeda
- [ ] Menu interativo

### Desafio Extra 🚀
- [ ] Permitir atualizar cotações manualmente
- [ ] Mostrar histórico de conversões
- [ ] Adicionar mais moedas (ARS, CAD, AUD, CHF)
- [ ] Calcular taxa de conversão inversa automaticamente
- [ ] Salvar cotações atualizadas em arquivo
- [ ] Exibir tabela comparativa de valores
- [ ] Validar valores mínimos/máximos

## 💡 Dicas

```csharp
// Dictionary com cotações (em relação ao Real):
Dictionary cotacoes = new Dictionary()
{
    { "BRL", 1.00 },      // Real (base)
    { "USD", 0.20 },      // Dólar
    { "EUR", 0.18 },      // Euro
    { "GBP", 0.16 },      // Libra
    { "JPY", 30.50 }      // Iene
};

// Método de conversão:
public static double Converter(double valor, string de, string para, Dictionary cotacoes)
{
    // Primeiro converte para BRL, depois para a moeda destino
    double valorEmBRL = valor / cotacoes[de];
    double valorConvertido = valorEmBRL * cotacoes[para];
    return valorConvertido;
}

// Formatar moeda:
Console.WriteLine($"Resultado: {valor:C2}"); // Formato de moeda
Console.WriteLine($"USD {valor:F2}"); // Personalizado
```

## 🎓 Exemplo de Saída

```
╔════════════════════════════════════╗
║   CONVERSOR DE MOEDAS v2.0         ║
╠════════════════════════════════════╣
║  Moedas disponíveis:               ║
║  • BRL - Real Brasileiro           ║
║  • USD - Dólar Americano           ║
║  • EUR - Euro                      ║
║  • GBP - Libra Esterlina           ║
║  • JPY - Iene Japonês              ║
╚════════════════════════════════════╝

Moeda de origem: USD
Valor a converter: 100
Moeda de destino: BRL

═══════════════════════════════════
💱 RESULTADO DA CONVERSÃO
───────────────────────────────────
   USD 100.00  →  BRL 500.00
   
   Taxa: 1 USD = 5.00 BRL
═══════════════════════════════════

Fazer outra conversão? (S/N): n
```

## 🐛 Problemas Comuns

**Erro "Key not found"?**
- Verifique se a moeda existe no Dictionary antes de acessar
- Use `ContainsKey()` para validar

**Conversão dá valor errado?**
- Lembre-se: converta primeiro para a moeda base (BRL), depois para a destino

## ▶️ Como Executar

```bash
cd 07-ConversorMoedas
dotnet run
```

## 🔗 Navegação
[← 06 - Cadastro Alunos](../06-CadastroAlunos/README.md) | [08 - Sistema Biblioteca →](../08-SistemaBiblioteca/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```

---