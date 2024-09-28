using UnityEngine;
using UnityEngine.UI;

public class UIComponents : MonoBehaviour
{
    // Defining Public and Private Variables
    public GameObject myGameObject;
    public GameObject myCubeModel;
    public GameObject myCylidnerModel;
    public GameObject myCapsuleModel;

    public Text myTextOutput;
    public Slider mySliderUI;
    public Dropdown myDropdownUI;

    public Material myGameObjectMaterial;
    public Color highlightColor;
    
    Vector3 startPosition;
    Color startColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = myGameObject.transform.position;
        startColor = myGameObjectMaterial.color;
        //
        myCubeModel.SetActive(true);
        myCylidnerModel.SetActive(false);
        myCapsuleModel.SetActive(false);
    }

    /* Keyboard UI Press is used inside Update() function
       https://docs.unity3d.com/ScriptReference/KeyCode.html */ 
          
    // Update is called once per frame
    void Update()
    {
        /* Check for specific Key Press actions
           can use same public functions used by button Clicks */
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveCubeUp();
            ChangeToHilightColor();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveCubeDown();
            ChangeToHilightColor();
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            ChangeToStartColor();
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            ChangeToStartColor();
        }
    }

    /* Public functions that can be assigned
       from MouseClick menu in the Inspector */
    /*** Color Property ***
       https://docs.unity3d.com/ScriptReference/Color.html */
    public void ChangeToHilightColor(){
        myGameObjectMaterial.color = highlightColor;
    }
    public void ChangeToStartColor(){
        myGameObjectMaterial.color = startColor;
    }

    /* Button UI Click Functions */
    /**** Transform GameObject Property ****
     https://docs.unity3d.com/ScriptReference/Transform.html */

    public void GrowCube(){

        // store current transform position vector3 value
        Vector3 currentScale;
        currentScale = myGameObject.transform.localScale;
        
        // create new scale vector value 15% bigger than current value
        Vector3 newScale = currentScale * 1.15f;

        // assign new scale value to gameObject transform localscale property
        myGameObject.transform.localScale = newScale;
        myTextOutput.text = "Scale : " +newScale.ToString();
    }

    public void ShrinkCube(){

        // store current transform position vector3 value
        Vector3 currentScale;
        currentScale = myGameObject.transform.localScale;
        
        // create new scale vector value 10% than current value
        Vector3 newScale = currentScale * 0.9f;

        // assign new scale value to gameObject transform localscale property
        myGameObject.transform.localScale = newScale;
        myTextOutput.text = "Scale : " +newScale.ToString();
    }

    public void MoveCubeUp(){

        // store current transform position vector3 value
        Vector3 currentPosition;
        currentPosition = myGameObject.transform.position;
        
        // create new position vector 3 value adding + 0.5 to y-component 
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + 0.5f, currentPosition.z);

        // assign to gameObject transform position property
        myGameObject.transform.position = newPosition;
        myTextOutput.text = "Position : " + newPosition.ToString();
    }

    public void MoveCubeDown(){

        // store current transform position vector3 value
        Vector3 currentPosition;
        currentPosition = myGameObject.transform.position;
        
        // create new position vector 3 value adding - 0.5 to y-component 
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y - 0.5f, currentPosition.z);

        // assign to gameObject transform position property
        myGameObject.transform.position = newPosition;
        myTextOutput.text = "Position : " + newPosition.ToString();
    }

    public void TurnCubeLeft(){

        // store current transform eulerAngle vector3 rotation value
        Vector3 currentRotation;
        currentRotation = myGameObject.transform.eulerAngles;
        
        // create new rotation vector 3 value adding 10 degrees to y-component 
        Vector3 newRotation = new Vector3(currentRotation.x, currentRotation.y + 5f, currentRotation.z);

        // assign to gameObject transform eulerAngle property
        myGameObject.transform.eulerAngles = newRotation;
        myTextOutput.text = "Rotation : " + newRotation.ToString();
    }

    public void TurnCubeRight(){

        // store current transform eulerAngle vector3 rotation value
        Vector3 currentRotation;
        currentRotation = myGameObject.transform.eulerAngles;
        
        // create new rotation vector 3 value adding -10 degrees to y-component 
        Vector3 newRotation = new Vector3(currentRotation.x, currentRotation.y - 5f, currentRotation.z);

        // assign to gameObject transform eulerAngle property
        myGameObject.transform.eulerAngles = newRotation;
        myTextOutput.text = "Rotation : " + newRotation.ToString();
    }

    /* Slider UI Functions that can be 
       assigned in the Inspector Slider component OnValueChange 
       https://docs.unity3d.com/ScriptReference/UIElements.Slider.html */

    public void SliderMovePosition(){

        // get current slider UI value [0.0 - 1.0]
        float currentSliderValue = mySliderUI.value;

        // temporary store of current position vector3 value
        Vector3 currentPosition;
        currentPosition = myGameObject.transform.position;

        /* create new position Vector3 using
           the currentSliderValue multiplied 
           by scale factor of 5              */
        Vector3 newPosition = new Vector3(startPosition.x + 5 * currentSliderValue, currentPosition.y, currentPosition.z);
        myGameObject.transform.position = newPosition;
        myTextOutput.text = "Slider : " + currentSliderValue.ToString();
    }

    /* Dropdown UI Functions that can be 
       assigned in the Inspector Dropdown component OnValueChange 
       https://docs.unity3d.com/2019.1/Documentation/ScriptReference/UI.Dropdown-value.html */

    /* Alternative is newer TMP_Dropdown
       https://docs.unity3d.com/Packages/com.unity.textmeshpro@2.0/api/TMPro.TMP_Dropdown.html */
       
    public void DropdownSelectModel(){

        // get current Dow UI value [0-2]
        float currentDropDownValue = myDropdownUI.value;
        if (currentDropDownValue == 0){
            myCubeModel.SetActive(true);
            myCylidnerModel.SetActive(false);
            myCapsuleModel.SetActive(false);
        }
        if (currentDropDownValue == 1){
            myCubeModel.SetActive(false);
            myCylidnerModel.SetActive(true);
            myCapsuleModel.SetActive(false);
        }
        if (currentDropDownValue == 2){
            myCubeModel.SetActive(false);
            myCylidnerModel.SetActive(false);
            myCapsuleModel.SetActive(true);
            
        }

    }

    
}
