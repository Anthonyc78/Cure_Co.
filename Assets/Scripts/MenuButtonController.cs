using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuButtonController : MonoBehaviour
{
    [SerializeField] GameObject targetObject;
    [SerializeField] GameObject SetMeActive;
    // Start is called before the first frame update
    // blegh
    void Start()
    {

    }
    public void SetGOActive()
    {
        SetMeActive.SetActive(true);
    }
    private void OnMouseOver()
    {
        targetObject.SetActive(true);
    }
    private void OnMouseEnter()
    {
        targetObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        targetObject.SetActive(false);
    }
}
