using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;

public class SearchHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject scroll_Parent;

    private int length;
    [SerializeField]
    private List<GameObject> scroll_ChildList;
   // Start is called before the first frame update
    void Start()
    {
        length = scroll_Parent.transform.childCount;
       // Debug.Log(scroll_Parent.transform.childCount);

        for (int i = 0; i < length; i++)
        {
            scroll_ChildList.Add(scroll_Parent.transform.GetChild(i).gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Search(GameObject obj)
    {
        obj.transform.SetAsFirstSibling();
        
        foreach(GameObject child in scroll_ChildList)
        {
            if(child==obj)
            {
                child.SetActive(true);
            }
            else
            {
                child.SetActive(false);
            }
        }
        scroll_Parent.GetComponent<GridObjectCollection>().UpdateCollection();
    }
    public void RemoveSearch()
    {
        foreach(GameObject child in scroll_ChildList)
        {
            child.SetActive(true);
        }
    
        scroll_Parent.GetComponent<GridObjectCollection>().UpdateCollection();
        gameObject.SetActive(false);
    }

}
