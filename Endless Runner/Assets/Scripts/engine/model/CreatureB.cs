using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureB : Enemy
{
    public override EnemyAction FactoryMethod()
    {
        return new EnemyAction(2);
    }


}
