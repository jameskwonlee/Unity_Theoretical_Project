using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BigEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

   // POLYMORPHISM
    protected override void DealDamage()
    {
        hitPoints -= 5;
    }
}
