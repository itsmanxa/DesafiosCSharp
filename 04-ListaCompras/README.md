## 📁 04-ListaCompras/README.md

```markdown
# 🛒 Projeto 04 - Lista de Compras

## 📖 Descrição
Crie um sistema interativo para gerenciar uma lista de compras com opções de adicionar, remover e visualizar itens.

## 🎯 Objetivos de Aprendizado
- Trabalhar com `List<string>` (listas dinâmicas)
- Criar menus interativos com `switch/case`
- Usar métodos de lista (Add, Remove, Contains, Clear)
- Implementar loops com múltiplas opções
- Validar entrada do usuário

## 📋 Requisitos

### Básico ✅
- [ ] Menu com opções: Adicionar, Listar, Remover, Sair
- [ ] Adicionar itens à lista
- [ ] Mostrar todos os itens cadastrados
- [ ] Remover itens da lista
- [ ] Loop até o usuário escolher sair

### Desafio Extra 🚀
- [ ] Evitar itens duplicados
- [ ] Numerar os itens ao listar
- [ ] Remover por número/índice em vez de nome
- [ ] Adicionar quantidade aos itens (ex: "Arroz - 2kg")
- [ ] Salvar lista em arquivo de texto ao sair
- [ ] Carregar lista do arquivo ao iniciar
- [ ] Opção de limpar toda a lista
- [ ] Contar total de itens

## 💡 Dicas

```csharp
// Criar lista:
List<string> listaCompras = new List<string>();

// Adicionar item:
listaCompras.Add("Arroz");

// Listar todos os itens:
for (int i = 0; i < listaCompras.Count; i++)
{
    Console.WriteLine($"{i + 1}. {listaCompras[i]}");
}

// Remover item:
listaCompras.Remove("Arroz");

// Verificar se existe:
if (listaCompras.Contains("Arroz"))
{
    Console.WriteLine("Arroz já está na lista!");
}

// Menu com switch:
switch (opcao)
{
    case "1":
        // Código para adicionar
        break;
    case "2":
        // Código para listar
        break;
}
```

## 🎓 Exemplo de Saída

```
╔══════════════════════════════╗
║   LISTA DE COMPRAS v1.0      ║
╠══════════════════════════════╣
║  1 - Adicionar item          ║
║  2 - Listar itens            ║
║  3 - Remover item            ║
║  4 - Limpar lista            ║
║  5 - Sair                    ║
╚══════════════════════════════╝

Escolha uma opção: 1
Digite o item: Arroz
✓ Arroz adicionado com sucesso!

Escolha uma opção: 2

═══ LISTA DE COMPRAS (3 itens) ═══
1. Arroz
2. Feijão
3. Macarrão
════════════════════════════════════

Escolha uma opção: 3
Digite o número do item para remover: 2
✓ Feijão removido com sucesso!
```

## 🐛 Problemas Comuns

**Erro ao remover item que não existe?**
- Verifique se o item existe antes de remover com `Contains()`

**Lista não persiste após fechar?**
- Implemente salvamento em arquivo (desafio extra)

## ▶️ Como Executar

```bash
cd 04-ListaCompras
dotnet run
```

## 🔗 Navegação
[← 03 - Tabuada](../03-Tabuada/README.md) | [05 - Jogo Adivinhação →](../05-JogoAdivinhacao/README.md)

---
**Status**: ⬜ Não iniciado | 🟡 Em progresso | ✅ Concluído
```

---