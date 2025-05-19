using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    //1.物理碰撞检测响应函数
    
    //碰撞触发接触时，会自动调用此函数
    private void OnCollisionEnter(Collision collision)
    {
        //关键参数
        //1.碰撞的对象的碰撞器信息
        //collision.collider;
        //2.碰撞对象的依附对象
        //collision.gameObject
        //3.位置信息
        //collision.transform
        print(this.name + "被" + collision.gameObject.name + "碰到了");
    }

    //碰撞结束分离时
    private void OnCollisionExit(Collision collision)
    {
        print(this.name + "被" + collision.gameObject.name + "碰撞结束");
    }

    //接触时，会不停的调用
    private void OnCollisionStay(Collision collision)
    {
        print(this.name + "被" + collision.gameObject.name + "接触了");
    }


    //2.触发器检测响应函数
    // 触发开始
    private void OnTriggerEnter(Collider other)
    {
        print(this.name + ".被" + other.gameObject.name + "碰到了");
    }


    // 触发结束
    private void OnTriggerExit(Collider other)
    {
        print(this.name + ".被" + other.gameObject.name + "结束碰撞了");
    }

    // 接触时
    private void OnTriggerStay(Collider other)
    {
        print(this.name + ".被" + other.gameObject.name + "接触了");
    }

    //3.只要挂载的物体能和别的物体发生碰撞或者触发，就会响应这6个函数。
    //如果是一个异形物体，刚体在父对象上。碰撞函数脚本必须挂载在父对象上

    //4.碰撞和触发都可以写成虚函数，在子类重写逻辑

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
