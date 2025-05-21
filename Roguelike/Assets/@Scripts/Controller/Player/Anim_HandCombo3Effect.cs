using UnityEngine;

public class Anim_HandCombo3Effect : MonoBehaviour
{
    public GameObject LeftEffect;
    public GameObject RightEffect;
    
    public void Effect()
    {
        Instantiate(LeftEffect,new Vector3(gameObject.transform.position.x+0.5f,0,0),Quaternion.identity);
        Instantiate(RightEffect, new Vector3(gameObject.transform.position.x - 0.5f, 0, 0), Quaternion.identity);
    }
}
