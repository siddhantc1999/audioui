using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class panaromicview : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Vector3 startposition;
    public Vector3 newposition;
    public Vector3 move;
    public float movex;
    public float movey;
    [SerializeField] GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(1))
        //{
        //    if (EventSystem.current.IsPointerOverGameObject())
        //    {
        //        Debug.Log("pointer over gameobejct");
        //    }

        //}

    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("on drag "+ Input.mousePosition);
         move = Input.mousePosition - startposition;
        movex = move.x * Time.deltaTime;
        Debug.Log("the mvoe y"+movey);
        if (Mathf.Abs(move.y) > 20f)
        {
            movey = move.y;
        }
        sphere.transform.Rotate(movey * Time.deltaTime, move.x * Time.deltaTime, 0f);
        sphere.transform.eulerAngles=new Vector3(sphere.transform.eulerAngles.x, sphere.transform.eulerAngles.y,0f);
        



    }
    public void OnEndDrag(PointerEventData eventData)
    {
        move = Vector3.zero;
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        startposition = Input.mousePosition;
    }
   
}

