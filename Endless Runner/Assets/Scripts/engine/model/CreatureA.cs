using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureA : Enemy
{
    public override EnemyAction Attack()
    {
        return new EnemyAction(1,-20);
    }

    public CreatureA()
    {
        InitiateCharacter(1,100);
    }

    public override void InitiateCharacter(int life, float blood)
    {
        base.life = life;
        base.blood = blood;
    }

   
}
