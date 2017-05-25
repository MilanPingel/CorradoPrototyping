using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour {

    Rigidbody myRigidbody;

    public float speed;

	Vector3 velocity;

    public int coinCount = 0;

	public event Action OnCollectingFiveCoins;

	void Start ()
    {
		myRigidbody = GetComponent<Rigidbody> ();
	}

	void  Update ()
    {
		Vector3 input = new Vector3 (Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 direction = input.normalized;
		velocity = direction * speed;

		if (coinCount >= 5)
		{
			if (OnCollectingFiveCoins != null)
			{
				OnCollectingFiveCoins ();
			}
			Destroy (gameObject);
		}
    }

    void FixedUpdate ()
    {
        myRigidbody.position += velocity * Time.fixedDeltaTime;

        // Move();
        //	Aim ();
    }

    void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.tag == "Coin")
        {
            Destroy(triggerCollider.gameObject);
            coinCount++;
        }
    }
}


/*
 void Move()
 {
     Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
     Vector3 direction = input.normalized;
     Vector3 velocity = direction * speed;
     Vector3 moveAmount = velocity * Time.deltaTime;
     transform.Translate(moveAmount);
 }


 void Aim() {
     Vector3 mouseScreenPosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y);
     Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
     transform.LookAt (new Vector3(mouseWorldPosition.x, transform.position.y, mouseWorldPosition.z));
 }

    */

