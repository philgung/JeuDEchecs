using FluentAssertions;
using RepresentationDuPlateauComplete;
using static RepresentationDuPlateauComplete.Plateau;

namespace RepresentationDuPlateauCompleteTests;

public class LInitialisation_du_plateau_devrait
{
    [Test]
    public void Etre_constitué_de_8x8_cases()
    {
        var plateau = new Plateau();

        foreach (var colonne in Colonnes)
        {
            foreach (var ligne in Lignes)
            {
                plateau.Case(colonne|ligne).Should().NotBeNull();
            }
        }
    }

    [Test]
    public void Exporter_le_plateau_initialisé()
    {
        var plateau = new Plateau();

        var export = plateau.Export();

        export.position.Should().Be("tcfrdfct/pppppppp/8/8/8/8/PPPPPPPP/TCFRDFCT w RDrd - 0 1");
    }
    
    
    [Test]
    [Ignore("a voir ensuite")]
    public void Importer_la_notation_FEN()
    {
        string position_initiale = "tcfrdfct/pppppppp/8/8/8/8/PPPPPPPP/TCFRDFCT w RDrd - 0 1";

        var plateau = new Plateau();
        plateau.Import(position_initiale);
    }
}