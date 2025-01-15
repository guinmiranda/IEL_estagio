Cadastro de Estudantes IEL:

Primeiramento agradeço ao IEL pela oportunidade de aprender e de sair da zona de conforto, gostei muito do desafio que foi fazer esse projeto aprendendo tudo praticamente do zero :) 

Esse é um sistema desenvolvido para gerenciar o cadastro de estudantes do IEL. A aplicação permite cadastrar, editar, listar e excluir estudantes, mantendo informações como nome, CPF, endereço e data de conclusão.

🚀 Começando
Essas instruções permitirão que você obtenha uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e teste.

📋 Pré-requisitos
Antes de começar, certifique-se de que você tem os seguintes softwares instalados:

.NET Core: Para compilar e executar o projeto.
SQL Server: Banco de dados utilizado pelo projeto.
Visual Studio ou Visual Studio Code: IDEs recomendadas para desenvolvimento.
Bootstrap: Framework de front-end utilizado para criar um design responsivo e atrativo para a aplicação.
DataTables: Biblioteca jQuery utilizada para criar tabelas interativas e dinâmicas com recursos como paginação, pesquisa e ordenação.
Entity Framework: ORM utilizado para facilitar a interação com o banco de dados SQL Server, realizando operações de CRUD de forma eficiente e simplificada.

🔧 Instalação
Clonar o repositório;
Configurar o banco de dados;
Crie um banco de dados no SQL Server. Em seguida, altere a string de conexão no arquivo appsettings.json para apontar para o seu banco de dados;
Execute as migrations para garantir que o esquema do banco de dados esteja atualizado com o modelo de dados.

📦 Implantação
Para implantar este sistema em um ambiente de produção:

Configuração do banco de dados
Garanta que o banco de dados SQL Server esteja configurado e acessível pelo ambiente de produção.

Configuração do servidor web
Implante o sistema em um servidor que suporte ASP.NET Core. O ambiente recomendado para produção é o IIS ou o Kestrel com um proxy reverso.

Variáveis de ambiente
Configure as variáveis de ambiente necessárias, como string de conexão do banco de dados, no servidor.

🛠️ Construído com
ASP.NET MVC: Framework utilizado para o desenvolvimento da aplicação web.
Entity Framework: ORM utilizado para facilitar a interação com o banco de dados SQL Server.
SQL Server: Banco de dados utilizado para armazenar as informações dos estudantes.
🖇️ Colaborando
Por favor, leia o COLABORACAO.md para obter detalhes sobre o nosso código de conduta e o processo para nos enviar pedidos de solicitação.

✒️ Autor
Guilherme Miranda - https://www.linkedin.com/in/guinmiranda/

