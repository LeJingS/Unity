using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_3 : MonoBehaviour
{
    // Start is called before the first frame update
    //通过将脚本挂载到对象上，通过对象的失活激活来控制显影
    //创建显示和隐藏方法来达到切换页面的效果

    //因为静态方法，不能用this,用静态属性取代this
    private static Lesson_3 instance;
    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
        }
    }

}
