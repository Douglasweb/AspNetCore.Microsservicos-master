﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CasaDoCodigo.OrdemDeCompra.Models
{
    [DataContract]
    public class ItemPedido : BaseModel
    {
        [Required]
        public Pedido Pedido { get; set; }
        [Required]
        [DataMember]
        public string ProdutoCodigo { get; set; }
        [Required]
        [DataMember]
        public string ProdutoNome { get; set; }
        [Required]
        [DataMember]
        public int ProdutoQuantidade { get; set; }
        [DataMember]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProdutoPrecoUnitario { get; set; }
        public decimal Subtotal => ProdutoQuantidade * ProdutoPrecoUnitario;

        public ItemPedido()
        {

        }

        public ItemPedido(string produtoCodigo, string produtoNome, int produtoQuantidade, decimal produtoPrecoUnitario)
        {
            ProdutoCodigo = produtoCodigo;
            ProdutoNome = produtoNome;
            ProdutoQuantidade = produtoQuantidade;
            ProdutoPrecoUnitario = produtoPrecoUnitario;
        }

        public void AtualizaQuantidade(int produtoQuantidade)
        {
            ProdutoQuantidade = produtoQuantidade;
        }
    }
}
