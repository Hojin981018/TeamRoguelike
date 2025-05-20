using UnityEngine;
using UnityEngine.EventSystems;

public class Bg1 : MonoBehaviour
{
    public Transform BackGround;
    public float speed;
    Vector3 dir;

    void Start()
    {
        BackGround = transform.Find("Moon");
        Debug.Log(BackGround);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (BackGround.transform.position.x == -20)
        {
            dir = BackGround.transform.position;
            dir.x = 18;
        }
    }

    //void Update()
    //{
    //    if (Input.GetButton(Define.Horizontal))
    //    {
    //        float h =Input.GetAxisRaw(Define.Horizontal);
    //        Vector3 moveDir = new Vector3(-h, 0, 0);
    //        BackGround.Translate(Time.deltaTime * moveDir * speed);
    //    }
    //}
}
