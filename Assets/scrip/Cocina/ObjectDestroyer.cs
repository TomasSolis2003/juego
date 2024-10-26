using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // Tag del jugador para excluirlo de la destrucci�n
    public string playerTag = "Player";

    // Este m�todo se llama cuando otro collider entra en el trigger
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

