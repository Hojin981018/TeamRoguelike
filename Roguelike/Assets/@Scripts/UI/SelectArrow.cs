using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectArrow : MonoBehaviour
{
    public GameObject firstSelected;

    void Start()
    {
        
        EventSystem.current.SetSelectedGameObject(firstSelected);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            var selected = EventSystem.current.currentSelectedGameObject;
            if(selected != null)
            {
                ExecuteEvents.Execute(
                    selected, new BaseEventData(EventSystem.current),
                    ExecuteEvents.submitHandler);
            }
        }
    }

}
