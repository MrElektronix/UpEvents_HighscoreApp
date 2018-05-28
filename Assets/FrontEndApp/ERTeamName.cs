using UnityEngine;
using UnityEngine.UI;


public class ERTeamName : MonoBehaviour
{
    public InputField TeamNameInput;
    private string _tNameDataEscapeRoom;
    public GameObject button;

    private void Start()
    {
        TeamNameInput = gameObject.GetComponent<InputField>();
        button.SetActive(false);
    }

    private void Update()
    {
        _tNameDataEscapeRoom = TeamNameInput.text;
        PlayerPrefs.SetString("EscapeRoomTeamName", _tNameDataEscapeRoom);
        if (TeamNameInput.text == "")
        {
            button.SetActive(false);
        }
        else
        {
            button.SetActive(true);
        }
    }
}