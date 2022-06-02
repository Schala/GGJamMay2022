using UnityEngine;

// An interactable dial, rotatable via mouse drag
public class Dial : MonoBehaviour
{
	[SerializeField] float sensitivity = 100.0f;
	[SerializeField] GameObject needle = null;

	Vector3 lastMousePosition = Vector3.zero;
	Ray mouseRay;

	// Update is called once per frame
	void Update()
    {
		if (!Input.GetMouseButtonDown(0)) return; // is the mouse button even pressed?
		mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (!Physics.Raycast(mouseRay, out _)) return; // ... or on the dial, for that matter?

		var delta = Input.mousePosition - lastMousePosition;

		// atan2 will get the rotation angle for us, in radians. Rotate the dial around its parent object by that amount
		needle.transform.RotateAround(transform.position, needle.transform.forward, (Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg));
		
		// update the last mouse position
		lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
}
