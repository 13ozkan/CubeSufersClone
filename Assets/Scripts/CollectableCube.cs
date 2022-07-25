using UnityEngine;

public class CollectableCube : MonoBehaviour
{

    private bool isCollect;
    private int index;
    public Picker picker;

    void Start()
    {
        isCollect = false;
    }


    void Update()
    {
        if (isCollect == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("Obstacle: Carpti");
            picker.HeightDecrease();
            transform.localPosition = new Vector3(0, -index, 0);
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetIsCollect()
    { 
        return isCollect;
    }

    public void Colleted()
    {
        isCollect = true;
    }

    public void SetIndex(int index)
    {
        this.index = index;
    }
}
