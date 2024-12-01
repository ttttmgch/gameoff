using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritesorter : MonoBehaviour
{
    private int sortingOrderBase = 0;
    private Renderer renderer;
    public float offset = 0;
    public bool isStatic = false;


    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }
    
    private void LateUpdate()
    {
        renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset);
        if (isStatic)
           Destroy(this);
    }
}
