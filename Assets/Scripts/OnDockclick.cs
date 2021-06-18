using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
public class OnDockclick : MonoBehaviour
{
    [SerializeField]
    private DockPosition _dockPosition;
    [SerializeField]
    private Dockable _dockObject;
    [SerializeField]
    private GameObject _model;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetDocker()
    {
        _model.SetActive(true);
        _dockPosition.DockedObject = _dockObject;
    }
    public void RemoveDocker()
    {
        _model.SetActive(false);
        _dockPosition.DockedObject = null;
    }
}
