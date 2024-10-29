using UnityEngine;

public class FryAssembler : MonoBehaviour
{
    public GameObject coneDePapasPrefab; // Prefab del cono de papas
    public Transform spawnPoint; // Punto donde se generará el cono de papas

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fry"))
        {
            // Crear el cono de papas en el punto de spawn
            Instantiate(coneDePapasPrefab, spawnPoint.position, spawnPoint.rotation);
            // Destruir el objeto que colisionó para simular que fue usado
            Destroy(other.gameObject);
        }
    }
}
