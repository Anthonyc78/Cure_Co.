using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuButtonController : MonoBehaviour
{
    [SerializeField] GameObject targetObject;
    [SerializeField] GameObject ShowMeOnClick;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void SetActiveOnCLick()
    {
        ShowMeOnClick.SetActive(true);
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
