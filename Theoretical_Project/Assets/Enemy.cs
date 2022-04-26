using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   // ENCAPSULATION
    [SerializeField] protected int hitPoints = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnMouseDown()
    {
        DealDamage();

        if (hitPoints < 1) {
            DeathCue();
        }
    }
    // ENCAPSULATION
    protected virtual void DealDamage() {
        hitPoints -= 10;
    }

    void DeathCue() {

        Destroy(gameObject);

    }
}
