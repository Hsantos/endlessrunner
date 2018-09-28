using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour
{
    private RunView view;
    
    void Awake()
    {
        view = ((GameObject)Instantiate(Resources.Load("Prefab/Runview"), transform)).gameObject.AddComponent<RunView>();
        view.StartSession();
    }


}
