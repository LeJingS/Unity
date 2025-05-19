using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        #region 刚体自带添加力的方法
        //给刚体加力就是给刚体加一个速度
        //1.首先应该获取刚体组件
        rigidBody = this.GetComponent<Rigidbody>();
        //2.加力
        //相对世界坐标
        //相当于相对世界坐标轴方向加了1个力
        //加力后是否持续移动由阻力决定
        //rigidBody.AddForce(Vector3.forward * 10);

        //相对于本地坐标系
        //rigidBody.AddRelativeForce(Vector3.forward * 10);

        //3.添加扭矩力，使其旋转
        //相对世界坐标
        //rigidBody.AddTorque(Vector3.up * 10);
        //相对与本地坐标
        //rigidBody.AddRelativeTorque(Vector3.up * 10);

        //4.直接改变速度（很少使用）。是相对于世界坐标系的
        //rigidBody.velocity = Vector3.forward * 5;

        //5.模拟爆炸效果 爆炸的力，爆炸中心，爆炸的半径（只会影响调用此方法的对象）
        //rigidBody.AddExplosionForce(10, Vector3.zero, 10);
        #endregion

        #region 力的几种模式
        // 前面的方法都有含第二个参数的重载
        //第二个参数是枚举，表示力的模式，计算方式不同导致最后的速度不同
        //动量定理：
        //Ft=mv
        //v=Ft/m;

        //ForceMode.Acceleration给物体增加一个持续的加速度，忽略其质量
        //v=F*t t为设置好的，默认0.02

        //ForceMode.Force给物体增加一个持续的加速度，不忽略其质量,最常用

        //ForceMode.Impulse给物体一个瞬间的力，与质量有关，忽略时间
        //v=F/m

        //ForceMode.VelocityChange给物体一个瞬间的速度，忽略质量
        //v=F

        #endregion

        #region 刚体休眠
        //为了节约资源，在某种情况下刚体不再计算。防止休眠：
        if (rigidBody.IsSleeping())
        {
            rigidBody.WakeUp();
        }

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
