using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterSystem : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    private int state = 0;
    public bool isKilling = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x-6.4f,-3.6f,-1f);
        if(isKilling){
            KillPlayer();
        }
    }
    public void GoFurther()
    {
        state--;
        animator.SetInteger("State",state);
    }
      public void GoCloser()
    {
        state++;
        animator.SetInteger("State",state);
    }
    void KillPlayer(){
        Debug.Log("GameOver");
    }

}
