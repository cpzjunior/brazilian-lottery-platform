🇺🇸 [English](README.md) | 🇧🇷 [Português](README.pt-BR.md)

# Brazilian Lottery Platform

A .NET 10 application for managing Brazilian lottery data, generating lottery games, and providing access through REST APIs and the Model Context Protocol (MCP).

## REST API Endpoints

### Health

| Method | Endpoint | Description |
|---|---|---|
| GET | `/health` | Returns the application health status and current UTC timestamp. |

### Lottery Types

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/lottery/type` | Retrieves available lottery types. |

### Lottery Configuration

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/lottery/config/{lotteryType}` | Retrieves a lottery configuration. |
| PUT | `/api/lottery/config/{lotteryType}` | Updates a lottery configuration. |

### Lottery History

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/lottery/history/{lotteryType}` | Retrieves all draw history. |
| GET | `/api/lottery/history/{lotteryType}/{drawId}` | Retrieves a specific draw. |
| GET | `/api/lottery/history/latest/{lotteryType}` | Retrieves the latest draw. |
| POST | `/api/lottery/history/{lotteryType}` | Adds or updates draw results. |
| POST | `/api/lottery/history/import/{lotteryType}` | Imports draw history from a CSV file. |

### Game Generation

| Method | Endpoint | Description |
|---|---|---|
| POST | `/api/lottery/game/generate/{lotteryType}` | Generates games based on user-defined criteria. |

### Budget-Based Game Distribution

| Method | Endpoint | Description |
|---|---|---|
| POST | `/api/lottery/game/budget/distribution/{lotteryType}` | Calculates ticket quantities and sizes for a given budget, minimizing the number of physical tickets. Does not generate numbers. |
| POST | `/api/lottery/game/budget/generate/{lotteryType}` | Calculates ticket distribution and generates the corresponding games. |

## Model Context Protocol (MCP)

The MCP server exposes lottery functionalities through the `/mcp` endpoint for MCP-compatible clients.

The MCP server and REST API share the same application and domain logic.

## Running the Application

Run the application from the repository root:

```bash
dotnet run --project src/BrazilianLotteryPlatform
```

The application uses the HTTPS launch profile.

Run the automated tests:

```bash
dotnet test
```

## Contributing

Contributions are welcome!

If you would like to contribute to this project:

1. Fork the repository.
2. Create a branch for your changes.
3. Make your changes and ensure the project builds successfully.
4. Run the existing tests and add new tests when applicable.
5. Submit a Pull Request describing your changes.

For bug reports, feature requests, or questions, please open an issue.

By contributing, you agree that your contributions will be licensed under the same license as this project.

## License

This project is licensed under the [MIT License](LICENSE).
