using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int num = 3;
    private int maxNum;

    void Start()
    {
        if (gameObject.tag == "Red")
        {
            maxNum = 100;
        }
        
        if (gameObject.tag == "Blue")
        {
            maxNum = Random.Range(150, 251);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        num++;
        Debug.Log($"{gameObject.name}:{num}");
        if (num > maxNum)
        {
            if (gameObject.tag == "Red")
            {
                gameObject.SetActive(false);
                
            }
            else
            {
                rend.enabled = false;
            }
        }
    }
}
