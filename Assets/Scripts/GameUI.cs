using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour {

	Player player;

	// Use this for initialization
	void Start ()
	{
		//GameObject playerObject = GameObject.Find("Player");
		//GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
		//player = player.Object.GetComponent<player>();
		player = FindObjectOfType<Player>();
		player.OnCollectingFiveCoins += GameOver;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		DrawCoinCount (player.coinCount);
	}

	void DrawCoinCount (int playerCoinCount)
	{
		//Implementation
	}

	public void GameOver()
	{
		// Write GAME OVER on screen
	}
}
