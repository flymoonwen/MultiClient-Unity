using UnityEngine;
using System.Collections;


public class CubeNet : MonoBehaviour {

    public JFSocket mJFsocket;

    private ByteBuffer byteBuffer;

    // Use this for initialization
    void Start()
    {
        mJFsocket = JFSocket.GetInstance();

        this.byteBuffer = ByteBuffer.Allocate(1024);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 200, 20), "click_"))
        {
            //JFPackage.WorldPackage _p = new JFPackage.WorldPackage(127, 12, 10001, System.Text.Encoding.UTF8.GetBytes(""));
            //mJFsocket.SendMessage(_p);

            this.byteBuffer.WriteInt(1);
            this.byteBuffer.WriteInt(1001);
            this.byteBuffer.WriteString("click");
            this.byteBuffer.WriteInt(3);

            mJFsocket.SendMessage(this.byteBuffer.ToArray());

        }

    }
}
