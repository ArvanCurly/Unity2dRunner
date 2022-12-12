using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBehaviour : MonoBehaviour
{
 public int value = 1;
	private GameObject UI;
	public Animator animator;

	// Use this for initialization
	void Start () {
		UI = GameObject.FindGameObjectWithTag("CoinAmount");
	}
	
	// Update is called once per frame
	void Update () {	
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Player")){
			int addcoin = int.Parse(UI.GetComponent<Text>().text) + 1;
			UI.GetComponent<Text>().text = addcoin + "";
			animator.SetBool("isCollect", true);
			
	    }
	}


}
