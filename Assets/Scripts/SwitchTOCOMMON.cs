using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SwitchTOCOMMON : MonoBehaviour
{
    public Button getDis;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = getDis.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick() {
        SceneManager.LoadScene(1);

    }
}
