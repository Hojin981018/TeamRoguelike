using UnityEngine;

public class Player_HandEffect : MonoBehaviour
{
    /// <summary>
    /// HandAttackEffect Animation Event
    /// </summary>
    public GameObject JabEffect;
    public GameObject HookEffect;
    public GameObject UppercutEffect;
    public GameObject[] KickEffect;
    public GameObject Combo3FinishAtkEffect;

    public Transform jabPoint;
    public Transform hookPoint;
    public Transform uppercutPoint;
    public Transform kick3Point;
    public Transform Combo3FinishAtkTr;
    public void Jab()
    {
        Instantiate(JabEffect,jabPoint);
    }
    public void Hook()
    {
        Instantiate(HookEffect, hookPoint);
    }
    public void Uppercut()
    {
        Instantiate (UppercutEffect, uppercutPoint);
    }
    public void CircleKick()
    {
        Instantiate(KickEffect[0], kick3Point);
    }
    public void Combo3FinishAttack()
    {
        var FinishAtk = Instantiate(Combo3FinishAtkEffect);
        FinishAtk.transform.position = Combo3FinishAtkTr.position; 
        if (transform.localScale.x == 1)
        {
            FinishAtk.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (transform.localScale.x == -1)
        {
            FinishAtk.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
