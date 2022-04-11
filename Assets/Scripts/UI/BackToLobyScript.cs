using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToLobyScript : MonoBehaviour
{
   public Button btnBacktoLobby;

    void Update()
    {

        btnBacktoLobby.onClick.AddListener(BackToLobby);
    }

    private void BackToLobby()
    {
        SceneManager.LoadScene(0);
    }
}
