namespace RepresentationDuPlateauComplete;

public class Plateau
{
    public static uint[] Colonnes = { RepresentationDuPlateauComplete.Case.a, RepresentationDuPlateauComplete.Case.b, RepresentationDuPlateauComplete.Case.c, RepresentationDuPlateauComplete.Case.d, RepresentationDuPlateauComplete.Case.e, RepresentationDuPlateauComplete.Case.f, RepresentationDuPlateauComplete.Case.g, RepresentationDuPlateauComplete.Case.h };
    public static uint[] Lignes = { RepresentationDuPlateauComplete.Case._1, RepresentationDuPlateauComplete.Case._2, RepresentationDuPlateauComplete.Case._3, RepresentationDuPlateauComplete.Case._4, RepresentationDuPlateauComplete.Case._5, RepresentationDuPlateauComplete.Case._6, RepresentationDuPlateauComplete.Case._7, RepresentationDuPlateauComplete.Case._8 };
    private readonly Dictionary<uint, Case> _cases;

    public Plateau()
    {
        _cases = new Dictionary<uint, Case>();
        foreach (var colonne in Colonnes)
        {
            foreach (var ligne in Lignes)
            {
                _cases.Add(colonne|ligne, new Case());
            }
        }
    }

    public Case Case(uint coordonnées) => _cases[coordonnées];

    public FEN Export()
    {
        return FEN.Initiale;
    }

    public void Import(string positionFEN)
    {
        throw new NotImplementedException();
    }
}