using UnityEngine;
using Vuforia;

public class SmartReticleController : MonoBehaviour
{
    public PlaneFinderBehaviour planeFinder;
    public GameObject reticle;

    void Start()
    {
        reticle.SetActive(false);

        // Listen for tap-based hit test
        planeFinder.OnInteractiveHitTest.AddListener(OnHitTest);
    }

    void OnHitTest(HitTestResult result)
    {
        if (result == null)
        {
            reticle.SetActive(false);
            return;
        }

        // Move reticle to the hit location
        reticle.transform.position = result.Position;
        reticle.transform.rotation = Quaternion.Euler(90, 0, 0);

        // Show reticle
        reticle.SetActive(true);

        Debug.Log("Hit Test success: Rticle Updated");
    }
}
