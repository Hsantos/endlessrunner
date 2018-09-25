using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSession  {

    public WavesCreature wave { get; private set; }
    public RunSession()
    {
        wave = new WavesCreature(2);
        wave.Next();
    }

}
