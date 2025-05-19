using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 游戏对象中位移、旋转、缩放、父子关系、坐标转换都由Transfrom处理
        // 1.Vector3
        // 主要是用来表示三维坐标系中的一个点或者一个向量
        Vector3 v = new Vector3();
        v.x = 10;
        v.y = 10;
        v.z = 10;
        // 只传xy，z默认为0
        Vector3 v2 = new Vector3(10, 10);
        Vector3 v3 = new Vector3(10, 10, 10);
        //Vector3 v4;
        print(v + v2);
        print(v - v2);
        print(v * 10);
        // 常用向量
        print(Vector3.zero);//000
        print(Vector3.right);//100
        print(Vector3.left);//-100
        print(Vector3.forward);//001
        print(Vector3.back);//00-1
        print(Vector3.up);//010
        print(Vector3.down);//0-10

        // 常用方法，计算两点之间距离
        Vector3.Distance(v, v2);


        // 2.位置
        // 相对世界坐标系
        //this.gameobject.transform
        print(this.transform.position);

        // 相对父对象
        print(this.transform.localPosition);
        //注意 位置的赋值不能直接改变 xyz，只能整体改变.
        // 虽然transform不能直接改，但是Vector3的xyz可以直接更改
        // 对象当前的各朝向
        // 对象当前的面朝向
        print(this.transform.forward);
        // 对象当前的上朝向
        print(this.transform.up);
        // 对象当前的右朝向
        print(this.transform.right);

        


    }

    // Update is called once per frame
    void Update()
    {
        // 3.位移
        // 路程 = 方向 * 速度 * 时间
        // 手写计算

        this.transform.position += this.transform.forward * 1 * Time.deltaTime;
        // 调用api
        // 参数1表位移多少，参数2表相对坐标系
        // 相对于世界坐标系的z轴动
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime,Space.World);
        // 相对于世界坐标系 自己的面朝向去动
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.World);
        //相对于自己的坐标系下的自己的面朝向移动（一般不会用这种）
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.Self);
        //相对于自己坐标系下的z轴正方向移动，始终朝自己的面朝向移动
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.Self);
    }
}
