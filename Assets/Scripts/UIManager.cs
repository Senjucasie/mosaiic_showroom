using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Chair;
    public GameObject ChairUI;
    //Shade For the UI
    public GameObject ShadeComment,ShadeColor,ShadeAddComment;
    //UI Gameobjects
    public GameObject ColorButn, CommentButn,AddCommentButn,CommentDisplay,CommentView,CommentAdd,ColorUI,Background,CommentBackground;
    public CommentManager CommentControl;
    public int CurrentIndex;
    [SerializeField]
    private Transform ChairUIPos;
    bool test=true;
    public TextMeshPro CommentText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetUI()
    {


        Invoke("DelayUI", .5f);
        
    }
    public void SetParent()
    {
        ChairUI.transform.parent = Chair.transform;
    }
    public void RemoveParent()
    {
        ChairUI.transform.parent = null;
    }
    public void OnClickColor()
    {
        ResetComment();
        Background.SetActive(true);
        ColorUI.SetActive(true);
        ShadeColor.SetActive(false);
       
    }
    public void OnClickCommentButn()
    {
        ResetColor();
        CommentBackground.SetActive(true);
        Background.SetActive(true);
        ShadeComment.SetActive(false);
        CommentView.SetActive(true);
        AddCommentButn.SetActive(true);
        CommentAdd.SetActive(false);
        CommentBackground.SetActive(true);

    }
    public void Delete()
    {
        DestroyImmediate(CommentControl.ChairCommentList[CurrentIndex].Comment);
        CommentControl.ChairCommentList.RemoveAt(CurrentIndex);
        CommentControl.ChairGrid.UpdateCollection();
        CommentControl.Chairscroll.Reset();
        back();

    }
    public void back()
    {
       
        ShadeAddComment.SetActive(false);
        CommentDisplay.SetActive(false);
        OnClickCommentButn();
    }
    public void AddNewComment()
    {

        ResetColor();
        CommentBackground.SetActive(true);
        CommentView.SetActive(false);
        CommentDisplay.SetActive(false);
        CommentAdd.SetActive(true);

    }
    public void OnclickComment(int index)
    {
        CurrentIndex = index;
        Debug.Log(CurrentIndex);
        CommentText.text = CommentControl.ChairCommentList[CurrentIndex].Content;
        ShadeAddComment.SetActive(true);
        CommentView.SetActive(false);
        CommentDisplay.SetActive(true);
        CommentAdd.SetActive(false);
        CommentBackground.SetActive(false);
        
    }
    public void ResetColor()
    {
        ShadeColor.SetActive(true);
        ColorUI.SetActive(false);
    }
    public void ResetComment()
    {
        ShadeAddComment.SetActive(false);
        CommentBackground.SetActive(false);
        ShadeComment.SetActive(true);
        CommentView.SetActive(false);
        CommentDisplay.SetActive(false);
        AddCommentButn.SetActive(false);
        

    }
    public void DelayUI()
    {
        if (test)
        {
            ChairUI.transform.position = ChairUIPos.position;
            ChairUI.SetActive(true);
            test = false;
        }
    }
}
