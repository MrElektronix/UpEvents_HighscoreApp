using UnityEngine;
using UnityEngine.UI;


public class ERTeamName : MonoBehaviour
{
    public InputField TeamNameInput;
    private string _tNameDataEscapeRoom;
    public GameObject button;
    public GameObject toggleButton;

    private void Start()
    {
        TeamNameInput = gameObject.GetComponent<InputField>();
    }

    private void Update()
    {
        _tNameDataEscapeRoom = TeamNameInput.text;
        PlayerPrefs.SetString("EscapeRoomTeamName", _tNameDataEscapeRoom);
        if (TeamNameInput.text == "" || toggleButton.GetComponent<Toggle>().isOn == false)
        {
            button.SetActive(false);
        }
        else if (TeamNameInput.text != "" && toggleButton.GetComponent<Toggle>().isOn == true)
        {
            button.SetActive(true);
        }
    }
}