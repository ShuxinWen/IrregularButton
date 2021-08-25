using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test0825_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {    
        //按钮注册点击事件
        this.gameObject.GetComponent<Button>().onClick.AddListener(() => 
        {
            Debug.Log("点击了Unity图标按钮！");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
