using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Poolable
{
    float force = 1000f;
    Rigidbody rb;
    Vector3 dir;

    float time = 0f;
    Vector3 startPos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        dir = transform.forward;
        startPos = transform.position;
    }

    private void OnEnable()
    {
        rb.AddForce(dir * force);
        StartCoroutine(Release());
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(2f);
        OnBecameInvisiable();
    }

    private void OnBecameInvisiable()
    {
        ObjectPoolManager.Instance.pool.Push(this);
    }
}
