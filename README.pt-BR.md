🇺🇸 [English](README.md) | 🇧🇷 [Português](README.pt-BR.md)

# Brazilian Lottery Platform

Uma aplicação .NET 10 para gerenciar dados das loterias brasileiras, gerar jogos e disponibilizar acesso por meio de APIs REST e do Model Context Protocol (MCP).

## Endpoints da API REST

### Saúde da Aplicação

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/health` | Retorna o status de saúde da aplicação e o timestamp atual em UTC. |

### Tipos de Loteria

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/lottery/type` | Recupera os tipos de loteria disponíveis. |

### Configuração das Loterias

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/lottery/config/{lotteryType}` | Recupera a configuração de uma loteria. |
| PUT | `/api/lottery/config/{lotteryType}` | Atualiza a configuração de uma loteria. |

### Histórico das Loterias

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/lottery/history/{lotteryType}` | Recupera todo o histórico de sorteios. |
| GET | `/api/lottery/history/{lotteryType}/{drawId}` | Recupera um sorteio específico. |
| GET | `/api/lottery/history/latest/{lotteryType}` | Recupera o sorteio mais recente. |
| POST | `/api/lottery/history/{lotteryType}` | Adiciona ou atualiza os resultados de sorteios. |
| POST | `/api/lottery/history/import/{lotteryType}` | Importa o histórico de sorteios a partir de um arquivo CSV. |

### Geração de Jogos

| Método | Endpoint | Descrição |
|---|---|---|
| POST | `/api/lottery/game/generate/{lotteryType}` | Gera jogos com base em critérios definidos pelo usuário. |

### Distribuição de Jogos por Orçamento

| Método | Endpoint | Descrição |
|---|---|---|
| POST | `/api/lottery/game/budget/distribution/{lotteryType}` | Calcula a quantidade e o tamanho das apostas para um determinado orçamento, minimizando o número de bilhetes físicos. Não gera números. |
| POST | `/api/lottery/game/budget/generate/{lotteryType}` | Calcula a distribuição das apostas e gera os jogos correspondentes. |

## Model Context Protocol (MCP)

O servidor MCP disponibiliza funcionalidades das loterias por meio do endpoint `/mcp` para clientes compatíveis com MCP.

O servidor MCP e a API REST compartilham a mesma aplicação e a mesma lógica de domínio.

## Execução da Aplicação

Execute a aplicação a partir da raiz do repositório:

```bash
dotnet run --project src/BrazilianLotteryPlatform
```

A aplicação utiliza o perfil de inicialização HTTPS.

Execute os testes automatizados:

```bash
dotnet test
```