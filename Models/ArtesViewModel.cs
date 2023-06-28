namespace ArteMvc.Models
{
    public class ArtesViewModel
    {
          public int Id { get; set; }
            public string Titulo { get; set; }
            public string Categoria { get; set; }
            public string Artista { get; set; } = string.Empty;
            public int Data { get; set; }
            public string Descricao { get; set; }

            public string Localizacao { get; set; }
    }
}