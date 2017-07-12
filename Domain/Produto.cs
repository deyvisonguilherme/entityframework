using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//Para usar essa biblioteca, devemos adicionar a referencia que esta em assemblies ao projeto.
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    //Data Annotation -> Define o nome da tabela como Produto -> Tira a pluralização
    [Table("Produto")]
    public class Produto
    {
        [Key]
        //Não necessário usar a Annotation [Key]... Só pelo nome Id, já é entendido que será uma chave primária
        public int Id { get; set; }

        [MaxLength(200)]
        [Required] //Not Null
        public string Nome { get; set; }

        [MaxLength(2000)]
        public string Descricao { get; set; }

        [Range(-999999999999.99, 999999999999.99)]
        [Required]
        public decimal Valor { get; set; }

        [ForeignKey("Loja")]
        //A propriedade LojaId está linkada com a propriedade Loja porque a sua chave estrangeira está referenciando a propriedade virtual Loja
        public int LojaId { get; set; }

        //Quando o EF carrega um produto, automaticamente a loja também é carregada. Assim como ao carregar uma loja, todos os seus produtos são carregados
        public virtual Loja Loja { get; set; }
    }
}
