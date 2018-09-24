using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class WavesCreature {

    public List<Enemy> creatures { get; private set; }
    public int current { get; private set; }
    public int max { get; private set; }

    private bool over
    {
        get { return creatures.Count == 0; }
    }

    public WavesCreature(int max)
    {
        this.max = max;
        creatures = new List<Enemy>();
    }

    public void Next()
    {
        if(!over) throw new Exception();

        creatures.Add(new CreatureA());
        creatures.Add(new CreatureB());
        creatures.Add(new CreatureC());
        current++;
    }
}
