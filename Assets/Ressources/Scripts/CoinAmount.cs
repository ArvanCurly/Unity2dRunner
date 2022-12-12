using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{
   // Use this for initialization
	void Start () {
		gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinAmount") + "";
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("a")){
			Debug.Log("Trésore sauvegardé");
			//SaveCoins();
            PlayerPrefs.SetInt("CoinsAmount", int.Parse(gameObject.GetComponent<Text>().text));

		}
	}

	/*public void SaveCoins(){
		int coinsAlreadySaved = PlayerPrefs.GetInt("CoinsAmount");
		PlayerPrefs.SetInt("CoinsAmount", coinsAlreadySaved + int.Parse(gameObject.GetComponent<Text>().text));
	}*/
}
