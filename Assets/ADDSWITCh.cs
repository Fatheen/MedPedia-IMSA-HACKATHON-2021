using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ADDSWITCh : MonoBehaviour
{
    public Button getAdd;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = getAdd.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick() { 
    SceneManager.LoadScene(3);
    }
}
