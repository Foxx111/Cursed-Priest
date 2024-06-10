using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    Vector3 offset = new Vector3(2.92f, 2.49f, 3.73f); // Offset from the player

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            // Set the position of the camera to be the player's position plus the offset
            transform.position = target.position + offset;

            // Make the camera look at the player
            transform.LookAt(target);
        }
    }
}
