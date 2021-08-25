using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToLobyScript : MonoBehaviour
{
   public Button btnBacktoLobby;

    // Update is called once per frame
    void Update()
    {

        btnBacktoLobby.onClick.AddListener(BackToLobby);
    }

    private void BackToLobby()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
