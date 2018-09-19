using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureC : Enemy
{
    public override EnemyAction FactoryMethod()
    {
        return new EnemyAction(3);
    }


}
