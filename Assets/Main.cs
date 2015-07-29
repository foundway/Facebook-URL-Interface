using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	private readonly string FBURL = "http://m.facebook.com/";
	public string PageID;
	public string AppID;
	public string Link;
	public string Name;
	public string Caption;
	public string Picture;
	public string Redirect;
	public string Description;

	public void OnLike() {
		Application.OpenURL(FBURL + PageID);
	}

	public void OnFeed() {
		Application.OpenURL (FBURL + "/dialog/feed?app_id=" + AppID +
			                     "&link=" + WWW.EscapeURL(Link) +
			                     "&name=" + WWW.EscapeURL(Name) +
			                     "&caption=" + WWW.EscapeURL(Caption) + 
			                     "&description=" + WWW.EscapeURL(Description) + 
			                     "&picture=" + WWW.EscapeURL(Picture) + 
			                     "&redirect_uri=" + WWW.EscapeURL(Redirect));
	}
}
