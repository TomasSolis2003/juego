
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Customer : MonoBehaviour
{
    public Transform ubic_mostrador;
    public Transform ubic_salida;
    public TextMeshPro orderText;
    public TextMeshPro feedbackText;
    public Transform moneySpot; // Lugar donde el cliente dejará el dinero
    public GameObject receivePoint; // Punto donde el cliente recibirá el pedido

    public float walkSpeed = 2f;
    public float interactionRange = 3f; // Rango de interacción con el jugador
    private float waitTimeAtCounter = 30f;
    private float orderTime = 210f;
    private bool playerInRange = false;
    private bool isOrderActivated = false;
    private bool atCounter = false;
    private bool timerStarted = false;

    private Renderer customerRenderer;
    public Material greenMaterial;
    public Material yellowMaterial;
    public Material redMaterial;
    public Material blackMaterial;

    private string[] currentOrder;
    private float paymentAmount = 20000f;
    private float minPayment = 6000f;

    private Transform playerTransform;

    private void Start()
    {
        customerRenderer = GetComponent<Renderer>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        MoveToCounter();
        orderText.gameObject.SetActive(false);
        feedbackText.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (!atCounter)
        {
            MoveTowards(ubic_mostrador);
        }

        if (atCounter && !isOrderActivated)
        {
            waitTimeAtCounter -= Time.deltaTime;
            if (waitTimeAtCounter <= 0)
            {
                LeaveWithoutBeingServed();
            }
        }

        if (isOrderActivated && timerStarted)
        {
            UpdateOrderTimer();
        }

        CheckPlayerInRange();

        if (playerInRange && Input.GetKeyDown(KeyCode.F) && atCounter && !isOrderActivated)
        {
            ActivateOrder();
        }
    }

    private void MoveToCounter()
    {
        atCounter = false;
    }

    private void MoveTowards(Transform target)
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * walkSpeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            if (target == ubic_mostrador)
            {
                atCounter = true;
            }
            else if (target == ubic_salida)
            {
                Destroy(gameObject);
            }
        }
    }

    private void ActivateOrder()
    {
        isOrderActivated = true;
        timerStarted = true;
        orderText.gameObject.SetActive(true);
        orderText.text = GenerateRandomOrder();
        currentOrder = orderText.text.Split(' ');
    }

    private void UpdateOrderTimer()
    {
        orderTime -= Time.deltaTime;

        if (orderTime > 140f)
        {
            customerRenderer.material = greenMaterial;
        }
        else if (orderTime > 70f)
        {
            customerRenderer.material = yellowMaterial;
        }
        else if (orderTime > 0f)
        {
            customerRenderer.material = redMaterial;
        }
        else
        {
            customerRenderer.material = blackMaterial;
            LeaveWithoutBeingServed();
        }
    }

    private void LeaveWithoutBeingServed()
    {
        feedbackText.gameObject.SetActive(true);
        feedbackText.text = "La próxima vez más rápido!";
        feedbackText.color = Color.red;
        MoveTowards(ubic_salida);
    }

    public void ReceiveOrder(string[] deliveredOrder)
    {
        if (!isOrderActivated) return;

        timerStarted = false;
        orderText.gameObject.SetActive(false);

        bool correctOrder = CheckOrder(deliveredOrder);

        if (correctOrder)
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = "¡Muchas gracias!";
            feedbackText.color = Color.green;

            // Calcular pago basado en el tiempo restante
            float timeFactor = Mathf.Clamp(orderTime / 210f, 0.3f, 1f);
            paymentAmount = Mathf.Lerp(minPayment, paymentAmount, timeFactor);

            DropMoney();
        }
        else
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = "¡Esto no es lo que ordené!";
            feedbackText.color = Color.red;
        }

        Invoke("LeaveAfterFeedback", 2f); // Espera para que lea el feedback y se vaya
    }

    private bool CheckOrder(string[] deliveredOrder)
    {
        if (deliveredOrder.Length != currentOrder.Length) return false;

        for (int i = 0; i < currentOrder.Length; i++)
        {
            if (currentOrder[i] != deliveredOrder[i]) return false;
        }
        return true;
    }

    private void DropMoney()
    {
        GameObject money = new GameObject("Money");
        money.transform.position = moneySpot.position;
        money.AddComponent<Money>().SetAmount(paymentAmount);
    }

    private void LeaveAfterFeedback()
    {
        feedbackText.gameObject.SetActive(false);
        MoveTowards(ubic_salida);
    }

    private string GenerateRandomOrder()
    {
        string[] orders = {
            "Hamburguesa con pan y carne",
            "Solo carne",
            "Hamburguesa completa con papas",
            "Solo pan",
            "Hamburguesa sin carne",
            "Papas fritas",
            "Coca cola",
            "Hamburguesa sin lechuga",
            "Solo pan y tomate",
            "Hamburguesa sin bebida"
        };
        return orders[Random.Range(0, orders.Length)];
    }

    private void CheckPlayerInRange()
    {
        if (Vector3.Distance(transform.position, playerTransform.position) <= interactionRange)
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Detecta colisión con el pedido y valida el pedido
        if (other.CompareTag("pedido") && other.transform == receivePoint.transform)
        {
            Order order = other.GetComponent<Order>();
            if (order != null)
            {
                ReceiveOrder(order.GetIngredients());
                Destroy(other.gameObject); // Destruye el pedido después de entregarlo
            }
        }
    }
}
*///buen codigo
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Customer : MonoBehaviour
{
    public Transform ubic_mostrador;
    public Transform ubic_salida;
    public TextMeshPro orderText;
    public TextMeshPro feedbackText;
    public Transform moneySpot; // Lugar donde el cliente dejará el dinero
    public GameObject receivePoint; // Punto donde el cliente recibirá el pedido

    public float walkSpeed = 2f;
    public float interactionRange = 3f; // Rango de interacción con el jugador
    private float waitTimeAtCounter = 30f;
    private float orderTime = 210f;
    private bool playerInRange = false;
    private bool isOrderActivated = false;
    private bool atCounter = false;
    private bool timerStarted = false;

    private Renderer customerRenderer;
    public Material greenMaterial;
    public Material yellowMaterial;
    public Material redMaterial;
    public Material blackMaterial;

    private string[] currentOrder;
    private float paymentAmount = 20000f;
    private float minPayment = 6000f;

    private Transform playerTransform;

    private void Start()
    {
        customerRenderer = GetComponent<Renderer>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        MoveToCounter();
        orderText.gameObject.SetActive(false);
        feedbackText.gameObject.SetActive(false);

        // Asignar tag "ReceivePoint" al punto de recepción si no está ya asignado
        if (receivePoint != null && !receivePoint.CompareTag("ReceivePoint"))
        {
            receivePoint.tag = "ReceivePoint";
        }
    }

    private void Update()
    {
        if (!atCounter)
        {
            MoveTowards(ubic_mostrador);
        }

        if (atCounter && !isOrderActivated)
        {
            waitTimeAtCounter -= Time.deltaTime;
            if (waitTimeAtCounter <= 0)
            {
                LeaveWithoutBeingServed();
            }
        }

        if (isOrderActivated && timerStarted)
        {
            UpdateOrderTimer();
        }

        CheckPlayerInRange();

        if (playerInRange && Input.GetKeyDown(KeyCode.F) && atCounter && !isOrderActivated)
        {
            ActivateOrder();
        }
    }

    private void MoveToCounter()
    {
        atCounter = false;
    }

    private void MoveTowards(Transform target)
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * walkSpeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            if (target == ubic_mostrador)
            {
                atCounter = true;
            }
            else if (target == ubic_salida)
            {
                Destroy(gameObject);
            }
        }
    }

    private void ActivateOrder()
    {
        isOrderActivated = true;
        timerStarted = true;
        orderText.gameObject.SetActive(true);
        orderText.text = GenerateRandomOrder();
        currentOrder = orderText.text.Split(' ');
    }

    private void UpdateOrderTimer()
    {
        orderTime -= Time.deltaTime;

        if (orderTime > 140f)
        {
            customerRenderer.material = greenMaterial;
        }
        else if (orderTime > 70f)
        {
            customerRenderer.material = yellowMaterial;
        }
        else if (orderTime > 0f)
        {
            customerRenderer.material = redMaterial;
        }
        else
        {
            customerRenderer.material = blackMaterial;
            LeaveWithoutBeingServed();
        }
    }

    private void LeaveWithoutBeingServed()
    {
        feedbackText.gameObject.SetActive(true);
        feedbackText.text = "La próxima vez más rápido!";
        feedbackText.color = Color.red;
        MoveTowards(ubic_salida);
    }

    public void ReceiveOrder(string[] deliveredOrder)
    {
        if (!isOrderActivated) return;

        timerStarted = false;
        orderText.gameObject.SetActive(false);

        bool correctOrder = CheckOrder(deliveredOrder);

        if (correctOrder)
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = "¡Muchas gracias!";
            feedbackText.color = Color.green;

            // Calcular pago basado en el tiempo restante
            float timeFactor = Mathf.Clamp(orderTime / 210f, 0.3f, 1f);
            paymentAmount = Mathf.Lerp(minPayment, paymentAmount, timeFactor);

            DropMoney();
        }
        else
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = "¡Esto no es lo que ordené!";
            feedbackText.color = Color.red;
        }

        Invoke("LeaveAfterFeedback", 2f); // Espera para que lea el feedback y se vaya
    }

    private bool CheckOrder(string[] deliveredOrder)
    {
        if (deliveredOrder.Length != currentOrder.Length) return false;

        for (int i = 0; i < currentOrder.Length; i++)
        {
            if (currentOrder[i] != deliveredOrder[i]) return false;
        }
        return true;
    }

    private void DropMoney()
    {
        GameObject money = new GameObject("Money");
        money.transform.position = moneySpot.position;
        money.AddComponent<Money>().SetAmount(paymentAmount);
    }

    private void LeaveAfterFeedback()
    {
        feedbackText.gameObject.SetActive(false);
        MoveTowards(ubic_salida);
    }

    private string GenerateRandomOrder()
    {
        string[] orders = {
            "Hamburguesa con pan y carne",
            "Solo carne",
            "Hamburguesa completa con papas",
            "Solo pan",
            "Hamburguesa sin carne",
            "Papas fritas",
            "Coca cola",
            "Hamburguesa sin lechuga",
            "Solo pan y tomate",
            "Hamburguesa sin bebida"
        };
        return orders[Random.Range(0, orders.Length)];
    }

    private void CheckPlayerInRange()
    {
        if (Vector3.Distance(transform.position, playerTransform.position) <= interactionRange)
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisión detectada con: " + other.name); // Mensaje para depurar colisiones

        // Verifica que el otro objeto tenga el tag "pedido" y que la colisión ocurra en el receivePoint con el tag "ReceivePoint"
        if (other.CompareTag("pedido") && receivePoint.CompareTag("ReceivePoint"))
        {
            Debug.Log("Pedido detectado correctamente en el punto de recepción.");

            Order order = other.GetComponent<Order>();
            if (order != null)
            {
                ReceiveOrder(order.GetIngredients());
                Destroy(other.gameObject); // Destruye el pedido después de entregarlo
            }
        }
        else
        {
            Debug.Log("El objeto no es un pedido o el punto de recepción no tiene el tag adecuado.");
        }
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Customer : MonoBehaviour
{
    public Transform ubic_mostrador;
    public Transform ubic_salida;
    public TextMeshPro orderText;
    public TextMeshPro feedbackText;
    public Transform moneySpot; // Lugar donde el cliente dejará el dinero
    public GameObject receivePoint; // Punto donde el cliente recibirá el pedido

    public float walkSpeed = 2f;
    public float interactionRange = 3f; // Rango de interacción con el jugador
    private float waitTimeAtCounter = 30f;
    private float orderTime = 210f;
    private bool playerInRange = false;
    private bool isOrderActivated = false;
    private bool atCounter = false;
    private bool timerStarted = false;

    private Renderer customerRenderer;
    public Material greenMaterial;
    public Material yellowMaterial;
    public Material redMaterial;
    public Material blackMaterial;

    private string[] currentOrder;
    private float paymentAmount = 20000f;
 //   private float minPayment = 6000f;

    private Transform playerTransform;

    private void Start()
    {
        customerRenderer = GetComponent<Renderer>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        MoveToCounter();
        orderText.gameObject.SetActive(false);
        feedbackText.gameObject.SetActive(false);

        // Asignar tag "ReceivePoint" al punto de recepción si no está ya asignado
        if (receivePoint != null && !receivePoint.CompareTag("ReceivePoint"))
        {
            receivePoint.tag = "ReceivePoint";
        }
    }

    private void Update()
    {
        if (!atCounter)
        {
            MoveTowards(ubic_mostrador);
        }

        if (atCounter && !isOrderActivated)
        {
            waitTimeAtCounter -= Time.deltaTime;
            if (waitTimeAtCounter <= 0)
            {
                LeaveWithoutBeingServed();
            }
        }

        if (isOrderActivated && timerStarted)
        {
            UpdateOrderTimer();
        }

        CheckPlayerInRange();

        if (playerInRange && Input.GetKeyDown(KeyCode.F) && atCounter && !isOrderActivated)
        {
            ActivateOrder();
        }
    }

    private void MoveToCounter()
    {
        atCounter = false;
    }

    private void MoveTowards(Transform target)
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * walkSpeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            if (target == ubic_mostrador)
            {
                atCounter = true;
            }
            else if (target == ubic_salida)
            {
                Destroy(gameObject);
            }
        }
    }

    private void ActivateOrder()
    {
        isOrderActivated = true;
        timerStarted = true;
        orderText.gameObject.SetActive(true);
        orderText.text = GenerateRandomOrder();
        currentOrder = orderText.text.Split(' '); // Inicializar el pedido actual
    }

    private void UpdateOrderTimer()
    {
        orderTime -= Time.deltaTime;

        if (orderTime > 140f)
        {
            customerRenderer.material = greenMaterial;
        }
        else if (orderTime > 70f)
        {
            customerRenderer.material = yellowMaterial;
        }
        else if (orderTime > 0f)
        {
            customerRenderer.material = redMaterial;
        }
        else
        {
            customerRenderer.material = blackMaterial;
            LeaveWithoutBeingServed();
        }
    }

    private void LeaveWithoutBeingServed()
    {
        feedbackText.gameObject.SetActive(true);
        feedbackText.text = "La próxima vez más rápido!";
        feedbackText.color = Color.red;
        MoveTowards(ubic_salida);
    }

    /*public void ReceiveOrder(string[] deliveredOrder)
    {
        if (!isOrderActivated || currentOrder == null) return; // Asegura que el pedido esté activado y no sea nulo

        timerStarted = false;
        orderText.gameObject.SetActive(false);

        bool correctOrder = CheckOrder(deliveredOrder);

        if (correctOrder)
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = "¡Muchas gracias!";
            feedbackText.color = Color.green;

            // Calcular pago basado en el tiempo restante
            float timeFactor = Mathf.Clamp(orderTime / 210f, 0.3f, 1f);
            paymentAmount = Mathf.Lerp(minPayment, paymentAmount, timeFactor);

            DropMoney();
        }
        else
        {
            feedbackText.gameObject.SetActive(true);
            feedbackText.text = "¡Esto no es lo que ordené!";
            feedbackText.color = Color.red;
        }

        Invoke("LeaveAfterFeedback", 2f); // Espera para que lea el feedback y se vaya
    }

    private bool CheckOrder(string[] deliveredOrder)
    {
        if (currentOrder == null || deliveredOrder.Length != currentOrder.Length) return false;

        for (int i = 0; i < currentOrder.Length; i++)
        {
            if (currentOrder[i] != deliveredOrder[i]) return false;
        }
        return true;
    }
    */
    private void DropMoney()
    {
        GameObject money = new GameObject("Money");
        money.transform.position = moneySpot.position;
        money.AddComponent<Money>().SetAmount(paymentAmount);
    }

    private void LeaveAfterFeedback()
    {
        feedbackText.gameObject.SetActive(false);
        MoveTowards(ubic_salida);
    }

    private string GenerateRandomOrder()
    {
        string[] orders = {
            "Hamburguesa con pan y carne",
            "Solo carne",
            "Hamburguesa completa con papas",
            "Solo pan",
            "Hamburguesa sin carne",
            "Papas fritas",
            "Coca cola",
            "Hamburguesa sin lechuga",
            "Solo pan y tomate",
            "Hamburguesa sin bebida"
        };
        return orders[Random.Range(0, orders.Length)];
    }

    private void CheckPlayerInRange()
    {
        if (Vector3.Distance(transform.position, playerTransform.position) <= interactionRange)
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisión detectada con: " + other.name); // Mensaje para depurar colisiones

        // Verifica que el otro objeto tenga el tag "pedido" y que la colisión ocurra en el receivePoint con el tag "ReceivePoint"
        if (other.CompareTag("pedido") && receivePoint.CompareTag("ReceivePoint"))
        {
            Debug.Log("Pedido detectado correctamente en el punto de recepción.");

            Order order = other.GetComponent<Order>();
            if (order != null)
            {
               // ReceiveOrder(order.GetIngredients());
                Destroy(other.gameObject); // Destruye el pedido después de entregarlo
            }
        }
        else
        {
            Debug.Log("El objeto no es un pedido o el punto de recepción no tiene el tag adecuado.");
        }
    }
}
