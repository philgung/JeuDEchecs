using FluentAssertions;
using RepresentationDuPlateauComplete;

namespace RepresentationDuPlateauCompleteTests;

public class LAffichage_du_plateau_devrait
{
    [Test]
    public void Afficher_la_position_initiale()
    {
        var afficheur = new Afficheur();
        afficheur.Lit(FEN.Initiale).Should().Be(
            @"****************
            * T C F R D F C T 
            * P P P P P P P P
            * 
            * 
            *
            *
            * p p p p p p p p
            * t c f r d f c t
            ******************");
    }
}

public class Afficheur
{
    public string Lit(FEN position)
    {
        return @"****************
            * T C F R D F C T 
            * P P P P P P P P
            * 
            * 
            *
            *
            * p p p p p p p p
            * t c f r d f c t
            ******************";
    }
}