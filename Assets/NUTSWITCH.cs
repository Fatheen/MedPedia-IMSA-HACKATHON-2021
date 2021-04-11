using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NUTSWITCH : MonoBehaviour
{
    public Button NUT;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = NUT.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick() {
        SceneManager.LoadScene(5);
    }
}
