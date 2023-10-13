using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeController : MonoBehaviour
{
    public float speed = 2f;
    public Vector3 target;
    public Camera mainCamera;
    private bool isLeftMouseButtonDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // CLICK DETECTION
        if (Input.GetMouseButtonDown(0)) {
            isLeftMouseButtonDown = true;
        }
        if (Input.GetMouseButtonUp(0)) {
            isLeftMouseButtonDown = false;
        }
        
        //MOVE
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = transform.position.z;
        if(isLeftMouseButtonDown) {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }
}
