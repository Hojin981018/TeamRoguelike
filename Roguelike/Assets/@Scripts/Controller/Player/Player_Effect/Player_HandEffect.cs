using UnityEngine;

public class Player_HandEffect : MonoBehaviour
{
    public GameObject JabEffect;
    public GameObject HookEffect;
    public GameObject UppercutEffect;

    public Transform jabPoint;
    public Transform hookPoint;
    public Transform uppercutPoint;

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
}
