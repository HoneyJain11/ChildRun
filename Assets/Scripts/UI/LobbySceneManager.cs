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

    public void GamePlayScene()
    {
        SceneManager.LoadScene(1);

    }

    
}
