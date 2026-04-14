# WorkerF#

Serviço do tipo Worker Service escrito em F# que realiza requisições a uma API externa e processa dados de pessoas.

## Visão geral

Projeto de exemplo/serviço em background que demonstra:
- Estrutura de um Worker Service em F# (background processing).
- Modelo de dados para representação de pessoas (`Models/Pessoa.fs`).
- Consumo de API via módulos em `Requests/FetchAPI.fs`.
- Implementação do serviço de trabalho em `Worker.fs` e inicialização em `Program.fs`.

## Estrutura do projeto

- `Models/Pessoa.fs` - tipos que representam a entidade Pessoa e respostas.
- `Requests/FetchAPI.fs` - código responsável por chamar APIs externas e tratar respostas.
- `Worker.fs` - implementação do serviço em background que executa o processamento periódico.
- `Program.fs` - ponto de entrada e configuração do host do Worker Service.

## Requisitos

- .NET SDK instalado (recomendado 6.0 ou superior).
- Visual Studio 2022/2024/2026 ou VS Code para desenvolvimento.

## Como compilar e executar

No diretório raiz do repositório:

```bash
dotnet build
dotnet run
```

Ou abrir a solução no Visual Studio e executar o projeto `WorkerF#` (perfil `Worker Service`).

## Logs e debug

O serviço pode ser depurado a partir do Visual Studio configurando o perfil de execução do projeto. Saída de logs é exibida no console quando executado com `dotnet run`.

## Contribuição

Contribuições são bem-vindas. Abra uma issue para discutir mudanças ou envie um pull request com uma descrição clara do que foi alterado.

## Licença

Nenhuma licença foi definida explicitamente neste repositório. Se desejar, adicione um arquivo `LICENSE` com a licença preferida.
