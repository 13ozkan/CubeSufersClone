using UnityEngine;

public class CollectableCube : MonoBehaviour
{

    private bool isCollect;
    private int index;
    public Picker picker;


    // Start is called before the first frame update
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
            picker.HeightDecrease();
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
