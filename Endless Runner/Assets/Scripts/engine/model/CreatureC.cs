using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureC : Enemy
{
    public override EnemyAction FactoryMethod()
    {
        return new EnemyAction(1,-60);
    }

    public CreatureC()
    {
        InitiateCharacter(1,100);
    }
    public override void InitiateCharacter(int life, float blood)
    {
        base.life = life;
        base.blood = blood;
    }

    public override void ReceiveDamage(int damage)
    {
        throw new System.NotImplementedException();
    }
}
