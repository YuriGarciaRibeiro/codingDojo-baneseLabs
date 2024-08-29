
# CodingDojo - BaneseLabs

Este repositório contém o código-fonte de um projeto desenvolvido para auxiliar nas sessões de Code Dojo no BaneseLabs. É uma API Web construída em C# e projetada para ser consumida tanto pelo Front-End Code Dojo quanto pelo RPA (Automação de Processos Robóticos) Code Dojo.

## Estrutura do Projeto

- **WebApi/**: Contém o código-fonte da API Web.
- **.dockerignore**: Especifica arquivos e diretórios a serem ignorados durante a construção do Docker.
- **.gitignore**: Especifica arquivos e diretórios a serem ignorados no repositório Git.
- **codingDojo-baneseLabs.sln**: O arquivo de solução do projeto.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação principal do projeto.
- **Docker**: Usado para conteinerização.

## Começando

### Pré-requisitos

- .NET SDK
- Docker

### Instalação

1. Clone este repositório:
   \`\`\`bash
   git clone https://github.com/YuriGarciaRibeiro/codingDojo-baneseLabs.git
   \`\`\`
2. Navegue até o diretório do projeto:
   \`\`\`bash
   cd codingDojo-baneseLabs
   \`\`\`
3. Construa o projeto usando o CLI do .NET:
   \`\`\`bash
   dotnet build
   \`\`\`

### Executando o Projeto

Para executar a API Web localmente:
\`\`\`bash
dotnet run --project WebApi
\`\`\`

Para construir e executar o projeto usando Docker:
\`\`\`bash
docker build -t codingdojo-baneselabs .
docker run -d -p 8080:80 codingdojo-baneselabs
\`\`\`

## Contribuindo

Se você deseja contribuir para este projeto, faça um fork do repositório e envie um pull request.

## Licença

Este projeto é licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
