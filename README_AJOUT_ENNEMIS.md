# Ajouter les ennemis à la scène existante

Cette version conserve la scène originale `Assets/Scenes/Cours3_RobotCollecteur.unity` : décor industriel, parallaxe, HUD, batteries, obstacles, porte et minuterie.

## Procédure

1. Ouvrir le projet avec Unity **6000.2.5f1**.
2. Ouvrir la scène `Assets/Scenes/Cours3_RobotCollecteur.unity`.
3. Attendre la fin de la compilation.
4. Choisir **Outils > Robot collecteur > Ajouter les ennemis à la scène ouverte**.
5. Appuyer sur **Play**.

L'outil ajoute seulement :

- un groupe `Ennemis` dans la hiérarchie;
- deux ennemis à l'échelle adaptée au décor;
- deux déplacements différents : patrouille aller-retour et trajectoire ondulée;
- la poursuite du joueur lorsqu'il approche;
- la perte d'une vie et le retour au `PointDepart` après un contact;
- une impulsion colorée de l'ennemi et une légère secousse de caméra lors de l'attaque;
- les effets sonores de collecte, d'impact, d'objectif, de victoire et de défaite.
- un son de lancement et une ambiance électronique jouée en boucle.

La scène ouverte est sauvegardée, mais elle n'est ni reconstruite ni remplacée.

Si les ennemis sont déjà présents, exécuter de nouveau la commande met à jour leurs
types de déplacement sans créer de doublons.
