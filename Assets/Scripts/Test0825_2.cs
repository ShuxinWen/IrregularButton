using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test0825_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //alphaHitTestMinimumThreshold 范围值：0 ~ 1 。
        this.gameObject.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
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
