using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody rb;
    public Vector3 movement;        //�Ѻ�Թ�ص�ҡ�����
      
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //�Ѻ��Ҩҡ�鹾����
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        float z = Input.GetAxis("Vertical");
    }

}
