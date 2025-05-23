using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_4 : MonoBehaviour
{
    private string text ="请输入内容";

    private string password;
    private float f1;
    private void OnGUI()
    {
        //输入框和拖动条

        //普通输入和密码输入
        //普通输入
        //参数 位置大小 显示字符串 输入内容的最大长度
        text = GUI.TextField(new Rect(0, 0, 100, 30), text,10);
        password = GUI.PasswordField(new Rect(0, 50, 100, 30), password, '*');

        //水平拖动条 位置大小 显示值 最小值 最大值
        f1 = GUI.HorizontalSlider(new Rect(0, 100, 100, 50), f1, 0, 100);
        //竖直拖动条
        f1 = GUI.VerticalSlider(new Rect(0, 150, 50, 100), f1, 0, 100);

        
    }
}
