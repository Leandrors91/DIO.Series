namespace DIO.Series
{
    public class Filme : EntidadeBase
    {
        public Filme(int id, Genero genero, string descricao, int ano, string titulo)
        {
            this.Genero = genero;
            this.Ano = ano;
            this.Descricao = descricao;
            this.Titulo = titulo;
            this.Id = id;
            this.Excluido = false;
        }
    }
}