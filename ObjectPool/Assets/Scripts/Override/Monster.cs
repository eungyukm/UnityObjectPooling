using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public virtual void Attack()
    {
        Debug.Log("공격!!");
    }

    public virtual void Damage()
    {
        Debug.Log("으악!!");
    }

    public void MonsterLog()
    {
        Debug.Log("Log!!");
    }
}

// 정적 클래스(static class)를 제외한 모든 클래스에서 사용가능
//public static class Dog
//{
//    public virtual void Bark()
//    {

//    }
//}

public class Orc : Monster
{
    public override void Attack()
    {
        // StackOverflow
        // Attack();

        base.Attack();
        Debug.Log("우리는 노예가 되지 않는다!");
    }
}

public class Dragon : Monster
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("모든 것이 불타오를 것이다!");
    }
}