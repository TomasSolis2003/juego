
/*using UnityEngine;

public class PlanchaDeCocina : MonoBehaviour
{
    public Transform[] cookingPositions; // Posiciones donde se colocarán las hamburguesas
    public float tiempoCoccion = 10f; // Tiempo total para que una hamburguesa se cocine completamente

    void Update()
    {
        // En cada frame, verificamos las hamburguesas en cada posición y las cocinamos
        for (int i = 0; i < cookingPositions.Length; i++)
        {
            if (cookingPositions[i].childCount > 0)
            {
                Hamburguesa hamburguesa = cookingPositions[i].GetChild(0).GetComponent<Hamburguesa>();
                if (hamburguesa != null)
                {
                    hamburguesa.Cocinar(); // Llamar a la función para cocinar la hamburguesa
                }
            }
        }
    }

    // Colocar la hamburguesa en una posición de la plancha
    public void ColocarHamburguesa(GameObject hamburguesa, int index)
    {
        hamburguesa.transform.SetParent(cookingPositions[index]);
        hamburguesa.transform.localPosition = Vector3.zero;
        hamburguesa.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física mientras se cocina
    }
}
*///buen codigo 
using UnityEngine;

public class PlanchaDeCocina : MonoBehaviour
{
    public float tiempoCoccion = 10f; // Tiempo total para que una hamburguesa se cocine completamente

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Hamburguesa") || other.CompareTag("Fry"))
        {
            Hamburguesa hamburguesa = other.GetComponent<Hamburguesa>();
            if (hamburguesa != null)
            {
                hamburguesa.Cocinar(); // Llamar a la función para cocinar la hamburguesa
            }

            /*FryCooking fryCooking = other.GetComponent<FryCooking>();
            if (fryCooking != null)
            {
                fryCooking.Cocinar(); // Llamar a la función para cocinar las papas fritas
            }*/
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hamburguesa") || other.CompareTag("Fry"))
        {
            other.GetComponent<Rigidbody>().isKinematic = true; // Desactivar la física mientras se cocina
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hamburguesa") || other.CompareTag("Fry"))
        {
            other.GetComponent<Rigidbody>().isKinematic = false; // Reactivar la física cuando sale de la plancha
        }
    }
}
