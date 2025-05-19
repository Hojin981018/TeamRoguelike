using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public enum WeaponType
{
    Hand,
    Sword,
    Gun
}

public class PlayerController : MonoBehaviour
{
    Transform tr;
    Rigidbody2D rb;
    Animator anim;
    WeaponType weaponType;
    private float h;
    //private int comboCount = 0;
    public bool isJumping = false;
    public bool isAttacking = false;
    //public RuntimeAnimatorController handAnim;
    //public RuntimeAnimatorController SwordAnim;
    public MonoBehaviour HandAnimScript;
    public MonoBehaviour SwordAnimScript;
    public MonoBehaviour GunAnimScript;
    public int wType = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        anim = GetComponent<Animator>();
        HandAnimScript = gameObject.GetComponent<Anim_Hand>();
        SwordAnimScript = gameObject.GetComponent <Anim_Sword>();
        GunAnimScript = gameObject.GetComponent<Anim_Gun>();
        rb.freezeRotation = true;
    }
    void SetWeaponState()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            weaponType++;
            if (weaponType > WeaponType.Gun)
            {
                weaponType = WeaponType.Hand;
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            weaponType--;
            if (weaponType < WeaponType.Hand)
            {
                weaponType = WeaponType.Gun;
            }
        }
        wType = (int)weaponType;
    }
    void GetWeaponState()
    {
        switch (weaponType)
        {
            case WeaponType.Hand:
               
                HandAnimScript.enabled = true;
                SwordAnimScript.enabled = false;
                GunAnimScript.enabled = false;
                anim.SetInteger("WeaponType", wType);
            break;
            case WeaponType.Sword:
                HandAnimScript.enabled = false;
                SwordAnimScript.enabled = true;
                GunAnimScript.enabled = false;
                anim.SetInteger("WeaponType", wType);
                break;
            case WeaponType.Gun:
                HandAnimScript.enabled = false;
                SwordAnimScript.enabled = false;
                GunAnimScript.enabled = true;
                anim.SetInteger("WeaponType", wType);
                break;
        }
    }
    
    void Move()
    {
        if (Input.GetButton(Define.Horizontal) && (isAttacking == false || weaponType==WeaponType.Gun))
        {
            h = Input.GetAxisRaw(Define.Horizontal);
            Vector2 moveDir = new Vector2(h, 0);
            anim.SetBool(Define.isWalkHash, true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool(Define.isRunHash, true);
                tr.Translate(Time.deltaTime * 2  /*추후 플레이어 이동속도 변수로 받아오기 */* moveDir);
            }
            else
            {
                anim.SetBool(Define.isRunHash, false);
                tr.Translate(Time.deltaTime * 1  /*추후 플레이어 이동속도 변수로 받아오기 */* moveDir);
            }


            if (h > 0)
            {
                tr.localScale = new Vector3(1, 1, 1);
            }
            else if (h < 0)
            {
                tr.localScale = new Vector3(-1, 1, 1);
            }

        }
        else
        {
            anim.SetBool(Define.isWalkHash, false);
            anim.SetBool(Define.isRunHash, false);
        }
    }
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isAttacking = true;
            anim.SetBool(Define.AttackHash, true);
        }
    }
    public void AttackAnimFalse()
    {
        isAttacking = false;
        anim.SetBool(Define.AttackHash, false);
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
        Attack();
        SetWeaponState();
        GetWeaponState();
    }
}
