# C214-L6_API_Music_NodeJS

<h1 align="center">Projeto de Design Patterns</h1>

<p align="center">
    <img src="https://programadoresdepre.com.br/wp-content/uploads/2021/10/Design-Patterns.jpg">
</p>
Imagem retirada do site Mira Flores: https://programadoresdepre.com.br/

### :books: Descrição

<p>Projeto de C214, disciplina de Engenharia de Software.</p>
<p>São dois projetos criados com implementação dos Design Patterns Strategy e Observer, e em ambos foram realizados testes unitários. Segue abaixo os respectivos enunciados:</p>

####
- Questão 1: Utilize o design pattern Strategy para implementar um sistema capaz de ordenar dados. O programa deverá permitir trocar o algoritmo de ordenação em tempo de execução. Utilize sua linguagem de programação favorita. Faça pelo menos 3 algoritmos diferentes. A ordenação pode acontecer de acordo com qualquer critério.

Observação: Para essa questão, foi construído um programa de lista telefônica capaz de ordenar os números em ordem crescente pelo DDD, Operadora ou pelo Número Completo. E mostrar os dados do responsável pelo número.

- Questão 2: Crie um aplicativo (programa) que recebe uma frase e quebre em palavras(String). A aplicação deve contar as palavras de acordo com os seguintes critérios: 

  Contar todas as palavras;
  Contar palavras com quantidades pares de caracteres;
  Contar palavras começadas com maiúsculas;
  Utilize o padrão observer.


#### Projeto
- Esse projeto foi construído usando a linguagem C# com o .NET 6.0. Além dos projetos pedidos nos enunciados, foi criado também projetos de testes unitários afim de validar os dois sistemas.
Para o projeto Questão1, foi usado três algorítmos de ordenação, sendo QuickSort, BubbleSort e Odd-Even.

### :computer: Funcionalidades dos Projetos
#### Funcionalidades de Questão 1
- Adiciona um novo numero telefônico com os dados do usuário responsável;
- Lista todas os números cadastradas com a possibilidade de ver os dados do usuário;
- Tal listagem exibe as informações em ordem crescente seguindo os critérios de  DDD, Operadora ou pelo Número Completo;

#### Funcionalidades de Questão 2
Ao inserir uma frase, todos os objetos observadores serão capaz de:
- Contar todas as palavras;
- Contar palavras com quantidades pares de caracteres;
- Contar palavras começadas com maiúsculas;

### :hammer_and_wrench: Instalação e Execução
#### Preparação do ambiente no computador para executar os programas
- [Git](https://git-scm.com/)
- [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/)


Clone o repositório em seu computador para poder acessar os projetos:
```
git clone https://github.com/flaviobergamini/C214-Design-Patterns.git
```
Para acessar o repositório clonado usando o terminal, digite: 
```
cd C214-Design-Patterns
```
Para acessar os arquivos de código dos projetos Questão 1 ou Questão 2 pelo terminal, digite:
```
cd Questao1
```
Ou 
```
cd Questao2
```

#### Instalando as dependências
Na respectiva pasta, instale as dependências do .NET usando o comando:
```
dotnet restore
```

#### Construindo Projeto
Após as instalações das dependências do projeto serem concluídas, construa o projeto usando o comando:
```
dotnet build
```

#### Iniciando Projeto
Inicie o projeto usando o comando:
```
dotnet run
```

### :hammer_and_wrench: Execução dos Testes Unitários
Para acessar os arquivos de código dos projetos de teste pelo terminal, digite:
```
cd Questao1Test
```
Ou 
```
cd Questao2Test
```
Na respectiva pasta, instale as dependências do .NET usando o comando:
```
dotnet restore
```
Após as instalações das dependências do projeto serem concluídas, construa o projeto usando o comando:
```
dotnet build
```
Inicie o projeto de teste usando o comando:
```
dotnet test
```

## :question: Dúvidas
Envie um email ao desenvolvedor: flaviohenrique@gec.inatel.br

## :gear: Autor

* **Flávio Henrique Madureira Bergamini** - [Flávio](https://github.com/flaviobergamini)

Sob a orientação do professor:
* **Christopher de Souza Lima Francisco** - [Christopher](https://github.com/chrislima)

