using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public GameObject MainMenu;
	public GameObject Help;
	void Start () {

	}

	void Update () {

	}
	public void help()
	{
		MainMenu.SetActive (false);
		Help.SetActive (true);
	}
	public void play()
	{
		SceneManager.LoadScene ("GameScene");
	}
	public void EXIT()
	{
		Application.Quit ();
	}
}
