using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	//public GameObject coin;
	private float speed = 5.0f;
	public int force;
	private Rigidbody rBody;
	private float verticalSpeed;
	private Vector3 moveVector;
	private int score = 0;
	public Text scoreText;

	void Start () {
		rBody = GetComponent<Rigidbody> ();
	}
	void Update () {
		scoreText.text = "Score :" + score.ToString ();
		Vector3 tempos = transform.position;
		tempos.x += 0.1f;
		transform.position = tempos;
		transform.Rotate (Vector3.left * 90 * speed * Time.deltaTime);
		if (Input.GetMouseButtonDown(0)) 
		{
			//Debug.Log ("click");
			rBody.AddForce ( 0, force, 0, ForceMode.Impulse);

		}
//		if (PlayerPrefs.GetInt ("collision") == 1) 
//		{
//			PlayerPrefs.SetInt ("collision", 0);
//			//transform.Translate (Vector3.right * speed * Time.deltaTime);
//		}
	}
	public void OnCollisionEnter(Collision other)
	{
		switch (other.gameObject.tag)
		{
		case "coin":
			score++;
			Destroy (other.gameObject);
			break;
		case "wall":
			Debug.Log ("Failed");
			break;
		case "winBox":
			Destroy (other.gameObject);
			SceneManager.LoadScene ("WinMenu");
			break;
		default:
			break;
		}
	}
}
