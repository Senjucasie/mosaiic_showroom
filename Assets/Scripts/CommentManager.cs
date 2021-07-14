using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CommentManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<CommentDataHolder> ChairCommentList;
    public List<CommentDataHolder> StoolCommentList;
    public List<CommentDataHolder> JigSawCommentList;
    public GameObject CommentbutnPrefab,Commentprefab;
    public Transform ButnParent;
    public GridObjectCollection ChairGrid;
    public ScrollingObjectCollection Chairscroll;
    public TextMeshPro Chairtext;
    public UIManager UIControl;
    [SerializeField]
    private string _timeDate;

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddComment(string name)
    {
        switch(name)
        {
            case "chair":
                var commentbuttn = Instantiate(CommentbutnPrefab, ButnParent);
                int count = ChairCommentList.Count;
                count++;
                settime();
                ChairCommentList.Add(new CommentDataHolder("Comment" + count.ToString(), Chairtext.text, _timeDate, commentbuttn));
                commentbuttn.transform.GetChild(4).GetChild(0).GetComponent<TextMeshPro>().text = ChairCommentList[count - 1].Content;
                commentbuttn.transform.GetChild(4).GetChild(1).GetComponent<TextMeshPro>().text = ChairCommentList[count - 1].DateTime;
                commentbuttn.GetComponent<OnClickComment>().UIcontrol = UIControl;
                commentbuttn.GetComponent<Interactable>().OnClick.AddListener(() => commentbuttn.GetComponent<OnClickComment>().OnClick());
                ChairGrid.UpdateCollection();
                Chairscroll.Reset();
                UIControl.OnClickCommentButn();
                break;
            case "stool":

                break;
            case "jigsaw":

                break;

        }
    }
    public void DeleteComment(string name)
    {
        switch (name)
        {
            case "chair":

                break;
            case "stool":

                break;
            case "jigsaw":

                break;

        }
    }
    public void EditComment(string name)
    {
        switch (name)
        {
            case "chair":

                break;
            case "stool":

                break;
            case "jigsaw":

                break;

        }
    }
    private void settime()
    {
        System.DateTime theTime = System.DateTime.Now;
        string date = theTime.Day + "." + theTime.Month + "." + theTime.Year;
        _timeDate = date + theTime.Hour + ":" + theTime.Minute + ":" + theTime.Second;
    }
}
