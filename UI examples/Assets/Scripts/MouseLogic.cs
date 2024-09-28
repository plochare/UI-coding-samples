using UnityEngine;

public class MouseLogic : MonoBehaviour
{
    public GameObject myGameObject;

    public Material cubeMaterial;
    public Color rolloverColor;
    public Color normalColor;

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
        cubeMaterial.color = rolloverColor;
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
        cubeMaterial.color = normalColor;
    }

    void OnMouseDown()
    {
        ShrinkCube();
    }

    public void ShrinkCube(){

        // store current transform position vector3 value
        Vector3 currentScale;
        currentScale = myGameObject.transform.localScale;
        
        // create new scale vector value 10% than current value
        Vector3 newScale = currentScale * 0.9f;

        // assign new scale value to gameObject transform localscale property
        myGameObject.transform.localScale = newScale;
    }

}
