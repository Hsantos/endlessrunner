using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    protected int life;
    protected float blood;
    public bool dead;

    public abstract void InitiateCharacter(int life, float blood);
    public abstract void ReceiveDamage(int damage);
   
    public override string ToString()
    {
        return "[" + GetType() +  " | " +  life +  " | " +  blood +  "]";
    }
}
