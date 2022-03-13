using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager_01 : MonoBehaviour
{
    private static ObjectPoolManager_01 instance;
    public static ObjectPoolManager_01 Instance
    {
        get
        {
            return instance;
        }
    }

    public ObjectPool_01 objectPool;

    private void Awake()
    {
        if(instance)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
}
