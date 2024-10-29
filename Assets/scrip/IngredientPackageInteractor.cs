using UnityEngine;

public class IngredientPackageInteractor : MonoBehaviour
{
    public float interactionDistance = 2.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactionDistance))
            {
                IngredientPackage package = hit.collider.GetComponent<IngredientPackage>();
                if (package != null)
                {
                    package.ReleaseIngredients();
                }
            }
        }
    }
}
