using System;
using System.Globalization;

namespace Hollywood
{
    class Participacao
    {
        public double desconto { get; set; }
        public Artista artista { get; private set; }

       public Participacao(double desconto, Artista artista)
        {
            this.desconto = desconto;
            this.artista = artista;
        }

        public double Custo()
        {
            double custo = artista.cache - desconto;
            return custo;
        }
        public override string ToString()
        {
            return artista.nome
                + ", Cachê: "
                + artista.cache.ToString("F2", CultureInfo.InvariantCulture)
                + ", Desconto: "
                + desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + Custo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
