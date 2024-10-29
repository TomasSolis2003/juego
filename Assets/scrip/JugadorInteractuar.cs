
/*using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    public PlanchaDeCocina planchaDeCocina;

    public float distanciaParaCocinar = 2f; // Distancia mínima para colocar la hamburguesa en la plancha

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }

        // Colocar la hamburguesa en la plancha con la tecla "F"
        if (Input.GetKeyDown(KeyCode.F) && objetoEnMano != null && objetoEnMano.CompareTag("Hamburguesa"))
        {
            float distancia = Vector3.Distance(transform.position, planchaDeCocina.transform.position);
            if (distancia <= distanciaParaCocinar)
            {
                ColocarHamburguesaEnPlancha();
            }
            else
            {
                Debug.Log("Estás muy lejos de la plancha para colocar la hamburguesa.");
            }
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa"))
                {
                    TomarObjeto(objeto);
                }
                if (objeto.CompareTag("Fry"))
                {
                    TomarObjeto(objeto);
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
        objetoEnMano = null;
    }

    // Colocar la hamburguesa en la plancha
    void ColocarHamburguesaEnPlancha()
    {
        for (int i = 0; i < planchaDeCocina.cookingPositions.Length; i++)
        {
            if (planchaDeCocina.cookingPositions[i].childCount == 0)
            {
                planchaDeCocina.ColocarHamburguesa(objetoEnMano, i);
                objetoEnMano = null;
                break;
            }
        }
    }
}
*///salva vidas
using UnityEngine;

public class JugadorInteractuar : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia máxima para interactuar
    public float radioDeteccion = 0.5f; // Radio de la esfera para detectar objetos en el suelo
    public Transform manoJugador; // Posición en la que el objeto se sostendrá en la mano
    private GameObject objetoEnMano = null; // Objeto que el jugador está sosteniendo

    public LayerMask capaInteractuable; // Capa para los objetos interactuables

    void Update()
    {
        // Tomar y soltar objetos con la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoEnMano == null)
            {
                IntentarTomarObjeto();
            }
            else
            {
                SoltarObjeto();
            }
        }
    }

    // Intentar tomar un objeto
    void IntentarTomarObjeto()
    {
        RaycastHit hit;
        Vector3 origen = transform.position + Vector3.up; // Aumentamos el origen para evitar que el rayo se quede muy bajo

        // Utilizamos SphereCast para detectar objetos en un área
        if (Physics.SphereCast(origen, radioDeteccion, transform.forward, out hit, distanciaInteraccion, capaInteractuable))
        {
            if (hit.collider != null)
            {
                GameObject objeto = hit.collider.gameObject;

                if (objeto.CompareTag("Hamburguesa") || objeto.CompareTag("Fry") || objeto.CompareTag("Ingredient") || objeto.CompareTag("Money") || objeto.CompareTag("Order") || objeto.CompareTag("pedido") || objeto.CompareTag("TopBun"))
                {
                    TomarObjeto(objeto);//TopBun
                }
            }
        }
    }

    // Tomar el objeto
    void TomarObjeto(GameObject objeto)
    {
        objetoEnMano = objeto;
        objetoEnMano.transform.SetParent(manoJugador); // Hacer que el objeto siga la mano del jugador
        objetoEnMano.transform.localPosition = Vector3.zero; // Colocarlo en la mano
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física del objeto mientras lo sostenemos
    }

    // Soltar el objeto
    void SoltarObjeto()
    {
        objetoEnMano.transform.SetParent(null); // Dejar de seguir la mano del jugador
        objetoEnMano.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física
        objetoEnMano = null;
    }
}

