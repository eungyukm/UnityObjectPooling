using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_01 : Poolable_01
{
    float force = 1000f;
    Rigidbody rb;
    Vector3 dir;

    Vector3 startPos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        dir = transform.forward;
        startPos = transform.position;

        Application.targetFrameRate = 60;
    }

    // SetActive(true)
    private void OnEnable()
    {
        rb.AddForce(dir * force);
        StartCoroutine(Release());
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(2f);
        OnBecameInvisible();
    }

    private void OnBecameInvisible()
    {
        ObjectPoolManager_01.Instance.objectPool.Push(this);
    }
}
