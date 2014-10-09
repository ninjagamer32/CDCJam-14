using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class AudioManager : MonoBehaviour {
	
	public AudioClip MainLoop;
	public AudioSource MainLoopSrc;
	
	public AudioClip EnemyHit;
	public AudioSource EnemyHitSrc;
	
	public AudioClip BossRumble;
	public AudioSource BossRumbleSrc;
	
	public AudioClip LargeExplosion;
	public AudioSource LargeExplosionSrc;
	
	public AudioClip SmallExplosion;
	public AudioSource SmallExplosionSrc;
	
	public AudioClip GameStart;
	public AudioSource GameStartSrc;
	
	public AudioClip ItemPurchase;
	public AudioSource ItemPurchaseSrc;
	
	public AudioClip PewPew;
	public AudioSource PewPewSrc;
	
	public AudioClip PlayerDeath;
	public AudioSource PlayerDeathSrc;
	
	public AudioClip PowerUp;
	public AudioSource PowerUpSrc;
	
	public AudioClip Toggle;
	public AudioSource ToggleSrc;
	
	public AudioClip WeaponChange;
	public AudioSource WeaponChangeSrc;

	public AudioClip MenuLoop;
	public AudioSource MenuLoopSrc;

	public AudioClip BossLoop;
	public AudioSource BossLoopSrc;
	
	void Start () {

		GameObject audioManager = GameObject.Find("AudioManager");
		if(audioManager != null && audioManager != gameObject)
		{
			Destroy(gameObject);
		}

		GameObject.DontDestroyOnLoad (gameObject);
		
		MainLoopSrc = gameObject.AddComponent<AudioSource>();
		MainLoopSrc.clip = MainLoop;
		MainLoopSrc.loop = true;
		
		EnemyHitSrc = gameObject.AddComponent<AudioSource>();
		EnemyHitSrc.clip = EnemyHit;
		EnemyHitSrc.loop = false;

		PewPewSrc = gameObject.AddComponent<AudioSource>();
		PewPewSrc.clip = PewPew;
		PewPewSrc.volume = .4f;
		PewPewSrc.loop = false;

		PlayerDeathSrc = gameObject.AddComponent<AudioSource>();
		PlayerDeathSrc.clip = PlayerDeath;
		PlayerDeathSrc.loop = false;

		GameStartSrc = gameObject.AddComponent<AudioSource>();
		GameStartSrc.clip = GameStart;
		GameStartSrc.loop = false;

		ToggleSrc = gameObject.AddComponent<AudioSource>();
		ToggleSrc.clip=Toggle;
		ToggleSrc.loop = false;

		ItemPurchaseSrc = gameObject.AddComponent<AudioSource>();
		ItemPurchaseSrc.clip=ItemPurchase;
		ItemPurchaseSrc.loop = false;

		BossRumbleSrc = gameObject.AddComponent<AudioSource>();
		BossRumbleSrc.clip=BossRumble;
		BossRumbleSrc.loop = false;

		MenuLoopSrc = gameObject.AddComponent<AudioSource>();
		MenuLoopSrc.clip=MenuLoop;
		MenuLoopSrc.loop = true;

		WeaponChangeSrc = gameObject.AddComponent<AudioSource>();
		WeaponChangeSrc.clip = WeaponChange;
		WeaponChangeSrc.loop = false;

		BossLoopSrc = gameObject.AddComponent<AudioSource>();
		BossLoopSrc.clip=BossLoop;
		BossLoopSrc.loop = true;

		//PlayGameStart();
		PlayMenuLoop();
		//Application.LoadLevel("lvl1");
	}

	public void PlayBossLoop(){
		//HOTween.To(BossLoopSrc, 1,"volume", 1);
		BossLoopSrc.Play();
	}

	public void StopBossLoop(){
		//HOTween.To(BossLoopSrc, 1,"volume", 0);
		BossLoopSrc.Stop();
	}
	
	public void PlayEnemyHit(){
		EnemyHitSrc.Play();
	}

	public void PlayWeaponChange(){
		WeaponChangeSrc.Play();
	}

	public void PlayMenuLoop(){
		//HOTween.To(MenuLoopSrc, 1,"volume", 1);
		MenuLoopSrc.Play();
	}

	public void PlayBossRumble(){
		BossRumbleSrc.Play();
	}

	public void PlayItemPurchase(){
		ItemPurchaseSrc.Play();
	}

	public void PlayToggle(){
		ToggleSrc.Play();
	}

	public void PlayGameStart(){
		GameStartSrc.Play();
	}

	public void PlayPlayerDeath(){
		PlayerDeathSrc.Play();
	}

	public void PlayPewPew(){
		PewPewSrc.Play ();
	}
	
	public void PlayMainLoop(){
		//HOTween.To(MainLoopSrc, 1,"volume", 1);
		MainLoopSrc.Play();
	}

	public void StopMainLoop(){
		//HOTween.To(MainLoopSrc, 1,"volume", 0);
		MainLoopSrc.Pause();
	}

	public void StopMenuLoop(){
		//HOTween.To(MenuLoopSrc, 1,"volume", 0);
		MenuLoopSrc.Stop();
	}
}