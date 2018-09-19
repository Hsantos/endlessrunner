using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunController : Singleton<RunController> {

    public RunSession session { get; private set; }
	
    public void StartSession()
    {
        session = new RunSession();
    }
    

    public void LogGame()
    {
        string str = "";
       

        Debug.Log(str);
    }


}
