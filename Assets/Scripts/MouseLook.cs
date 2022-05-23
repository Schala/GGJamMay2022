using UnityEngine;

// Simple mouse-look behavior, put on camera object
public class MouseLook : MonoBehaviour
{
	[SerializeField] float sensitivity = 100f;
	[SerializeField] Transform playerBody = null;
	float xRotation = 0f;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update()
	{
		var mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
		var mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

		xRotation -= mouseY;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		playerBody.Rotate(Vector3.up * mouseX);
	}
}
