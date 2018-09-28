using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveView : MonoBehaviour {

    private List<EnemyView> enemyList;

    void Awake()
    {
        enemyList = new List<EnemyView>();
    }

    public void CreateWave(List<Enemy> currentList)
    {
        Debug.Log(currentList.Count);
        for (int i = 0; i < currentList.Count; i++)
        {
            EnemyView enemy = ((GameObject)Instantiate(Resources.Load("Prefab/EnemyView"), transform)).gameObject.AddComponent<EnemyView>();
            enemyList.Add(enemy);
            enemy.Initiate(currentList[i]);
        }
    }
}
