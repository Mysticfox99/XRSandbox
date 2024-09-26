using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalsReplacementShader : MonoBehaviour
{
    public Shader normalsShader;
    public Camera mainCamera;
    public int depth = 24;

    private RenderTexture renderTexture;
    private new Camera camera;

    void Start()
    {
        //Creates a render texture matching the main camera's current dimensions
        renderTexture = new RenderTexture(mainCamera.pixelWidth, mainCamera.pixelHeight, depth);
        //Surface the render texture as a global variable - makes it available to all shaders
        Shader.SetGlobalTexture("_CameraNormalsTexture", renderTexture);

        //Setup a copy of the main camera using normals shader
        GameObject copyCamera = new GameObject("Normals Camera");
        camera = copyCamera.AddComponent<Camera>();
        camera.CopyFrom(mainCamera);
        camera.transform.SetParent(transform);
        camera.targetTexture = renderTexture;
        camera.SetReplacementShader(normalsShader, "RenderType");
        camera.depth = mainCamera.depth - 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
