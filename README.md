# Trabalho - 2° bimestre

Este projeto é um sistema de gerenciamento de estoque desenvolvido em C# com MySQL/MariaDB. O objetivo é gerenciar produtos, fornecedores e pedidos em um ambiente de restaurante. Foi feito para a matéria de Programação Orientada a Objetos II, ministrada pelo prof. Wagner Perin.

## Modelo de Dados

### Tabelas

#### Produtos
- **ProdutoID**: Primary key única para identificar cada produto.
- **Nome**: Nome do produto.
- **Quantidade**: Quantidade disponível em estoque.
- **Preço**: Preço unitário do produto.
- **DataValidade**: Data de validade do produto.

#### Fornecedores
- **FornecedorID**: Primary key única para identificar cada fornecedor.
- **Nome**: Nome do fornecedor.
- **Telefone**: Número de telefone do fornecedor.
- **Email**: Endereço de email do fornecedor.

#### Pedidos
- **PedidoID**: Primary key única para identificar cada pedido.
- **ProdutoID**: Foreign Key referenciando a tabela Produtos.
- **FornecedorID**: Foreign Key referenciando a tabela Fornecedores.
- **Quantidade**: Quantidade do produto pedido.
- **DataPedido**: Data do pedido.

### Relações entre as Tabelas
A tabela `Pedidos` estabelece relacionamentos entre `Produtos` e `Fornecedores` através das FKs `ProdutoID` e `FornecedorID`.

## Escolhas de Design

### Interface de Usuário Simples e Intuitiva
- **Títulos e Ícones**: Coloquei títulos claros e ícones para tornar a navegação mais intuitiva.
- **Layouts Organizados**: Usei os comandos `TableLayoutPanel` e `FlowLayoutPanel` para organizar os componentes na tela.

### Estilização e Estética
- **Botões Estilizados**: Cooloquei cores, bordas arredondadas e ícones aos botões para melhorar a aparência visual e a usabilidade.
- **Paleta de Cores Consistente**: Usamos uma paleta de cores consistente e simples para todas as telas.

### Feedback Visual
- **ToolTips**: Adicionei `ToolTips` aos campos de entrada e botões para fornecer feedback adicional.
- **Mensagens de Sucesso e Erro**: Implementei mensagens de sucesso e de erro para informar o usuário sobre o resultado das operações CRUD.

### Experiência do Usuário (UX)
- **Placeholders nos Campos de Entrada**: Coloquei alguns placeholders nos campos de entrada para guiar o usuário.
- **Botões Desabilitados**: Desabilitei botões quando não estão em uso para evitar ações indesejadas ou erros.

## Funcionalidades do Sistema

### Formulário Produtos
- **Adicionar Produto**: Permite adicionar novos produtos ao estoque.
- **Atualizar Produto**: Permite atualizar as informações de um produto existente.
- **Excluir Produto**: Permite excluir um produto do estoque.
- **Pesquisar Produto**: Permite buscar produtos pelo ID.

### Formulário Fornecedores
- **Adicionar Fornecedor**: Permite adicionar novos fornecedores.
- **Atualizar Fornecedor**: Permite atualizar as informações de um fornecedor existente.
- **Excluir Fornecedor**: Permite excluir um fornecedor.
- **Pesquisar Fornecedor**: Permite buscar fornecedores pelo ID.

### Formulário Pedidos
- **Adicionar Pedido**: Permite adicionar novos pedidos.
- **Atualizar Pedido**: Permite atualizar as informações de um pedido existente.
- **Excluir Pedido**: Permite excluir um pedido.
- **Pesquisar Pedido**: Permite buscar pedidos pelo ID.

## Script SQL para criar o BD e as tabelas

```sql
-- Criação do Banco de Dados
CREATE DATABASE RestauranteDB;

-- Seleção do Banco de Dados
USE RestauranteDB;

-- Criação da Tabela Produtos
CREATE TABLE Produtos (
    ProdutoID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100),
    Quantidade INT,
    Preco DECIMAL(10, 2),
    DataValidade DATE
);

-- Criação da Tabela Fornecedores
CREATE TABLE Fornecedores (
    FornecedorID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100),
    Telefone VARCHAR(15),
    Email VARCHAR(100)
);

-- Criação da Tabela Pedidos
CREATE TABLE Pedidos (
    PedidoID INT AUTO_INCREMENT PRIMARY KEY,
    ProdutoID INT,
    FornecedorID INT,
    Quantidade INT,
    DataPedido DATE,
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID),
    FOREIGN KEY (FornecedorID) REFERENCES Fornecedores(FornecedorID)
);
