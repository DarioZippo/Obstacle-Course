using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0, yAngle = 0, zAngle = 0;

    // Update is called once per frame
    void Update()
    {
        //Ruota di un grado in ogni asse per frame
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
