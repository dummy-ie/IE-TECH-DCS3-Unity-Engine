using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float ascendSpeed = 5f;
    public float rotationAmount = 10f;

    public float mouseSensitivity = 100f;

    private float yaw = 0f;

    void Start()
    {
        transform.rotation = Quaternion.Euler(21.1189938f, 228.890015f, 0f);
        yaw = transform.eulerAngles.y;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 forward = transform.forward;
        Vector3 right = transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 movement = (forward * verticalInput + right * horizontalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * ascendSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.down * ascendSpeed * Time.deltaTime, Space.World);
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        yaw += mouseX;
        transform.localRotation = Quaternion.Euler(21.1190147f, yaw, 0f);
    }
}