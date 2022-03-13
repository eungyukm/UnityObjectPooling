using UnityEngine;

public class Root : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 생성할 수 없음
        // ChildBase childBase = new ChildBase();


        ElementBase elementBase = new ElementBase();
        elementBase.DoCall();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class RootBase
{
    protected virtual void Do()
    {

    }
}

public abstract class ChildBase : RootBase
{
    protected int id = 0;
    static int _objRef = 0;
    protected ChildBase()
    {
       Debug.Log("Child Base Call");
       id = ++_objRef;
    }
    protected abstract override void Do();
}

public class ElementBase : ChildBase
{
    public ElementBase()
    {
        Debug.Log("Element Constructor id : " + id);
    }

    protected override void Do()
    {
        Debug.Log("Do Call Element id : " + id);
    }

    public void DoCall()
    {
        Do();
    }
}