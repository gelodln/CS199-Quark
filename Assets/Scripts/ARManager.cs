using UnityEngine;
using Vuforia;
using TMPro;
using System.Collections.Generic;

public class ARManager : MonoBehaviour
{
    [Header("References")]
    public Transform groundPlaneStage;  // Your Ground Stage
    public GameObject objectContainer;
    public TMP_Text debugText;
    public ContentPositioningBehaviour contentPositioningBehaviour;

    private PlaneFinderBehaviour planeFinder;
    private HitTestResult lastAutomaticHit;

    private bool isAnchored = false;

    // Logs
    private Queue<string> logQueue = new Queue<string>();
    private const int maxLogs = 8;
    private float lastAutoLogTime = 0f;
    private const float autoLogInterval = 1f; // seconds


    void Start()
    {
        planeFinder = FindObjectOfType<PlaneFinderBehaviour>();

        Log("AR Manager Ready.");

        // Hide ground plane at start
        if (groundPlaneStage != null)
            groundPlaneStage.gameObject.SetActive(false);

        // Hide object container at start
        if (objectContainer != null)
            objectContainer.gameObject.SetActive(false);
    }

    // ----------------- AUTOMATIC HIT -----------------
    public void OnAutomaticHitTest(HitTestResult result)
    {
        lastAutomaticHit = result;
        if (Time.time - lastAutoLogTime >= autoLogInterval)
        {
            if (isAnchored)
                return;
            Log("AUTO HIT");
            lastAutoLogTime = Time.time;
        }
    }

    // ----------------- INTERACTIVE HIT (PLACEMENT PATH) -----------------
    public void HandlePlaneFinderHit(HitTestResult hitTestResult)
    {
        if (isAnchored)
            return;

        Log("INTERACTIVE HIT → POSITIONING CONTENT");

        if (contentPositioningBehaviour != null)
        {
            contentPositioningBehaviour.PositionContentAtPlaneAnchor(hitTestResult);
            isAnchored = true;
        }
        else
        {
            Log("❌ ContentPositioningBehaviour missing");
        }
    }

    // ----------------- ANCHOR BUTTON -----------------
    /*
    public void PressPlaceObject()
    {
        
    }
    */

    public void PressPlace()
    {
        Debug.Log("PLACE BUTTON PRESSED");

        if (planeFinder == null)
        {
            Debug.LogError("PlaneFinder not assigned");
            return;
        }

        planeFinder.PerformHitTest(
            new Vector2(Screen.width / 2f, Screen.height / 2f)
        );
    }

    public void OnContentPlaced(GameObject placedStage)
    {
        Log("CONTENT PLACED");
        placedStage.SetActive(true);
    }

    // ----------------- FIFO LOGGER -----------------
    public void Log(string msg)
    {
        Debug.Log(msg);

        logQueue.Enqueue(msg);
        if (logQueue.Count > maxLogs)
            logQueue.Dequeue();

        if (debugText != null)
            debugText.text = string.Join("\n", logQueue.ToArray());
    }
}
