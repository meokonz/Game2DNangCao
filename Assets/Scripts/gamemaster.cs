﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class gamemaster : MonoBehaviour
{
  public int points = 0;
    public int highscore = 0;
    public TextMeshProUGUI titleState;
    public TextMeshProUGUI pointtext;
        public TextMeshProUGUI pointresult;
    public TextMeshProUGUI Hightext;
    public TextMeshProUGUI Inputtext;
 public Player player;
    // Use this for initialization
    void Start () {
        Hightext.text = ("HighScore: " + PlayerPrefs.GetInt("highscore"));
        highscore = PlayerPrefs.GetInt("highscore", 0);
       player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
        if (PlayerPrefs.HasKey("points"))
        {
            Scene ActiveScreen = SceneManager.GetActiveScene();
            if (ActiveScreen.buildIndex == 1)
            {
                PlayerPrefs.DeleteKey("points");
                points = 0;
            }
            else
               { 
                   points = PlayerPrefs.GetInt("points");}
        }
    }
   
    // Update is called once per frame
    void Update () {
    if(player.ourHealth<=0){
          titleState.text = ("Game Over");
}
        pointtext.text = ("Points: " + points);
        pointresult.text = ("Final score: " + points);
    }
}
