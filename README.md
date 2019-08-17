# DESAFIO CONFITEC

por: Uilton Lobo

### Estrutura da aplicação

- DesafioConfitec.WebApi: Camada contendo a api rest com as chamadas para as 4 operações;
- DesafioConfitec.Business: Camada contendo as classes para atender as regras de negócio. No nosso caso temos a classes para executar as quatro operações básicas. Aqui também estariam classes para consultas e atualizações em repositórios, chamadas a outros serviços e qualquer outras ações que atenderiam as regras de negócio da aplicação;
- DesafioConfitec.Test: Camada contendo testes unitários para a classe de negócio que está realizando as 4 operações;
- DesafioConfitec-Web: Interface web contendo a aplicação em Angular que realiza as chamadas a API para que o usuário execute as 4 operações.

### Dados do ambiente

- Desenvolvido em uma máquina com linux mint 19.2
- Editor Visual Studio Code
- .NET Core 2.2 (dotnet CLI)
- Angular 8.2.1
- Nodejs 10.16.3

### Para a execução dos testes unitários

- Acesse a pasta DesafioConfitec.Test
- execute ```dotnet test```

### Para a execução da web API

- Acesse a pasta DesafioConfitec.WebAPI
- execute ```dotnet run```

### Para a execução da interface web com angular:

- Mantenha a DesafioConfitec.WebAPI executando
- Acesse a pasta DesafioConfitec-Web
- execute ```ng serve```
- Abra a aplicação no browser acessando http://localhost:4200
- Acesse as telas através da barra de navegação na parte superior da página.