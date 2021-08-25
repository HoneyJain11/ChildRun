using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbySceneManager : MonoBehaviour
{
    [SerializeField]
    Button BtnABC, Btn123, BtnQuit;


   // UnityAction action = null;
  


    public void GamePlayScene()
    {

        Debug.Log("in GamePlay");
        SceneManager.LoadScene("GamePlayScene");

        
    }

    
}
