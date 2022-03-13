using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolable_01 : MonoBehaviour
{
    protected ObjectPool_01 pool;

    public virtual void Create(ObjectPool_01 pool)
    {
        this.pool = pool;
        gameObject.SetActive(false);
    }

    public virtual void Push()
    {
        if(pool != null)
        {
            pool.Push(this);
        }
        else
        {
            Debug.Log("Pool이 null입니다.");
        }
    }
}
