using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class buttonuimanager : MonoBehaviour
{

    public Sprite pausesprite;
    public Sprite playsprite;
    public Sprite volumeonsprite;
    public Sprite volumeoffsprite;
    public VideoPlayer currentvideo;
    public Canvas currentcanvas;
    public double currentvideolength;
    public double currentvideotime;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //we will have to pass both the reference the videosource and play pause
    public void playpause(GameObject gameobject)
    {

       
        if (currentvideo.isPlaying)
        {
            currentvideo.Pause();
            gameobject.GetComponent<Image>().sprite = pausesprite;


        }
        else
        {
            currentvideo.Play();
            gameobject.GetComponent<Image>().sprite = playsprite;
        }
    }
    public void fastforward()
    {
        currentvideo.time += 10f;
    }
    public void rewind()
    {
        currentvideo.time -= 10f;
    }
    public void muteunmute(GameObject gameobject)
    {
       
        if (currentvideo.GetDirectAudioMute(0)==false)
        {
            currentvideo.SetDirectAudioMute(0, true);
            gameobject.GetComponent<Image>().sprite = volumeoffsprite;
        }
        else
        {
            currentvideo.SetDirectAudioMute(0, false);
            gameobject.GetComponent<Image>().sprite = volumeonsprite;
        }
    }

   
    public void playbackspeed()
    {
        if (currentvideo.playbackSpeed == 1f)
        {
            currentvideo.playbackSpeed = 2f;
        }
        else
        if(currentvideo.playbackSpeed == 2f)
        {
            currentvideo.playbackSpeed = 1f;
        }
    }


}
