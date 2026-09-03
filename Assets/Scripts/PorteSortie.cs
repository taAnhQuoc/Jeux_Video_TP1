using UnityEngine;

public class PorteSortie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO 1 : vérifier que l'objet possède le tag Player.
        if (!autre.CompareTag("Player"))
        {
            
            return;
        }
        Destroy(autre.gameObject);
        Debug.Log("MISSION RÉUSSIE !");
        // TODO 2 : afficher le message de réussite.
        // TODO 3 : faire disparaître le joueur.
    }

    /*
     * BANQUE DE LIGNES — À REPLACER DANS LE BON ORDRE
     *
     * Destroy(autre.gameObject);
     * Debug.Log("MISSION RÉUSSIE !");
     * if (!autre.CompareTag("Player"))
     * return;
     */
}

