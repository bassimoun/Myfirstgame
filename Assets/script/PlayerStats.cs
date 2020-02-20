using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public int health ;
	public int lives ;
	public bool IsImune;
	public float ImuneDuration = 1.5f;
	public float ImuneCounter;
	public float FlickerDuration = 0.1f;
	public float FlickerCounter=0;
	public SpriteRenderer sp;
	public Text scoreUI;
	public Slider healthUI;
	public AudioClip GameOverSound;

	public void TakeDmg(int d)
	{
		if (IsImune==false) {

			health -= d;
			if (health < 0)
			{ health = 0; }
			if (health == 0 && lives > 0)
			{
				lives--;
				health = 30;
				FindObjectOfType<LevelManager>().RespawnPlayer();

			}
			else if (this.lives == 0 && this.health == 0)
			{
				(new NavigationController ()).GoToGameOverScene ();
				Debug.Log ("Gameover");
				AudioManger.instance.PlaySingle (GameOverSound);
				AudioManger.instance.musicSource.Stop ();
				Destroy(this.gameObject);
			}
			ImuneCounter = 0;
			IsImune = true;


		}


	}

	public void flicker() {

		if (FlickerCounter < FlickerDuration)
		{
			FlickerCounter += Time.deltaTime;
		}
		else if (FlickerCounter >= FlickerDuration)
		{
			sp.enabled= !sp.enabled;
			FlickerCounter = 0;
		}

	}

	// Use this for initialization
	void Start () {
		sp = this.GetComponent<SpriteRenderer>();

	}

	// Update is called once per frame
	void Update()
	{
		if (IsImune)
		{
			flicker();
			if (ImuneCounter < ImuneDuration)
			{
				ImuneCounter += Time.deltaTime;
			}
			else
			{
				IsImune = false;
				sp.enabled = true;

			}
		}

		scoreUI.text =""+FindObjectOfType<PlayerController>().score;


		healthUI.value = health;


	}
}
