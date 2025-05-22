using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject nearObject;

    void Start()
    {
        nearObject = null;            
    }

    void Interaction()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            nearObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            nearObject = null;
        }
    }
}
