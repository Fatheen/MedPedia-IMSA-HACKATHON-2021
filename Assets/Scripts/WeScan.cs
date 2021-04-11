using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeScan : MonoBehaviour
{
    public string we;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ReadStringInput(string s)
    {
        we = s;
        
    }
    public string getWe() {
        return we;
    }
}
