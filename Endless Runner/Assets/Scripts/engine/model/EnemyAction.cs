using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction
{
    public int action { get; private set;}
    public EnemyAction(int action)
    {
        this.action = action;
    }
}