🇺🇸 [English](README.md) | 🇧🇷 [Português](README.pt-BR.md)

# Plataforma de Loterias Brasileiras

Uma aplicação .NET 10 para gerenciar dados de loterias brasileiras, gerar jogos e disponibilizar acesso por meio de APIs REST e do Model Context Protocol (MCP).

## Endpoints da API REST

### Saúde

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/health` | Retorna o status de saúde da aplicação e o timestamp atual em UTC. |

### Tipos de Loteria

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/lottery/type` | Recupera os tipos de loteria disponíveis. |

### Configuração de Loteria

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/lottery/config/{lotteryType}` | Recupera uma configuração de loteria. |
| PUT | `/api/lottery/config/{lotteryType}` | Atualiza uma configuração de loteria. |

### Histórico de Loterias

| Método | Endpoint | Descrição |
|---|---|---|
| GET | `/api/lottery/history/{lotteryType}` | Recupera todo o histórico de sorteios. |
| GET | `/api/lottery/history/{lotteryType}/{drawId}` | Recupera um sorteio específico. |
| GET | `/api/lottery/history/latest/{lotteryType}` | Recupera o sorteio mais recente. |
| POST | `/api/lottery/history/{lotteryType}` | Adiciona ou atualiza os resultados dos sorteios. |
| POST | `/api/lottery/history/import/{lotteryType}` | Importa o histórico de sorteios a partir de um arquivo CSV. |

### Geração de Jogos

| Método | Endpoint | Descrição |
|---|---|---|
| POST | `/api/lottery/game/generate/{lotteryType}` | Gera jogos com base em critérios definidos pelo usuário. |

### Distribuição de Jogos Baseada em Orçamento

| Método | Endpoint | Descrição |
|---|---|---|
| POST | `/api/lottery/game/budget/distribution/{lotteryType}` | Calcula as quantidades e os tamanhos dos bilhetes para um determinado orçamento, minimizando o número de bilhetes físicos. Não gera números. |
| POST | `/api/lottery/game/budget/generate/{lotteryType}` | Calcula a distribuição dos bilhetes e gera os jogos correspondentes. |

## Model Context Protocol (MCP)

O servidor MCP disponibiliza funcionalidades de loteria por meio do endpoint `/mcp` para clientes compatíveis com MCP.

O servidor MCP e a API REST compartilham a mesma aplicação e lógica de domínio.

## Executando a Aplicação

Execute a aplicação a partir da raiz do repositório:

```bash
dotnet run --project src/BrazilianLotteryPlatform
