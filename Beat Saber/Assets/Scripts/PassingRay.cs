using UnityEngine;

public class SimpleRay : MonoBehaviour
{
    public float rayDistance = 5f;
    public Color rayColor = Color.red;

    private void Update()
    {
        Vector3 rayOrigin = transform.position;
        Vector3 rayDirection = transform.forward;
        Debug.DrawLine(rayOrigin, rayOrigin + rayDirection * rayDistance, rayColor);
    }
}

