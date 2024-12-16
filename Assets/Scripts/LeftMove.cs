using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class LeftMove: MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   bool isPressed = false;
   public GameObject player;
   public float Force;

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            player.transform.Translate(Force * Time.deltaTime, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
