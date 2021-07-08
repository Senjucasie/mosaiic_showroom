using UnityEngine.UI;
using UnityEngine;

public class Addcommenttest : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField]
    InputField inputField;
    public CommentManager UI;
    public string Name;
    private void Start()
    {
       
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Debug.Log("adada");
            UI.AddComment(Name);
        }
           
    }
#endif
}
