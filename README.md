# Gerenciamento de Estoque

Este projeto é um sistema de gerenciamento de estoque desenvolvido em C# com MySQL/MariaDB. O objetivo é gerenciar produtos, fornecedores e pedidos em um ambiente de restaurante.

## Modelo de Dados

### Tabelas

#### Produtos
- **ProdutoID**: Chave primária única para identificar cada produto.
- **Nome**: Nome do produto.
- **Quantidade**: Quantidade disponível em estoque.
- **Preço**: Preço unitário do produto.
- **DataValidade**: Data de validade do produto.

#### Fornecedores
- **FornecedorID**: Chave primária única para identificar cada fornecedor.
- **Nome**: Nome do fornecedor.
- **Telefone**: Número de telefone do fornecedor.
- **Email**: Endereço de email do fornecedor.

#### Pedidos
- **PedidoID**: Chave primária única para identificar cada pedido.
- **ProdutoID**: Chave estrangeira referenciando a tabela Produtos.
- **FornecedorID**: Chave estrangeira referenciando a tabela Fornecedores.
- **Quantidade**: Quantidade do produto pedido.
- **DataPedido**: Data do pedido.

### Relações entre as Tabelas
A tabela `Pedidos` estabelece relacionamentos entre `Produtos` e `Fornecedores` através das chaves estrangeiras `ProdutoID` e `FornecedorID`.

## Escolhas de Design

### Interface de Usuário Simples e Intuitiva
- **Títulos e Ícones**: Utilizamos títulos claros e ícones para tornar a navegação mais intuitiva.
- **Layouts Organizados**: Usamos `TableLayoutPanel` e `FlowLayoutPanel` para organizar os componentes na tela.

### Estilização e Estética
- **Botões Estilizados**: Adicionamos cores, bordas arredondadas e ícones aos botões para melhorar a aparência visual e a usabilidade.
- **Paleta de Cores Consistente**: Usamos uma paleta de cores consistente para todas as telas.

### Feedback Visual
- **ToolTips**: Adicionamos `ToolTips` aos campos de entrada e botões para fornecer feedback adicional.
- **Mensagens de Sucesso e Erro**: Implementamos mensagens visuais para informar o usuário sobre o sucesso ou erro das operações CRUD.

### Experiência do Usuário (UX)
- **Placeholders nos Campos de Entrada**: Utilizamos placeholders nos campos de entrada para guiar o usuário.
- **Botões Desabilitados**: Desabilitamos botões quando não estão em uso para evitar ações indesejadas ou erros.

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

## Script SQL para Criação do Banco de Dados e Tabelas

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
