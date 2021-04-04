using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerControl : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.tag != "wall")
                {
                    agent.SetDestination(hit.point);
                    Debug.Log("foi");
                }
            }
        }
    }
}
