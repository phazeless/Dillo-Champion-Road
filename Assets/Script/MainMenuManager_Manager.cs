using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Enumerator;
using UnityEngine.SceneManagement;
public class MainMenuManager_Manager : MonoBehaviour{
    //=====================================================================
    //				      VARIABLES 
    //=====================================================================
    //===== SINGLETON =====
    public static MainMenuManager_Manager m_Instance;
    //===== STRUCT =====

    //===== PUBLIC =====
    public GameObject m_HowToPlay;
    public GameObject m_MainMenuObject;
    public GameObject m_Upgrade;
    //===== PRIVATES =====

    //=====================================================================
    //				MONOBEHAVIOUR METHOD 
    //=====================================================================
    void Awake(){
        m_Instance = this;
    }

    void Start(){
        f_Initialize();
    }

    void Update(){
        
    }
    //=====================================================================
    //				    OTHER METHOD
    //=====================================================================
    public void f_Initialize() {
        GameManager_Manager.m_Instance.m_GameState = GAME_STATE.MENU;
        m_MainMenuObject.SetActive(true);
    }

    public void f_StartGame() {
        GameManager_Manager.m_Instance.f_Initialize();

        m_HowToPlay.SetActive(false);
        m_Upgrade.SetActive(true);
        m_MainMenuObject.SetActive(false);
    }

    public void f_ShowHTP() {
        
        m_MainMenuObject.SetActive(true);
        m_HowToPlay.SetActive(true);
    }
}
