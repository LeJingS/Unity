using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 相对世界坐标角度
        print(this.transform.eulerAngles);

        //相对父对象角度
        print(this.transform.localEulerAngles);

        //设置角度的规则和设置位置的规则是一样的

        

    }

    // Update is called once per frame
    void Update()
    {
        //api改变角度
        // 自转
        // 参数1，选定轴，参数二，选定角度，参数三，默认相对于自己坐标系旋转
        this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        // 相对于某点旋转
        // 参数1 选定点 参数2 选定点的轴 参数3 转的度数
        this.transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
    }
}
