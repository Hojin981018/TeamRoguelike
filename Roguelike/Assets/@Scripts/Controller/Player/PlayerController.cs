using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    Transform tr;
    Rigidbody2D rb;
    Animator anim;
    float h;

    public bool isJumping = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        anim = GetComponent<Animator>();
        rb.freezeRotation = true;
    }

    void Move()
    {
        if (Input.GetButton(Define.Horizontal))
        { 
            h = Input.GetAxis(Define.Horizontal);
            Vector2 moveDir = new Vector2(h, 0);
            anim.SetBool(Define.isRunHash, true);
            tr.Translate(Time.deltaTime * 5 /*추후 플레이어 이동속도 변수로 받아오기 */*moveDir);
            if (h > 0)
            {
                tr.localScale = new Vector3(1,1,1);
            }
            else if (h < 0)
            {
                tr.localScale = new Vector3(-1, 1, 1);
            }

        }
        else
        {
            anim.SetBool(Define.isRunHash, false);
        }
    }
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //anim.SetTrigger(Define.AttackHash);
            anim.SetBool("isAttack", true);
        }
    }
    void AnimAttackFalse()
    {
        anim.SetBool("isAttack", false);
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.C) && isJumping == false)
        {
            rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            isJumping = true; 
        }
    }
    void TestHurt()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            anim.SetTrigger("Hurt");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isJumping = false;
        }
        
    }
    void Update()
    {
        Move();
        Jump();
        Attack();
        TestHurt();
        
    }
}
