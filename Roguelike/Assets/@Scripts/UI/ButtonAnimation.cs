using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimation : MonoBehaviour
{

    public List<GameObject> buttonObjects = new List<GameObject>();
    private GameObject lastSelected;

    void Start()
    {
        lastSelected = EventSystem.current.currentSelectedGameObject;
        SetSelectedState(lastSelected, true);
    }

    void Update()
    {
        var current = EventSystem.current.currentSelectedGameObject;

        if (current != lastSelected)
        {
            SetSelectedState(lastSelected, false);
            SetSelectedState(current, true);
            lastSelected = current;
        }
    }

    void SetSelectedState(GameObject button, bool isSelected)
    {
        if (button == null) return;
        Animator animator = button.GetComponent<Animator>();
        if (animator != null)
            animator.SetBool("IsSelected", isSelected);
    }
}
