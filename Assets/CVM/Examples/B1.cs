using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

public class B1 : MonoBehaviour {

    public UnityEngine.UI.Text Text;
    public TextAsset cs_cs;
	// Use this for initialization
	void Start () {
        try
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            string text = cs_cs.text;

            var env = CVM.CSharpEnv.Create("fyindex.dll");
            var app= env.DoString(text);
            app.Invoke("a111.cvm","Start", null, new object[] { });

            stopwatch.Stop();

            UnityEngine.Debug.Log("need->"+stopwatch.Elapsed);
        }
        catch(System.Exception e)
        {
            if (Text != null)
            {
                Text.text =e.ToString() ;
            }
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
