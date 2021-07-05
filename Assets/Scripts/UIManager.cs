using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Chair;
    public GameObject ChairUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetParent()
    {
        ChairUI.transform.parent = Chair.transform;
    }
    public void RemoveParent()
    {
        ChairUI.transform.parent = null;
    }
}
