using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public int index;
    [SerializeField] bool keyDown;
    public int maxIndex;
    public string axis;

    private void Update()
    {
        if (axis == "Vertical")
        {
            if (Input.GetAxis(axis) != 0)
            {
                if (!keyDown)
                {
                    if (Input.GetAxis(axis) < 0)
                    {
                        if (index < maxIndex)
                        {
                            index++;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                    else if (Input.GetAxis(axis) > 0)
                    {
                        if (index > 0)
                        {
                            index--;
                        }
                        else
                        {
                            index = maxIndex;
                        }
                    }
                    keyDown = true;
                }
            }
            else
            {
                keyDown = false;
            }
        }
        else if(axis == "Horizontal")
        {
            if (Input.GetAxis(axis) != 0)
            {
                if (!keyDown)
                {
                    if (Input.GetAxis(axis) < 0)
                    {
                        if (index > 0)
                        {
                            index--;
                        }
                        else
                        {
                            index = maxIndex;
                        }
                    }
                    else if (Input.GetAxis(axis) > 0)
                    {
                        if (index < maxIndex)
                        {
                            index++;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                    keyDown = true;
                }
            }
            else
            {
                keyDown = false;
            }
        }
    }
}
