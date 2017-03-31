using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float moveHorizontal;
	public float moveVertical;
	public float speed = 5;
	public Text ScoreText;
	public Text WinText;
	public GameObject restartButton;

	private Rigidbody rb;
	private int score = 0;

	void Start() {
		rb = GetComponent<Rigidbody>();
		WinText.text = "";
	}

	void FixedUpdate () {
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");

		rb.AddForce(new Vector3(moveHorizontal, 0, moveVertical)*speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Star") {
			other.gameObject.SetActive (false);
			score++;
			ScoreText.text = "Your score: " + score;
			if (score >= 12) {
				WinText.text = "You Win";
				restartButton.SetActive (true);
			}
		}
	}

	public void Restart(){
		UnityEngine.SceneManagement.SceneManager.LoadScene("Scene");
	}
}
