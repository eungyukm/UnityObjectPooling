using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_01 : MonoBehaviour
{
    public GameObject shootPos;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ObjectPoolManager_01.Instance.objectPool.Pop().transform.position = shootPos.transform.position;
        }
    }
}
