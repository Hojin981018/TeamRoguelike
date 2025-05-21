using UnityEngine;

public class SelectedMenu : MonoBehaviour
{
    public RectTransform[] menuTr;
    Transform tr;
    int index = 0;
    void Start()
    {
        tr = GetComponent<Transform>();
        gameObject.transform.position = menuTr[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index++;
            if (index > menuTr.Length-1)
            {
                index = 0;
            }
           tr.position = menuTr[index].position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index--;
            if (index < 0)
            {
                index = 2;
            }
            tr.position = menuTr[index].position;
        }
       
    }
}
