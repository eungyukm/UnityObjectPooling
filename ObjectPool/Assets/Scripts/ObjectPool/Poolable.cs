using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolable : MonoBehaviour
{
    protected ObjectPool pool;

    public virtual void Create(ObjectPool pool)
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
            Debug.Log("Pool이 null입니.");
        }
    }
}
