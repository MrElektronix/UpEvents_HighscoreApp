using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldReq : MonoBehaviour
{

	[SerializeField] private InputField _nameField;
	[SerializeField] private InputField _teamField;
	[SerializeField] private InputField _emailField;

	void Start(){
		_teamField.characterLimit = 10;
		_teamField.contentType = InputField.ContentType.Alphanumeric;
		_emailField.contentType = InputField.ContentType.EmailAddress;
		_nameField.contentType = InputField.ContentType.Name;
	}
}