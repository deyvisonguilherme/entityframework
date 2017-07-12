using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext() : base("Name=ProductDb")
        {
            //Inicializador da base de Dados - Cria o banco caso ele não exista na string de conexão
            Database.SetInitializer<ProductDbContext>(new CreateDatabaseIfNotExists<ProductDbContext>());
            //False porque ai nosso inicializador só será executado se ele ainda não tiver sido executado anteriormente nesse DbContext.
            Database.Initialize(false);
        }

        //Dbset é um conjunto de dados que vai representar uma coleção das entidades da minha base de dados / entidades dentro do meu dbcontext
        //Mapeamento das duas entidades do dbcontext
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}
