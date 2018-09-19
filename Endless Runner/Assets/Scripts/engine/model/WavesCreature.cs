using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesCreature {

    private List<Enemy> creatures = new List<Enemy>();

    public WavesCreature()
    {
        creatures.Add(new CreatureA());
        creatures.Add(new CreatureB());
        creatures.Add(new CreatureC());

        foreach (Enemy creature in creatures)
        {
            EnemyAction product = creature.FactoryMethod();
            Debug.Log("Created " + product.GetType().Name);
        }
    }
}
