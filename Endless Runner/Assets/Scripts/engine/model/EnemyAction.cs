using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction
{
    public int action { get; private set;}
    public int damage { get; private set;}
    public EnemyAction(int action, int damage)
    {
        this.action = action;
        this.damage = damage;
    }
}