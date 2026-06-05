using UnityEngine;

public class PlacementController : MonoBehaviour
{
    public SmartReticleController reticleController;
    public GameObject contentPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            TryPlace();
        }
    }

    void TryPlace()
    {
        if (!reticleController.reticle.activeSelf)
        {
            Debug.Log("No ground detected — placement blocked.");
            return;
        }

        // place content on reticle position
        Instantiate(contentPrefab, 
                    reticleController.reticle.transform.position,
                    Quaternion.identity);

        Debug.Log("Object placed!");
    }
}
