# Solution du cours 3 — Robot collecteur avec constructeur de scène

Cette archive contient les scripts, les ressources graphiques du module 2 et un outil Unity Editor qui construit automatiquement une scène complète avec sprites, décor et animations.

L’interface utilise un HUD futuriste : barre supérieure translucide, carte d’énergie avec icône et progression, carte d’intégrité, rappel des commandes et écrans de fin différenciés pour la victoire et la défaite.

## Installation

1. Fermez le mode Play dans Unity.
2. Copiez le dossier `Assets` de cette archive dans votre projet **Robot collecteur**.
3. Attendez la fin de la compilation.
4. Si Unity le demande, importez **TMP Essentials**.
5. Ouvrez `Outils > Robot collecteur > Constructeur de scène`.
6. Cliquez sur **Construire la scène**.
7. Ouvrez `Assets/Scenes/Cours3_RobotCollecteur.unity`, puis appuyez sur Play.

## Fonctionnement de la scène

- Déplacement : flèches ou WASD.
- Objectif : récupérer les trois batteries jaunes.
- Les zones dangereuses retirent une vie.
- La porte apparaît après la collecte des trois batteries.
- Toucher la porte déclenche la victoire.
- Le bouton **Recommencer** recharge la scène.
- La caméra suit le robot et respecte des limites.

## Important

Le constructeur remplace la scène `Assets/Scenes/Cours3_RobotCollecteur.unity` seulement après confirmation. Il prépare automatiquement les feuilles de sprites, crée les clips `Robot_Idle`, `Robot_Marche` et `Batterie_Idle`, crée les Animator Controllers et construit le décor à partir du tileset du module 2.

Version prévue : **Unity 6000.2.5f1 — Apple Silicon — projet Universal 2D**.

Si les touches ne répondent pas, ouvrez `Edit > Project Settings > Player`, puis choisissez **Active Input Handling : Both** ou **Input Manager (Old)**.
