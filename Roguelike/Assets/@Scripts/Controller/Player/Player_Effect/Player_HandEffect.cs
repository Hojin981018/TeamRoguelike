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

    public Transform jabPoint;
    public Transform hookPoint;
    public Transform uppercutPoint;
    public Transform kick3Point;
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
}
