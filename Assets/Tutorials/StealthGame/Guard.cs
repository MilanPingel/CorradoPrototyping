using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {

	public Transform PathHolder;

	public float speed = 5f;
	public float waitTime = .3f;

	// Use this for initialization
	void Start () {

		Vector3[] waypoints = new Vector3[PathHolder.childCount];
		for (int i = 0; i < waypoints.Length; i++) {
			waypoints[i] = PathHolder.GetChild(i).position;
			}

	}

	void OnDrawGizmos() {
		Vector3 startPosition = PathHolder.GetChild (0).position;
		Vector3 previousPosition = startPosition;

		foreach (Transform waypoint in PathHolder) {
			Gizmos.DrawSphere (waypoint.position, .3f);
			Gizmos.DrawLine (previousPosition, waypoint.position);
			previousPosition = waypoint.position;
			}
		Gizmos.DrawLine (previousPosition, startPosition);

	}

	// Update is called once per frame
	/*void Update () {
		IEnumerator Move (Vector3 destination, float speed)  {
			while (transform.position != destination) {
				transform.position = Vector3.MoveTowards (transform.position, destination, speed * Time.deltaTime);
				yield return null;
			}
		}
	}*/
}
