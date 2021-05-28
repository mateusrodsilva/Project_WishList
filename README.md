# Project_WishList

## Descrição do Projeto
<p align="center" id="Sobre">Desafio proposto pelo senai, para desenvolver uma api de uma Wish List(Lista de desejos) ultilizando tecnológias tratada em aula</p>

## Tecnologias


### Banco de dados

O banco de dados do Project_WishList foi desenvolvido através das modelagens: conceitual, lógica e física

Após a modelagem, foram gerados os scripts de criação (DDL), manipulação (DML) e consulta (DQL) utilizando MSSQL como linguagem

### Back-end

O back-end do Project_WishList foi desenvolvido construindo uma Web API utilizando C# como linguagem fornecendo e recebendo dados no formato JSON

Foi utilizado o ORM Entity Framework com o método Database First

A arquitetura da aplicação segue o padrão REST e os endpoints estão documentados através do Swagger

A estrutura foi dividida entre Domains, Controllers, Interfaces e Repositories

Implementada autenticação e autorização utilizando JWT

#### Observação

A API desenvolvida com .NET Core 5.0.6 (./backend) está habilitada para requisições http usando a porta :5000

### Front-end

O front-end do Project_WishList foi desenvolvido em JavaScript utilizando a biblioteca React.Js