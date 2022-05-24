using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //declare variable for movement speed
    
    [SerializeField] float yValue = 0.01f; // accessible in the inspector
    [SerializeField] float moveSpeed=10f;
    

    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(1,0,0);// 60fps, in un seondo lo fa 60 volte
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue*0.1f,yValue,zValue*0.1f);
    }
}
