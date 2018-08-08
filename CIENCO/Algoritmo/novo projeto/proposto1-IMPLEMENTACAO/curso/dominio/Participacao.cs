using System.Globalization;

namespace curso.dominio {
    class Participacao {
        public double desconto { get; set; }
        public Artista artista { get; set; }
        public Filme filme { get; set; }

        public Participacao(double desconto, Artista artista, Filme filme) {
            this.desconto = desconto;
            this.artista = artista;
            this.filme = filme;
        }

        public double custo() {
            return artista.cache - desconto;
        }

        public override string ToString() {
            return artista.nome
                + ", Cachê: "
                + artista.cache
                + ", Desconto: "
                + desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + custo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
