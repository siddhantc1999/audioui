using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonid:MonoBehaviour
{
  
    public scenemanager.nextcanvas mynextcanvas;
    public scenemanager.soundname mysoundtype;


    public void nextcanvas()
    {

        foreach (var name in scenemanager.nextcanvas.GetNames(mynextcanvas.GetType()))
        {
            if (name == mynextcanvas.ToString())
            {
         
                scenemanager.instance.findvideo(name);
            }
        }
    }
    public void theaudio()
    {

        foreach (var name in scenemanager.soundname.GetNames(mysoundtype.GetType()))
        {
            if (name == mysoundtype.ToString())
            {

                scenemanager.instance.findaudio(name);
            }
        }
    }


}
