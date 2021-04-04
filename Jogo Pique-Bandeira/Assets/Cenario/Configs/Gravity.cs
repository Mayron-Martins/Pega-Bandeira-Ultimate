using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float multiplyGravity;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = Vector3.down * 9.81f * multiplyGravity;
    }

}
