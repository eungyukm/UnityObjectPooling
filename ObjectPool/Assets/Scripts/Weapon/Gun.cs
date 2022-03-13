using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject shootPos;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ObjectPoolManager.Instance.pool.Pop().transform.position = shootPos.transform.position;
        }
    }
}
