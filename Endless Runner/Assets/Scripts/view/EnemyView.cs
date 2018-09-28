using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{

    private SpriteRenderer render;
    public void Initiate(Enemy enemy)
    {
        
        if (enemy is CreatureA)
        {
            render = ((GameObject)Instantiate(Resources.Load("Prefab/Enemies/e2"), transform)).GetComponent<SpriteRenderer>();
        }
        
    }
}
