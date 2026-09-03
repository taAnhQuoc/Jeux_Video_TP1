using UnityEngine;

public class ZoneInterdite : MonoBehaviour
{
    [SerializeField] private Transform pointDepart;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO 1 : vérifier que l'objet possède le tag Player.
        if (!autre.CompareTag("Player"))
        {
            return;
           
        }

        if (pointDepart == null)
        {
           Debug.LogError("Le point de départ n'est pas assigné.");
        }
        Debug.Log("Le robot retourne au point de départ.");
        autre.transform.position = pointDepart.position;



        // TODO 2 : vérifier que PointDepart est assigné.
        // TODO 3 : replacer le joueur et afficher un message.
    }

    /*
     * BANQUE DE LIGNES — CERTAINES LIGNES SONT UTILISÉES DEUX FOIS
     *
     * Debug.Log("Le robot retourne au point de départ.");
     * autre.transform.position = pointDepart.position;
     * if (!autre.CompareTag("Player"))
     * Debug.LogError("Le point de départ n'est pas assigné.");

     */
}
