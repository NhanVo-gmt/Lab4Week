using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int num = 3;
    
    // Update is called once per frame
    void Update()
    {
        num++;
        Debug.Log($"{gameObject.name}:{num}");
    }
}
