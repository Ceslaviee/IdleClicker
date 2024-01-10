using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverConstell : MonoBehaviour
{
    public GameObject logoText;
    // Start is called before the first frame update
    void Start()
    {
        logoText.SetActive(false);
    }
    public void OnMouseOver()
    {
        logoText.SetActive(true);
    }
    public void OnMouseExit()
    {
        logoText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
