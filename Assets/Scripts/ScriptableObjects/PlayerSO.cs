using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO",menuName = "ScriptableObject/NewPlayerSO")]
public class PlayerSO : ScriptableObject
{
    public string playerName;
    public GameObject playerPrefab;

}

[CreateAssetMenu(fileName = "PlayerSOList", menuName = "ScriptableObjects/NewPlayerSOList")]
public class PlayerSOList : ScriptableObject
{
    public PlayerSO [] players;
}