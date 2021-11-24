## ***RELATÓRIO DO TRABALHO DE PROGRAMAÇÃO ORIENTADA A OBJETOS 3***

- ### DIAGRAMA DE CLASSES DO PROJETO

![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/diagrama.png?raw=true)

#### A aplicação foi desenvolvida no padrão MVC com conexão ao banco de dados SQL server. Foi criado um sistema simples de Ecommerce, onde é possível cadastrar classes, produtos e clientes para a realização de uma compra. 

#### Um cliente pode fazer uma ou muitas compras, uma compra pode ter um ou muitos produtos e um produto pode conter somente uma categoria. 



#### **DATA ACCESS OBJECT (DAO)**

#### Tem como objetivo separar as camadas de regra de negócio com os dados. Ele abstrai todo o acesso da fonte de dados, além de fazer conexão com a fonte para obter e armazenar dados. Ele não é um CRUD, mas ele faz a interpretação dos métodos para linguagem  de nível SQL. Ele também faz execuções internas para que as demais classes não precisem fazer a comunicação com as abstrações de dados, deixando a comunicação a parte, organizando a aplicação. Não deve ser responsável por mais do que o acesso aos dados. Ao invés de termos várias partes com linguagem SQL no código, temos a mesma linguagem. É ideal quando o sistema precisa fazer diversas buscas e acesso a várias tabelas. É uma forma de dividir responsabilidades.

#### Na nossa aplicação, o padrão DAO foi utilizado através de classes, onde inserimos os atributos necessários para compor as informações e através das migrations transformamos em tabelas, por se tratar de um pequeno projeto de CRUD simples, a forma de usarmos o DAO foi esta, através da geração de tabelas das classes. Além da conexão com o banco de dados relacional SQL Server. 

### CONCLUSÃO:

#### Foi necessário juntar diversos conteúdos para que a aplicação funcionasse da maneira que esperávamos. Quanto aos testes unitários, somente o put passou em todos as autenticações. Seria necessário mais tempo para conseguirmos fazer todos os testes eficazes.  A dificuldade de desenvolvimento foi média, mas conseguimos atingir todos os objetivos e superar as expectativas e entregar o proposto.  



## Um tour pelo projeto:

- ### Tela Inicial:

  ![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/print1.png?raw=true)

- ### Listagem de Categorias

  ![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/print2.png?raw=true)

- ### Fornecendo valores nulos

  ![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/print3.png?raw=true)

  ![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/print4.png?raw=true)

![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/print5.png?raw=true)



## TESTE UNITÁRIO ESQUECIDO DE APRESENTAR NO VÍDEO:

- ![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/print6.png?raw=true)
- ![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/print7.png?raw=true)
- ![](https://github.com/majuliah/EcommerceProducts/blob/main/imgs/print8.png?raw=true)





#### ***LINK PARA O VÍDEO:***

https://fundacaooswaldoaranha.sharepoint.com/:v:/s/Trabalhos3/ESnR2PcfNc1JrJ42PaFkDbgBBc1KqBA5ucST2Z08_vENRA?email=rosenclever.gazoni%40foa.org.br&e=4HmkdJ



### REFERÊNCIAS BIBLIOGRÁFICAS:

- Microsoft: https://docs.microsoft.com/pt-br/aspnet/web-forms/overview/data-access/introduction/creating-a-data-access-layer-cs
- Microsoft: https://docs.microsoft.com/pt-br/cpp/mfc/dao-classes?view=msvc-170
- *Stack Overflow*: https://pt.stackoverflow.com/questions/113840/como-funciona-o-padrão-dao
- Hot Examples: https://csharp.hotexamples.com/pt/examples/BlueFox.AM.DAO/Site/-/php-site-class-examples.html
- Dev Media: https://www.devmedia.com.br/dao-com-ado-net-criando-um-cadastro-mestre-detalhe/31048

  

