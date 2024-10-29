/*using UnityEngine;

public class OrderDeliveryPoint : MonoBehaviour
{
    public Customer assignedCustomer;
    private bool playerInRange = false;

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F) && assignedCustomer != null)
        {
            DeliverOrder();
        }
    }

    private void DeliverOrder()
    {
        // Supongamos que el pedido es obtenido desde el inventario del jugador
        string[] playerOrder = GetPlayerOrder();

        // Pasar el pedido al cliente
        assignedCustomer.ReceiveOrder(playerOrder);
    }

    private string[] GetPlayerOrder()
    {
        // Implementa aquí la lógica para obtener el pedido del jugador.
        // Puede obtenerse desde un sistema de inventario, por ejemplo.
        return new string[] { "Hamburguesa", "con", "pan", "y", "carne" }; // Ejemplo de pedido
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
*/
/*using UnityEngine;

public class OrderDeliveryPoint : MonoBehaviour
{
    public Customer assignedCustomer; // Cliente al que se le entregará el pedido
    private bool playerInRange = false;

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            DeliverOrder();
        }
    }

    private void DeliverOrder()
    {
        // Simula un pedido entregado (por ejemplo, del sistema del jugador)
        string[] deliveredOrder = { "Hamburguesa", "con", "pan", "y", "carne" }; // Esto debe ser personalizado según el pedido real del jugador
        assignedCustomer.ReceiveOrder(deliveredOrder);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
*/