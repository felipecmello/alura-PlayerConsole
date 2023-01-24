using TocadorConsole.NotasMusicais;
using TocadorConsole.Tocador;

public class Program
{
    public static void Main(String[] args)
    {
        NotasMusicais notas = new NotasMusicais();

        IList<INota> doReMiFa = new List<INota>() {
            notas.GetNota("do"),
            notas.GetNota("re"),
            notas.GetNota("mi"),
            notas.GetNota("fa"),
            notas.GetNota("fa"),
            notas.GetNota("fa"),

            notas.GetNota("do"),
            notas.GetNota("re"),
            notas.GetNota("do"),
            notas.GetNota("re"),
            notas.GetNota("re"),
            notas.GetNota("re"),

            notas.GetNota("do"),
            notas.GetNota("sol"),
            notas.GetNota("fa"),
            notas.GetNota("mi"),
            notas.GetNota("mi"),
            notas.GetNota("mi"),

            notas.GetNota("do"),
            notas.GetNota("re"),
            notas.GetNota("mi"),
            notas.GetNota("fa"),
            notas.GetNota("fa"),
            notas.GetNota("fa")
        };

        Tocador tocador = new Tocador();
        tocador.Play(doReMiFa);
        tocador.Play(doReMiFa);
    }
}
