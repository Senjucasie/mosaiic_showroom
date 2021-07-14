using System;
using UnityEngine;
[Serializable]
public class CommentDataHolder
{
    public string Title;
    public string Content;
    public String DateTime;
    public GameObject Comment;

    public CommentDataHolder(string title, string content,string datetime,GameObject comment)
    {
        Title = title;
        Content = content;
        Comment = comment;
        DateTime = datetime;
    }

}