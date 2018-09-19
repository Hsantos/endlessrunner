using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RunView : MonoBehaviour
{

   
    void Awake()
    {
         DrawSession();
    }

    private void DrawSession()
    {
        RunController.ME.StartSession();
    }
    
  


}
