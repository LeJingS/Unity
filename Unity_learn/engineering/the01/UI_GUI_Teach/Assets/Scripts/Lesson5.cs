using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{

    public Rect texPos;
    public Texture tex;
    private void OnGUI()
    {
        //图片绘制，不会自动等比缩放。可以选择缩放类型、是否开启透明背景、宽高比
        //GUI.DrawTexture(texPos, tex,ScaleMode.ScaleAndCrop,true,1);

        //框绘制，即绘制一张框
        GUI.Box(texPos, "123");
    }

}


