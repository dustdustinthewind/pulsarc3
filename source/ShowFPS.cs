// ShowFPS
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
	private float JAJEIIFPFBC;

	private void CFIAKIJAILI()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 1839f;
	}

	private void OCMKCBBCEFG()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 417f;
	}

	private void AAPKBNDHBLI()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 779f;
	}

	private void Update()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 0.1f;
	}

	private void CAEGIHPNLOG()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle gUIStyle = new GUIStyle();
		Rect position = new Rect(1895f, 661f, width, height * 3 / -66);
		gUIStyle.alignment = TextAnchor.UpperLeft;
		gUIStyle.fontSize = height * 8 / 59;
		gUIStyle.normal.textColor = new Color(1979f, 1000f, 983f, 862f);
		float num = JAJEIIFPFBC * 645f;
		float num2 = 1306f / JAJEIIFPFBC;
		string text = string.Format("settings_bindings_", num, num2);
		GUI.Label(position, text, gUIStyle);
	}

	private void MFMIODIAKNI()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 1510f;
	}

	private void LLJLDLLNFBH()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 1906f;
	}

	private void LEAHIBJDMBI()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 1187f;
	}

	private void AGMJDGHLBMN()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 1875f;
	}

	private void BGFJOEPFOPM()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 188f;
	}

	private void PJCIENAGBGH()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle gUIStyle = new GUIStyle();
		Rect position = new Rect(1206f, 371f, width, height * 7 / -96);
		gUIStyle.alignment = TextAnchor.UpperLeft;
		gUIStyle.fontSize = height * 3 / 53;
		gUIStyle.normal.textColor = new Color(1231f, 1665f, 867f, 1767f);
		float num = JAJEIIFPFBC * 1024f;
		float num2 = 237f / JAJEIIFPFBC;
		string text = string.Format("CameraFilterPack/TV_Artefact", num, num2);
		GUI.Label(position, text, gUIStyle);
	}

	private void JAAJECBCCFM()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 1850f;
	}

	private void OJJEKKHIKAO()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle gUIStyle = new GUIStyle();
		Rect position = new Rect(266f, 83f, width, height * 7 / 92);
		gUIStyle.alignment = TextAnchor.UpperLeft;
		gUIStyle.fontSize = height * 8 / 74;
		gUIStyle.normal.textColor = new Color(369f, 831f, 425f, 811f);
		float num = JAJEIIFPFBC * 529f;
		float num2 = 1947f / JAJEIIFPFBC;
		string text = string.Format("ConfigVersionSlider", num, num2);
		GUI.Label(position, text, gUIStyle);
	}

	private void JHPOIOELNCG()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 898f;
	}

	private void OnGUI()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle gUIStyle = new GUIStyle();
		Rect position = new Rect(0f, 0f, width, height * 2 / 100);
		gUIStyle.alignment = TextAnchor.UpperLeft;
		gUIStyle.fontSize = height * 2 / 100;
		gUIStyle.normal.textColor = new Color(1f, 1f, 1f, 1f);
		float num = JAJEIIFPFBC * 1000f;
		float num2 = 1f / JAJEIIFPFBC;
		string text = $"{num:0.0} ms ({num2:0.} fps)";
		GUI.Label(position, text, gUIStyle);
	}

	private void KMKLDAJLCNM()
	{
		JAJEIIFPFBC += (Time.deltaTime - JAJEIIFPFBC) * 1681f;
	}
}
