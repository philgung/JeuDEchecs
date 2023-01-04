namespace RepresentationDuPlateauComplete;

public record FEN(string position)
{
    public static FEN Initiale = new("tcfrdfct/pppppppp/8/8/8/8/PPPPPPPP/TCFRDFCT w RDrd - 0 1");
}