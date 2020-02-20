using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour {

	public void GoToIntroScene()
	{
		Application.LoadLevel (0);
	}
	public void GoToGameScene()
	{
		Application.LoadLevel (1);  
	}
	public void GoToGameScene2()
	{
		Application.LoadLevel (2);
	}
	public void GoToGameScene3()
	{
		Application.LoadLevel (3);
	}
	public void GoToGameScene4()
	{
		Application.LoadLevel (4);
	}
	public void GoToGameScene5()
	{
		Application.LoadLevel (5);
	}
	public void GoToGameScene6()
	{
		Application.LoadLevel (6);
	}
	public void GoToGameOverScene()
	{
		Application.LoadLevel (7);

	}
	public void GoToVictoryScene()
	{
		Application.LoadLevel (8);
	}
	public void GoToSetting()
	{
		Application.LoadLevel (9);
	}
	public void GoToStory()
	{
		Application.LoadLevel (10);
	}
	public void Quit()
	{
		Application.Quit ();
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
