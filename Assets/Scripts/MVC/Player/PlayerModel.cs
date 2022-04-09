using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel

{
    public string playerName { get; set; }
    public GameObject playerPrefab { get; set; }

    public PlayerModel(PlayerSO playerSO)
    {
        playerName = playerSO.playerName;
        playerPrefab = playerSO.playerPrefab;
    }
}
