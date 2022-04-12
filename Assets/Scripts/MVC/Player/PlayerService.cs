using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : GenericSingleton<PlayerService>
{

    public PlayerController playerController;
    public PlayerModel playerModel;
    [SerializeField]
    PlayerView playerView;
    [SerializeField]
    PlayerSOList playerSOList;

    private void Start()
    {
        playerController = CreatePlayer();
        playerController.SubscribeEvent();
        playerView.ChangeState(playerView.activeState);
    }

    public PlayerController CreatePlayer()
    {
        PlayerSO playerSO = playerSOList.players[0];
        playerModel = new PlayerModel(playerSO);
        PlayerController player = new PlayerController(playerModel, playerView);
        player.playerView.SetPlayerControllerReference(player);
        return player;
    }
}