using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.ARFoundation;

public class ARManager : MonoBehaviour
{
    public Button castButton;
    public ARSession arSession; // Reference to the ARSession component
    public Camera mainCamera; // Reference to the Main Camera
    public Camera arCamera; // Reference to the AR Camera
    public bool clearPrefs;

    void Start()
    {
        if (clearPrefs)
        {
            PlayerPrefs.DeleteAll();
        }

        // Initially disable the AR Session and AR Camera
        if (arSession != null)
        {
            arSession.enabled = false;
        }
        else
        {
            Debug.LogError("AR Session not assigned");
        }

        if (arCamera != null)
        {
            arCamera.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("AR Camera not assigned");
        }

        // Ensure the Main Camera is active initially
        if (mainCamera != null)
        {
            mainCamera.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("Main Camera not assigned");
        }

        // Add a listener to the cast button
        castButton.onClick.AddListener(ActivateARComponents);
        castButton.Select();
    }

    void ActivateARComponents()
    {
        // Enable the AR Session and AR Camera when the button is pressed
        if (arSession != null && arCamera != null)
        {
            arSession.enabled = true;
            arCamera.gameObject.SetActive(true);
            mainCamera.gameObject.SetActive(false); // Disable the Main Camera
        }
    }
}
