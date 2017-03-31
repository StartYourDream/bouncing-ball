using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Vector3 relativePosition;

	public GameObject Player;

	// Use this for initialization
	void Start () {
		relativePosition = gameObject.transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = Player.transform.position + relativePosition;
	}
}
