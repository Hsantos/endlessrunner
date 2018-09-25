using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController> {

    public Player player { get; private set; }

    public void InitiatePlayer()
    {
        player = new Player();
        player.InitiateCharacter(3,100);
    }
    

    public void ReceiveDamage(EnemyAction action)
    {
        player.ReceiveDamage(action.damage);
    }
}
