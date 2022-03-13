using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool_01 : MonoBehaviour
{
    [SerializeField] private Poolable_01 poolObj;
    [SerializeField] private int allocateCount;

    private Stack<Poolable_01> poolStack = new Stack<Poolable_01>();

    // Start is called before the first frame update
    void Start()
    {
        Allocate();
    }

    public void Allocate()
    {
        for (int i = 0; i < allocateCount; i++)
        {
            Poolable_01 allocateObj = Instantiate(poolObj, gameObject.transform);
        }
    }

    public void Push(Poolable_01 obj)
    {
        obj.gameObject.SetActive(false);
        poolStack.Push(obj);
    }

    public GameObject Pop()
    {
        if(poolStack.Count > 0)
        {
            Poolable_01 obj = poolStack.Pop();
            obj.gameObject.SetActive(true);
            return obj.gameObject;
        }
        else
        {
            GameObject gameObject = new GameObject();
            return gameObject;
        }
    }
}
