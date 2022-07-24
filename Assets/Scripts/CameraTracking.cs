using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{

    public GameObject mainCube;
    public Vector3 distance;

    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, mainCube.transform.position + distance, Time.deltaTime);
    }
}
