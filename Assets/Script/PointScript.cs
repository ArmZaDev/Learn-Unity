using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //สร้าง Box ขึ้นมา
        if (Input.GetMouseButtonDown(0))
        {
            GameObject BoxClone = Instantiate(box) as GameObject;   
        }

        //โคยสร้างที่ตำแหน่ง
        box.transform.position = transform.position;
    }
}
