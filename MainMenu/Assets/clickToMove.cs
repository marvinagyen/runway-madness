using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToMove : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public Vector3 moveToPosition;
    // Start is called before the first frame update
    void Start()
    {
        // moveToPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if(PauseMenuScript.GameIsPaused)
        // {
        //     target = null;
        // }
        if (Input.GetMouseButtonDown(0))
        {
            // Debug.Log("Hello");
            Vector2 raycastposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raycastposition, Vector2.zero);
            
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Plane")
                {
                    target = hit.collider.gameObject;
                }
            }
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            // Debug.Log("Goodbye");
            moveToPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moveToPosition.z = transform.position.z;
            // target.transform.GetComponent<Plane>().MovePlane(moveToPosition);
        }
        if (target != null)
        {
            target.transform.position = Vector3.MoveTowards(target.transform.position, moveToPosition, speed * Time.deltaTime);
            // target.transform.GetComponent<Plane>().MovePlane(moveToPosition);
            // target = null;
            //target.transform.position = Vector3.MoveTowards(target.transform.position, moveToPosition, speed * Time.deltaTime);
        }
    }
}
