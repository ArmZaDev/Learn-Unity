using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody rb;
    public Vector3 movement;        //รับอินพุตจากผู้ใช้
      
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //รับค่าจากแป้นพิมพ์
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        float z = Input.GetAxis("Vertical");
        movement = new Vector3(x, y, z);
    }

    private void FixedUpdate()
    {
        movePlayer(movement);
    }
    
    void movePlayer(Vecter3 direction)
    {
        rb.velocity = direction * speed;
    }

}
