# 🚀 Etec - Projetos e Exercícios de Lógica em C#

Este repositório contém uma coleção de exercícios práticos desenvolvidos por **Alex**, estudante do 1º semestre de **Análise e Desenvolvimento de Sistemas (ADS)** na **Etec**. O projeto foca em algoritmos de console, cálculos matemáticos, gestão financeira e conversão de dados.

🔗 **GitHub:** [pereradev](https://github.com/pereradev)

---

## 📂 Projetos e Detalhes Técnicos

### 1. 📊 Fechamento Mensal (Gestão de Lucro/Prejuízo)
Sistema para análise da saúde financeira empresarial.
* **Variáveis Utilizadas:** `aluguel`, `agua`, `luz`, `telefone`, `internet`, `salario`, `gastoTotal`, `vendas`, `resultadoFinanceiro`.
* **Lógica:** Processa a soma de despesas fixas e compara com o faturamento mensal.
* **Destaque:** Implementação de estruturas condicionais `if`, `else if` e `else` para determinar o status da empresa.
* **Formatação:** Saída de dados em moeda nacional (`:C`).

### 2. ⛽ Calculadora de Combustível (Logística)
Algoritmo para previsão de custos em viagens rodoviárias.
* **Variáveis Utilizadas:** `distancia` (km), `consumo` (km/l), `valorCombustivel` (R$/l), `totalGasto`.
* **Destaque:** Código refatorado para melhorar a clareza dos nomes das variáveis (Clean Code).

### 3. 🌡️ Conversor de Temperatura (Fahrenheit para Celsius)
Aplicação de fórmulas físicas para conversão de escalas térmicas.
* **Variáveis Utilizadas:** `fahrenheit`, `celsius`.
* **Fórmula Aplicada:** $$celsius = \frac{fahrenheit - 32}{1.8}$$
* **Destaque:** Formatação numérica `:N2` para limitar o resultado a duas casas decimais.

### 4. 🏨 Sistema de Reserva de Hotel
Cálculo automatizado de hospedagem com regras de negócio.
* **Variáveis Utilizadas:** `valorDiaria`, `adultos`, `criancas`, `valorDiarioFamilia`, `valorTotal`, `parcelas`.
* **Regra Especial:** Lógica para cálculo de meia-entrada para crianças (50% do valor da diária).
* **Funcionalidade:** Divisão do valor total em parcelas customizáveis.

### 5. 📐 Cálculo de Área: Trapézio
Exercício de geometria analítica aplicado ao código.
* **Variáveis Utilizadas:** `base_maior`, `base_menor`, `altura`, `area`.
* **Otimização:** Cálculo realizado em linha única para reduzir o uso de variáveis temporárias:
  $$area = \frac{(base\_maior + base\_menor) \cdot altura}{2}$$

### 6. 🧮 Calculadora de Console
Ferramenta para operações aritméticas básicas (+, -, *, /).
* **Variáveis Utilizadas:** `n1`, `n2`, `operacao`, `resultado`, `operacaoValida`.
* **Estrutura:** Uso de `switch case` para controle de fluxo das operações.
* **Segurança:** Validação lógica para impedir a divisão por zero (`n2 != 0`).

### 7. 📈 Calculadora de Aumento Salarial (Recursos Humanos)
Sistema para calcular o reajuste de salário de um funcionário baseado em um percentual.
* **Variáveis Utilizadas:** `salarioBruto`, `percentualAumento`, `valorAumento`, `novoSalario`.
* **Fórmula Aplicada:** $$valorAumento = salarioBruto \cdot \left(\frac{percentualAumento}{100}\right)$$
* **Destaque:** Correção da lógica de porcentagem para encontrar o valor real do reajuste e exibição de ambas as saídas (o valor extra e o salário final) com formatação monetária (`:C`).

### 8. 🍽️ Divisor de Comanda de Restaurante (Gestão de Contas)
Aplicativo de rateio de despesas com opções de pagamento único ou divisão entre clientes.
* **Variáveis Utilizadas:** `comida`, `bebida`, `sobremesa`, `totalConta`, `pagarSozinho`, `pessoas`, `valorPorPessoa`.
* **Lógica:** Estruturas de decisão aninhadas (`if/else`) para ramificar o fluxo do programa (assumir a conta toda ou dividir).
* **Destaque:** Uso do método `.ToUpper()` para padronizar a entrada de texto do usuário ("S" ou "N"), evitando falhas por diferença de maiúsculas e minúsculas.
* **Segurança:** Validação (`pessoas > 0`) para impedir a falha matemática de divisão por zero na hora de ratear a conta.
* **Tipagem:** Implementação da classe `Convert` (`ToDouble` e `ToInt32`) na captura de dados.

---

## 🛠️ Tecnologias e Conceitos Aplicados

* **Linguagem:** C# (.NET Core).
* **Entrada de Dados:** `Console.ReadLine()` com conversão via `double.Parse` e `int.Parse`.
* **Saída de Dados:** Interpolação de strings `$""` para mensagens dinâmicas.
* **Tipagem:** Uso estratégico de `double` para cálculos precisos e `int` para contagens inteiras.
* **Segurança da Informação:** Introdução ao tratamento de erros lógicos (Divisão por zero e validação de operações).
