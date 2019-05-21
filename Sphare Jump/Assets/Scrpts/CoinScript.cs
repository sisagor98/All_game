using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {
	public GameObject coin;
	//public Rigidbody player;
	//public int speed=5;
	void Start()
	{
		//player = GetComponent<Rigidbody> ();

	}

	public void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") {
//			player.transform.Translate (Vector3.right * speed * Time.deltaTime);
			gameObject.SetActive (false);
			PlayerPrefs.SetInt ("collision", 1);
		}
	}
}
