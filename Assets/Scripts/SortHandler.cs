using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
public class SortHandler : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _uiButton;
    [SerializeField]
    private List<string> _butnName;
    [SerializeField]
    private GridObjectCollection _grid;
    // Start is called before the first frame update
    void Start()
    {
       
        SortScrollUI();
       
    }
    public void SortScrollUI()
        {
        int length = transform.childCount;

        for (int i = 0; i < length; i++)
        {
            _uiButton.Add(transform.GetChild(i).gameObject);
            _butnName.Add(_uiButton[i].name);
        }

        _butnName.Sort();

        for(int i=0;i<_butnName.Count;i++)
        {
            foreach(GameObject butn in _uiButton)
            {
                if(butn.name==_butnName[i])
                {
                    butn.transform.SetSiblingIndex(i);
                    break;
                }
            }
        }
        _grid.UpdateCollection();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
