using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // Tag del jugador para excluirlo de la destrucción
    public string playerTag = "Player";

    // Este método se llama cuando otro collider entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verifica que el objeto que colisiona no sea el jugador
        if (other.CompareTag(playerTag))
        {
            return;
        }

        // Destruye el objeto que colisiona
        Destroy(other.gameObject);
    }
}

