using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
    public Submit submit;
    public string len;
    public string we;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        len = submit.getHe();
        we = submit.getWe();
    }
}
