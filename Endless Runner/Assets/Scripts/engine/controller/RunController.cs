using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunController : Singleton<RunController> {

    public RunSession session { get; private set; }
	
    public void StartSession()
    {
        session = new RunSession();
        PlayerController.ME.InitiatePlayer();

        LogGame();

        EnemyAttack(session.wave.creatures[2]);

        LogGame();

        EnemyAttack(session.wave.creatures[2]);

        LogGame();

        EnemyAttack(session.wave.creatures[2]);

        LogGame();

        EnemyAttack(session.wave.creatures[2]);

        LogGame();

    }

    public void LogGame()
    {
        string str = "GAME STATUS: " +  '\n';

        str += "---------------------------" + '\n';

        str += "PLAYER: " +  PlayerController.ME.player +  '\n';
        str += "WAVE: " + session.wave.current +  '\n';
        str += "MAX WAVE : " + session.wave.max +  '\n';
        for (int i = 0; i < session.wave.creatures.Count; i++)
        {
            str += "ENEMY: " + (session.wave.creatures[i] != null ? session.wave.creatures[i].ToString() : "DESTROYED" ) + '\n';

        }

        Debug.Log(str);
    }


    public void EnemyAttack(Enemy current)
    {
        PlayerController.ME.ReceiveAttack(current.FactoryMethod());
    }

}
