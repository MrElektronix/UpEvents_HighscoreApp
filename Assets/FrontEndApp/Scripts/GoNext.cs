using UnityEngine;
using UnityEngine.UI;


public class GoNext : MonoBehaviour
{
    public InputField inputField;
    private string _input_text;
    public GameObject button;

    private void Start()
    {
        inputField = gameObject.GetComponent<InputField>();
        button.SetActive(false);
    }

    private void Update()
    {
        _input_text = inputField.text;
        if (_input_text == "" || int.Parse(_input_text) > 60 || int.Parse(_input_text) < 0 || _input_text[0] == 0)
        {
            button.SetActive(false);
        }
        else
        {
            if (_input_text[0].ToString() == "0")
            {
                Debug.Log("nooo");
                button.SetActive(false);
            }
            else
            {
                Debug.Log("yesss");
                button.SetActive(true);
            }
        }
    }
}