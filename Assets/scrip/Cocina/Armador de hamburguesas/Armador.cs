/*using System.Collections.Generic;
using UnityEngine;

public class Armador : MonoBehaviour
{
    public float maxDistance = 2.0f;
    public GameObject hamburgerPrefab;
    private List<string> currentIngredients = new List<string>();
    private bool playerInRange = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ingredient"))
        {
            Ingredient ingredient = other.GetComponent<Ingredient>();
            if (ingredient != null)
            {
                currentIngredients.Add(ingredient.ingredientName);
                Destroy(other.gameObject); // Remove ingredient once added
            }
        }
        else if (other.CompareTag("Player"))
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

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            AssembleHamburger();
        }
    }

    private void AssembleHamburger()
    {
        if (currentIngredients.Count > 0)
        {
            GameObject hamburger = Instantiate(hamburgerPrefab, transform.position + Vector3.up, Quaternion.identity);
            HamburgerInfo info = hamburger.GetComponent<HamburgerInfo>();
            if (info != null)
            {
                info.ingredients = new List<string>(currentIngredients);
            }
            currentIngredients.Clear();
        }
        else
        {
            Debug.Log("No ingredients detected to assemble a hamburger.");
        }
    }
}
*/
/*using System.Collections.Generic;
using UnityEngine;

public class Armador : MonoBehaviour
{
    public float maxDistance = 2.0f;
    public GameObject hamburgerPrefab;
    public Transform spawnPoint;
    private List<string> currentIngredients = new List<string>();
    private bool playerInRange = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ingredient"))
        {
            Ingredient ingredient = other.GetComponent<Ingredient>();
            if (ingredient != null)
            {
                currentIngredients.Add(ingredient.ingredientName);
                Destroy(other.gameObject); // Remove ingredient once added
            }
        }
        else if (other.CompareTag("Player"))
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

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            AssembleHamburger();
        }
    }

    private void AssembleHamburger()
    {
        if (currentIngredients.Count > 0)
        {
            GameObject hamburger = Instantiate(hamburgerPrefab, spawnPoint.position, Quaternion.identity);
            HamburgerInfo info = hamburger.GetComponent<HamburgerInfo>();
            if (info != null)
            {
                info.ingredients = new List<string>(currentIngredients);
            }
            currentIngredients.Clear();
        }
        else
        {
            Debug.Log("No ingredients detected to assemble a hamburger.");
        }
    }
}
*/
using System.Collections.Generic;
using UnityEngine;

public class Armador : MonoBehaviour
{
    public float maxDistance = 2.0f;
    public GameObject hamburgerPrefab;
    public Transform spawnPoint;
    private List<string> currentIngredients = new List<string>();
    private bool playerInRange = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ingredient"))
        {
            Ingredient ingredient = other.GetComponent<Ingredient>();
            if (ingredient != null)
            {
                string ingredientDetail = ingredient.ingredientName;
                if (ingredient.ingredientName == "carne")
                {
                    ingredientDetail += $" ({ingredient.cookingState})";
                }
                currentIngredients.Add(ingredientDetail);
                Destroy(other.gameObject); // Remove ingredient once added
            }
        }
        else if (other.CompareTag("Player"))
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

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            AssembleHamburger();
        }
    }

    private void AssembleHamburger()
    {
        if (currentIngredients.Count > 0)
        {
            GameObject hamburger = Instantiate(hamburgerPrefab, spawnPoint.position, Quaternion.identity);
            HamburgerInfo info = hamburger.GetComponent<HamburgerInfo>();
            if (info != null)
            {
                info.ingredients = new List<string>(currentIngredients);
            }
            currentIngredients.Clear();
        }
        else
        {
            Debug.Log("No ingredients detected to assemble a hamburger.");
        }
    }
}
