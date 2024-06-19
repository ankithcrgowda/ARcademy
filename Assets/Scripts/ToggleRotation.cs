using UnityEngine;

public class ToggleRotation : MonoBehaviour
{
    public GameObject objectToRotate;
    public float rotationSpeed = 50f;

    private bool isRotating = false;

    void Update()
    {
        if (isRotating && objectToRotate != null)
        {
            // Rotate the object
            objectToRotate.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    public void ToggleRotationState()
    {
        // Toggle rotation state
        isRotating = !isRotating;
    }
}
