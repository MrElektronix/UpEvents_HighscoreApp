using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class Controller : MonoBehaviour {
    public SocketIOComponent socket;


    private void Start()
    {
        StartCoroutine(ConnectToServer());
    }

    IEnumerator ConnectToServer()
    {
        yield return new WaitForSeconds(0.1f);
        Dictionary<string, string> data = new Dictionary<string, string>();
        data["Event"] = "Zombies";
        data["Gamemode"] = "pepernoten";
        data["Score"] = "3000";
        socket.Emit("addData", new JSONObject(data));
    }
}
