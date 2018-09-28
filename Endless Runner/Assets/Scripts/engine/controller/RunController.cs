using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunController : Singleton<RunController> {

    public RunSession session { get; private set; }
	
    public void StartSession()
    {
        if(session!=null) throw  new Exception();
        session = new RunSession();
        PlayerController.ME.InitiatePlayer();
       
        //Player Damage
        //        LogGame();
        //        EnemyAction(session.wave.creatures[2]);
        //        LogGame();
        //        EnemyAction(session.wave.creatures[2]);
        //        LogGame();
        //        EnemyAction(session.wave.creatures[2]);
        //        LogGame();
        //        EnemyAction(session.wave.creatures[2]);
        //        LogGame();

        //Destroy Enemies
        //        LogGame();
        //        PlayerAction(session.wave.creatures[1]);
        //        LogGame();
        //        PlayerAction(session.wave.creatures[1]);
        //        LogGame();
        //        PlayerAction(session.wave.creatures[0]);
        //        LogGame();
        //        PlayerAction(session.wave.creatures[0]);
        //        LogGame();
        //        PlayerAction(session.wave.creatures[0]);
        //        LogGame();
        //        PlayerAction(session.wave.creatures[0]);
        //        LogGame();

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


    public void EnemyAction(Enemy current)
    {
        PlayerController.ME.ReceiveDamage(current.Attack());
        CheckSession();
    }

    public void PlayerAction(Enemy current)
    {
        session.wave.ReceiveDamage(current,PlayerController.ME.player.Attack());
        CheckSession();
    }

    private void CheckSession()
    {
        //TODO check all possibilities after any action 
        if (session.wave.finishWaves)
        {
            Debug.Log("MISSION COMPLETE");
        }
        else if (session.wave.readyToNextWave)
        {
            session.wave.Next();
        }
       
    }

}
