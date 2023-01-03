# Jeu d'Echecs
Template pour un jeu d'échecs

Suite au visionnage de cette [vidéo](https://www.youtube.com/watch?v=U4ogK0MIzqk&t=1288s), 
j'ai entrepris de débuter un repo pour créer un jeu d'échecs.

Je vais essayer de retracer mon avancement à travers ce readme.

## Jour 1 :

Début de l'analyse avec ce site [Chessprogramming](https://www.chessprogramming.org/Main_Page).

Je choisis de partir sur la [Notation FEN](https://www.chessprogramming.org/Forsyth-Edwards_Notation) 
comme indiqué dans la vidéo, pour son côté compact et précis. Cela me permettra de représenter une position 
de l'échiquier simplement.

`Notation FEN = <Plateau> <Trait> <Capacité à roquer> <Coup en passant> <Halfmove clock> <Compteur>`

Exemples :

`rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1`

Ligne1/Ligne2/Ligne3/Ligne4/Ligne5/Ligne6/Ligne7/Ligne8 (w|b) (-|KQkq) (-|a 3) (0|49) (1|22)

Objectifs
1. Ecrire un représentation du plateau complète sans bug
   1. Représentation du plateau
   2. Import et export d'une position à travers la notation FEN
   3. Déplacement des pièces possibles
   4. Déplacement illégales
2. Ecrire un moteur
   1. Search
   2. Evaluation
   3. Ouvertures (DB)
   4. Théorie Fin de partie
3. Connecter à un GUI