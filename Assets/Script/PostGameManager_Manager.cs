using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Enumerator;
public class PostGameManager_Manager : MonoBehaviour{
    //=====================================================================
    //				      VARIABLES 
    //=====================================================================
    //===== SINGLETON =====
    public static PostGameManager_Manager m_Instance;
    //===== STRUCT =====

    //===== PUBLIC =====
    public GameObject m_EndGameUI;
    public TextMeshProUGUI m_TotalScore;
    public TextMeshProUGUI m_BerryScore;
    public GameObject m_Highscore;
    //===== PRIVATES =====

    //=====================================================================
    //				MONOBEHAVIOUR METHOD 
    //=====================================================================
    void Awake(){
        m_Instance = this;
    }

    void Start(){
        
    }

    void Update(){
        
    }
    //=====================================================================
    //				    OTHER METHOD
    //=====================================================================
    public void f_EndGame() {
        GameManager_Manager.m_Instance.m_GameState = GAME_STATE.ENDGAME;
        GameManager_Manager.m_Instance.m_ListActiveEnemies.Clear();

        m_Highscore.SetActive(GameManager_Manager.m_Instance.m_Score > Player_Manager.m_Instance.m_HighScore);

        m_TotalScore.text = GameManager_Manager.m_Instance.m_Score.ToString("00") + "pt";
        m_BerryScore.text = "+"+Mathf.RoundToInt((GameManager_Manager.m_Instance.m_Score/100)).ToString();
        m_EndGameUI.SetActive(true);
    }

    public void f_Retry() {
        
    }
    public void f_MainMenu() {

    }
}
