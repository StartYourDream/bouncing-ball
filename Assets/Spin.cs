using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45)*Time.deltaTime);
		transform.position = new Vector3(transform.position.x,Mathf.Sin(Time.time * 2f)/3.5f	+1,transform.position.z);
	}
}
