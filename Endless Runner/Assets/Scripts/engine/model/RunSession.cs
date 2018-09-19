using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSession  {

    private WavesCreature waves;
    public override string ToString()
    {
        //string str = "";
        return "[" +  "]";
            
    }
    public RunSession()
    {
        waves = new WavesCreature();
    }

}
