using UnityEngine;
using System.Collections;


public class MakeGunChild : MonoBehaviour {

	public Transform gunTransform;

	// Use this for initialization
	void Start () {
		gunTransform.parent = transform;
		gunTransform.localScale = Vector3.one * 2;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * 180 * Time.deltaTime, Space.World);
		transform.Translate (Vector3.forward * Time.deltaTime * 7);
	}
}
