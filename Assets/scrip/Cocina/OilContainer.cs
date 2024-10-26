using UnityEngine;

public class OilContainer : MonoBehaviour
{
    // Tag que identificarán los objetos que pueden ser cocinados
    public string fryTag = "Fry";

    // Este método se llama cuando otro collider entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(fryTag))
        {
            FryCooking fryCooking = other.GetComponent<FryCooking>();
            if (fryCooking != null)
            {
                fryCooking.StartCooking();
            }
        }
    }

    // Este método se llama cuando otro collider sale del trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(fryTag))
        {
            FryCooking fryCooking = other.GetComponent<FryCooking>();
            if (fryCooking != null)
            {
                fryCooking.StopCooking();
            }
        }
    }
}
