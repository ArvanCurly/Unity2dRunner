using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    
    public GameObject pauseBtn;
    public GameObject pausePanel;
     public GameObject gameOverPanel;
     public GameObject coinPanelTxt;
     public GameObject gameOvercoinTxt;
    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver(){
        Time.timeScale = 0;
        coinPanelTxt.GetComponent<CoinAmount>().SaveCoins();
        gameOvercoinTxt.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinsAmount") + "";
        gameOverPanel.SetActive(true);
        pauseBtn.SetActive(false);
    }   
     public void PausePlay(){
        if(isPause){
            isPause = false;
            Time.timeScale =1;
             pausePanel.SetActive(false);
            pauseBtn.SetActive(true);
            
        }else {
            isPause = true;
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            pauseBtn.SetActive(false);
        }
        
    }
  public void Restart(){
        Time.timeScale = 1;
          SceneManager.LoadScene("SampleScene");
    }

}
