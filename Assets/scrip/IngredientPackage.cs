using UnityEngine;

public class IngredientPackage : MonoBehaviour
{
    public GameObject[] ingredientPrefabs;
    public Transform spawnPoint;

    public void ReleaseIngredients()
    {
        foreach (GameObject prefab in ingredientPrefabs)
        {
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
