using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private float initialBlood;
    public override void InitiateCharacter(int life, float blood)
    {
        base.life = life;
        this.initialBlood = base.blood = blood;
    }

    public override void ReceiveDamage(int damage)
    {
        blood += damage;
        CheckLife();

    }

    private void CheckLife()
    {
        if (blood <= 0)
        {
            life--;
            blood = initialBlood;
        }
    }
}
