using UnityEngine;

// Player movement controller, put on player object
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
	[SerializeField] float speed = 12f;

	CharacterController controller = null;

	private void Awake()
	{
		controller = GetComponent<CharacterController>();
	}

	private void Update()
	{
		var x = Input.GetAxis("Horizontal");
		var z = Input.GetAxis("Vertical");
		var move = transform.right * x + transform.forward * z;

		controller.Move(speed * Time.deltaTime * move); // move from input
	}
}
