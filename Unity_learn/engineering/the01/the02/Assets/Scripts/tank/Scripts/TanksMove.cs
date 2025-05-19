using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanksMove : MonoBehaviour
{
    public int sudu = 10;
    public Transform head;
    public Transform pao;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(sudu*Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime);

        this.transform.Rotate(sudu*Vector3.up * Time.deltaTime * Input.GetAxis("Horizontal"));

        //鼠标
        head.Rotate(sudu * Vector3.up * Time.deltaTime * Input.GetAxis("Mouse X"));
        // 炮管上下移动用鼠标滚动控制
        pao.Rotate(sudu * Vector3.right * Time.deltaTime * Input.mouseScrollDelta.y);
    }

}
