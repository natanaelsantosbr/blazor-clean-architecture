using Livaria.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livaria.Domain.Entities
{
    public class Livro
    {
        public Livro(int livroId, string? titulo, string? autor, DateTime lancamento, string? capa, EditoraEnum editoria, CategoriaEnum categoria)
        {
            LivroId = livroId;
            Titulo = titulo;
            Autor = autor;
            Lancamento = lancamento;
            Capa = capa;
            Editoria = editoria;
            Categoria = categoria;
        }

        public int LivroId { get; set; }

        [Required(ErrorMessage = "Informe o titulo do livro")]
        [StringLength(150)]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Informe o autor do livro")]
        [StringLength(200)]
        public string? Autor { get; set; }

        [Required(ErrorMessage = "Informe a data de lancamento")]
        public DateTime Lancamento { get; set; }

        [Required(ErrorMessage = "Informe a imagem da capa")]
        [StringLength(200)]
        public string? Capa { get; set; }

        [Required]
        [EnumDataType(typeof(EditoraEnum), ErrorMessage = "Selecione a editoria")]
        public EditoraEnum Editoria { get; set; }

        [Required]
        [EnumDataType(typeof(CategoriaEnum), ErrorMessage = "Selecione a categoria")]
        public CategoriaEnum Categoria { get; set; }
    }
}
