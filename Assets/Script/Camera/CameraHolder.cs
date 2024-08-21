using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    public Transform CameraTransform;
    // Update is called once per frame
    void Update()
    {
      transform.position = CameraTransform.position;
    }
}
