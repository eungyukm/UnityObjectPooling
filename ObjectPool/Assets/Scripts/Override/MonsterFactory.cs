using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFactory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Monster monster = FindObjectOfType<Monster>();

        //monster.Attack();

        Orc orc = new Orc();
        orc.Attack();
        Dragon dragon = new Dragon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
