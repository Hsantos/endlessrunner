using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController> {

    private Player player;
	public void InitiatePlayer()
    {
        player = new Player();
    }
}
