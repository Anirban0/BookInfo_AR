using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class uimanager : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform mainmenu, about, contact;

    private void Start()
    {
        mainmenu.DOAnchorPos(Vector2.zero, 0.50f);

    }
    public void contactUS_button()
    {
        mainmenu.DOAnchorPos(new Vector2(-1160, -64), 0.40f);
        contact.DOAnchorPos(new Vector2(0, 0), 0.40f);
    }

    public void aboutbutton()
    {
        mainmenu.DOAnchorPos(new Vector2(-1160,-64), 0.40f);
        about.DOAnchorPos(new Vector2(0,0), 0.40f);
    }
    public void Backbutton()
    {
        about.DOAnchorPos(new Vector2(1220, 0), 0.40f);
        contact.DOAnchorPos(new Vector2(1220, 0), 0.40f);
        mainmenu.DOAnchorPos(new Vector2(0, -64), 0.40f);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
