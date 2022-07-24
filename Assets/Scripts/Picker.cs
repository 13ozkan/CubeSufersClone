using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    GameObject mainCube;
    int height;

    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0); 
    }

    public void HeightDecrease()
    {
        height--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Collectable" && other.gameObject.GetComponent<CollectableCube>().GetIsCollect()==false)
        {
            height += 1;
            other.gameObject.GetComponent<CollectableCube>().Colleted();
            other.gameObject.GetComponent<CollectableCube>().SetIndex(height);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
