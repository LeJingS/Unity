using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    bool isSel=true;
    // Start is called before the first frame update
    private void OnGUI()
    {
        //多选框
        isSel = GUI.Toggle(new Rect(0, 0, 100, 100), isSel,"开关0");
        //单选框是基于多选框来实现，本质是逻辑控制只有一个选项可以被选中

    }
}
