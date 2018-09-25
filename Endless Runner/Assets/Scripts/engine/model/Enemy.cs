using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character {

    public abstract EnemyAction Attack();

    public override void ReceiveDamage(int damage)
    {
        blood += damage;
        if (blood <= 0)
        {
            life--;
            blood = 0;
        }
        if (life < 0) life = 0;
        if (blood <= 0 && life <= 1) dead = true;
    }
}
