using UnityEngine;

public class FarmerInput : MonoBehaviour
{

    public Farmer farmer;
    public Transform cameraTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            movement += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += new Vector3(0, 0, -1);
        }

        Vector3 cameraMoveForward = cameraTransform.forward * movement.z;
        Vector3 cameraMoveRight = cameraTransform.right * movement.x;
        Vector3 cameraAdjustedMovement = cameraMoveForward + cameraMoveRight;

        farmer.Move(cameraAdjustedMovement);
    }
}
