using Microsoft.MixedReality.Toolkit.Utilities.Solvers;

using UnityEngine;

public class DockerManager : MonoBehaviour
{
    [SerializeField]
    private RadialView _radialView;
   
    public void DisableRadial()
    {

        Invoke("disableradial", 1f);
    }
    private void disableradial()
    {
        _radialView.enabled = false;
    }
    
}
