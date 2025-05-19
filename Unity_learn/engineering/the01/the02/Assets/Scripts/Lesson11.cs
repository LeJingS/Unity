using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 输入相关内容一定写在Update中

        #region 鼠标在屏幕位置
        //屏幕的原点在左下角，→是x+，↑是y+
        //返回值是Vector3，z值一直为0
        print(Input.mousePosition);
        #endregion

        #region 检测鼠标输入
        //鼠标按下的瞬间进入
        //0==左键 1==右键 2==中键
        if (Input.GetMouseButtonDown(0))
        {
            print("鼠标按下左键");
        }
        //鼠标抬起的一瞬间
        if(Input.GetMouseButtonUp(0))
        {
            print("左键抬起了");
        }
        //鼠标长按、按下、抬起都会进入，每一帧都会检测，不止进入一次
        if (Input.GetMouseButton(1))
        {
            print("鼠标右键有操作");
        }
        //中键滚动
        // 返回值 y -1下滚动 0没有滚动 1上滚动
        print("中键滚动了" + Input.mouseScrollDelta);
        #endregion

        #region 检测键盘输入
        //键盘按下
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("按下了W");
        }
        //传入字符串的重载,必须传入小写的字符串
        if (Input.GetKeyDown("q"))
        {
            print("按下了Q");
        }

        //键盘抬起
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("抬起了W");
        }
        //键盘长按
        if (Input.GetKey(KeyCode.W))
        {
            print("长按W");
        }
        #endregion

        #region 检测默认轴输入
        // 学习鼠标键盘输入是用来控制玩家的旋转和位移等
        //Unity提供了更方便的方法来帮助我们控制对象的位移和选择
        // 键盘从AD按下时 返回 -1到1之间的变换
        // 相当于得到这个值就是左右方向，可以通过这个来控制对象左右移动或左右旋转
        //print(Input.GetAxis("Horizontal"));
        // 键盘从SW按下时 返回 -1到1之间的变换
        // 相当于得到这个值就是上下方向，可以通过这个来控制对象上下移动或上下旋转
        //print(Input.GetAxis("Vertical"));

        // 鼠标横向移动时 -1 到 1 左 右
        print("鼠标左右"+Input.GetAxis("Mouse X"));
        // 鼠标竖向移动时 -1 到 1 下 上
        print("鼠标上下" + Input.GetAxis("Mouse Y"));

        // GetAxis方法会有渐变，GetAxisRaw使用方式相同，但是它的返回值只有-1 0 1
        #endregion

        #region 其他
        // 是否有任意键或鼠标长按，一直进入
        if (Input.anyKey)
        {
            print("有一个建长按");
        }
        // 是否有任意键或鼠标按下，只进入一次
        if (Input.anyKeyDown)
        {
            print("有一个建按下");
        }
        //这一帧的键盘输入
        print(Input.inputString);

        // 手柄输入相关
        //得到连接的手柄所有按钮名字
        string[] strs = Input.GetJoystickNames();
        //某一个手柄键按下
        if (Input.GetButtonDown("Jump"))
        {

        }
        //某一个手柄键抬起
        if (Input.GetButtonUp("Jump"))
        {

        }
        //某一个手柄键长按
        if (Input.GetButton("Jump"))
        {

        }
        //移动设备触摸相关
        if(Input.touchCount > 0)
        {
            Touch t1 = Input.touches[0];
            // 位置
            print(t1.position);
            //相对上次位置的变换
            print(t1.deltaPosition);
        }
        //是否启用多点触控
        Input.multiTouchEnabled = false;
        //陀螺仪（重力感应）
        // 是否开启
        Input.gyro.enabled = true;
        //重力加速度向量
        print(Input.gyro.gravity);
        //旋转速度
        print(Input.gyro.rotationRate);
        //陀螺仪 当前的旋转四元数(角度相关信息)
        print(Input.gyro.attitude);
        #endregion
    }
}
