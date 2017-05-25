using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour {

	[System.Serializable]
	public class Controls {
		[SerializeField]
		public string horizontalAxis;
		[SerializeField]
		public string verticalAxis;
		//[SerializeField]
		//public KeyCode aimButton;
	}

	// make sure player has a rigidbody, and attach it to them
	Rigidbody _playerRigidbody;
	Rigidbody playerRigidbody {
		get {
			if (_playerRigidbody == null)
				_playerRigidbody = GetComponent<Rigidbody> ();
			return _playerRigidbody;
		}
	}

	public Controls playerControls;

	public float speed = 5f;
	/*public float speed {
		get {
			if (Input.GetKey(playerControls.aimButton))
				return _speed / 2;
			else
				return _speed;
		}
		set {
			_speed = value;
		}
	}*/
	
	// Update is called once per frame
	void Update () {
		Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		Move (direction);
		// Aim ();
	}

	void Move(Vector2 movement) {
		playerRigidbody.velocity = new Vector3 (speed*movement.x, playerRigidbody.velocity.y, speed*movement.y);
		Debug.Log (movement);
	}

	/*void Aim() {
		Vector3 mouseScreenPosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y);
		Debug.Log (mouseScreenPosition);
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
		transform.LookAt (new Vector3(mouseWorldPosition.x, transform.position.y, mouseWorldPosition.z));
	}*/

}
