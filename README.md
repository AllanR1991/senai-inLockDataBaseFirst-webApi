# InLock Data Base First

Projeto criado, ensinando como utilizar o Entity Framework para fazer Data Base First.

1. Para utilização dessa metodologia, é necessario se ter ja o banco de dados criado e instalar os pacotes :

    Microsoft.EntityFrameworkCore.SqlServer
    
    Microsoft.EntityFrameworkCore.SqlServer.Design
    
    Microsoft.EnityFrameworkCore.Tools

2. Acessar no Visual Studio > Ferramentas > Gerenciador de Pacotes do Nuget > Console do Gerenciador de Pacotes</br></br></br>
    ![image](https://github.com/AllanR1991/senai-inLockDataBaseFirst-webApi/assets/22855740/b42f9736-d416-44d1-805c-df52ac2d9704)
</br></br></br>

3. Criar a pasta seguindo o Desing Pattern
   - Domains
   - Interfaces
   - Repositories
   - Controllers</br></br>
Exemplo: </br></br></br>
     ![image](https://github.com/AllanR1991/senai-inLockDataBaseFirst-webApi/assets/22855740/6e08f651-f12d-4e6e-a40e-863480755e77)



4. Digitar o seguinte comando:

     Scaffold-DbContext "Data Source=.\SqlExpress; Initial Catalog= InLock_Games_Manha; Integrated Security=True; TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Domains -ContextDir Contexts -Context BlogContext

  -  Explicão do codigo acima:
      - Comando :
        - Scaffold-DbContext
      - String de Conexao :
        - "Data Source=.\SqlExpress; Initial Catalog= InLock_Games_Manha; Integrated Security=True; TrustServerCertificate=True"
      - Provedor Utilizado:
        - Microsoft.EntityFrameworkCore.SqlServer
      - Nome da pasta onde ficarão os dominios:
        - -OutputDir Domains
      - Nome da pasta onde ficarão os contextos:
        - -Context BlogContext
      
