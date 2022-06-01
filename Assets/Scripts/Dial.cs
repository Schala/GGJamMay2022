using UnityEngine;

// An interactable dial, rotatable via mouse drag
public class Dial : MonoBehaviour
{
	[SerializeField] float sensitivity = 100.0f;
	[SerializeField] GameObject needle = null;
	public float rotation = 0.0f;

	Vector3 lastMousePosition = Vector3.zero;
	bool isRotating = false;

    // Update is called once per frame
    void Update()
    {
		if (!isRotating) return;

		var delta = Input.mousePosition - lastMousePosition;
		rotation = (-(delta.x + delta.y) * sensitivity) % 360.0f;
		needle.transform.RotateAround(transform.position, needle.transform.right, rotation);
		lastMousePosition = Input.mousePosition;
	}

	private void OnMouseDrag()
	{
		isRotating = true;
		lastMousePosition = Input.mousePosition;
	}

	private void OnMouseUp()
	{
		isRotating = false;
	}
}
