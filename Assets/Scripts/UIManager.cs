using System.Collections;
using System.Collections.Generic;
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
    public List<GameObject> CommentList;
    [SerializeField]
    private Transform ChairUIPos;
    bool test=true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetUI()
    {
        if(test)
        {
            ChairUI.transform.position = ChairUIPos.position;
            ChairUI.SetActive(true);
            test = false;
        }
       

        
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
    }
    public void Delete()
    {

    }
    public void back()
    {
       
        ShadeAddComment.SetActive(false);
        CommentDisplay.SetActive(false);
        OnClickCommentButn();
    }
    public void AddNewComment()
    {
       
    }
    public void OnclickComment()
    {
        ShadeAddComment.SetActive(true);
        CommentView.SetActive(false);
        CommentDisplay.SetActive(true);
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
}
