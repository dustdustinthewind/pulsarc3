// IncreseAlpha
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreseAlpha : MonoBehaviour
{
	public bool newVersion;

	public Mode mode;

	public float time = 0.4f;

	public float maxAlpha = 1f;

	public float amplValue = 1.75f;

	private List<Material> OEMADMOLHHG = new List<Material>();

	public void DFDGNOCPJEJ(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void JBCNIPJDPJB()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 825f;
			num2 = ((!(base.transform.localPosition.z < 1477f)) ? (190f * base.transform.localPosition.z + 1166f) : (1365f * base.transform.localPosition.z + 427f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", Mathf.Lerp(item.GetFloat("Set camera background color"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 816f));
				}
				else
				{
					item.SetFloat("masterSteamID", Mathf.Lerp(item.GetFloat("Set sun directionVector - in which direction sun will grow on beat"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 325f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)3)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void EMOCEKPLGBK()
	{
		time = 946f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("[LevelEditorScene] Error: Timeout :S", maxAlpha);
		}
	}

	private void LMBDNPLDGIJ()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1093f;
			num2 = ((!(base.transform.localPosition.z < 1995f)) ? (691f * base.transform.localPosition.z + 1651f) : (1968f * base.transform.localPosition.z + 1357f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("Set particles color", Mathf.Lerp(item.GetFloat("Editor/"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 231f));
				}
				else
				{
					item.SetFloat("_Value7", Mathf.Lerp(item.GetFloat("PhotonView with ID "), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 24f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void PNDICCKBLCB(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void CFKJHLOEDFO()
	{
		time = 887f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", maxAlpha);
		}
	}

	public void DDLBJKMHMIH(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void BGDONBMDPGM()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 692f;
			num2 = ((!(base.transform.localPosition.z < 745f)) ? (856f * base.transform.localPosition.z + 617f) : (1641f * base.transform.localPosition.z + 747f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("[LevelEditorScene] Reloaded config for \"", Mathf.Lerp(item.GetFloat("Gameplay/LobbyPlayerIconElement"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1374f));
				}
				else
				{
					item.SetFloat("original.tutorial", Mathf.Lerp(item.GetFloat("score"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 701f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)5)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void SetAmplValue(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void OFKCJAPIDPJ(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void FKCCNAJDJJK(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void CGOLDBLKGGB(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void DDALBJCCLPB(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void EJLKPLOEEEP()
	{
		time = 1358f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("failed", maxAlpha);
		}
	}

	public void PMLGEEDJMDO(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void LCKKDMKJJEF()
	{
		time = 733f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("SaveButton", maxAlpha);
		}
	}

	private void GHILDCBCDJI()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 814f;
			num2 = ((!(base.transform.localPosition.z < 1271f)) ? (1479f * base.transform.localPosition.z + 669f) : (1265f * base.transform.localPosition.z + 677f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("shader.frost", Mathf.Lerp(item.GetFloat("RarityImage"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 273f));
				}
				else
				{
					item.SetFloat(". Using max value: 255.", Mathf.Lerp(item.GetFloat("-1"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1042f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)3)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	private void PAKPHKPDKGE()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("Use ticket: "))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void JGNOEIINHMF(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void MCKADBKLPCB(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void JPDDIAHAFKC(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void CDKCKJPPIHO(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void Update()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 0f;
			num2 = ((!(base.transform.localPosition.z < 0f)) ? (-1f / 13f * base.transform.localPosition.z + 1f) : (1f / 13f * base.transform.localPosition.z + 1f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_EmissionGain", Mathf.Lerp(item.GetFloat("_EmissionGain"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 4f));
				}
				else
				{
					item.SetFloat("_EmissionGain", Mathf.Lerp(item.GetFloat("_EmissionGain"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 4f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == Mode.TextAlpha)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void OJLGCMDKELK(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void EPEGAEGDJAM()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("EditMenu"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void CKJCPBPMBFF()
	{
		time = 1701f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("&page=", maxAlpha);
		}
	}

	public void HLBCLHNDNKF(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void OCMKCBBCEFG()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1236f;
			num2 = ((!(base.transform.localPosition.z < 1531f)) ? (1039f * base.transform.localPosition.z + 41f) : (1244f * base.transform.localPosition.z + 1218f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("^", Mathf.Lerp(item.GetFloat("CameraFilterPack/TV_WideScreenCircle"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 375f));
				}
				else
				{
					item.SetFloat("CameraFilterPack/TV_Chromatical2", Mathf.Lerp(item.GetFloat("maxScore"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 265f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void MMFNIDPPELO(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void Init()
	{
		time = 5f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_EmissionGain", maxAlpha);
		}
	}

	public void CBNKLCNADAG(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void MPBKLEANBBA(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void CFIAKIJAILI()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1868f;
			num2 = ((!(base.transform.localPosition.z < 170f)) ? (924f * base.transform.localPosition.z + 1943f) : (231f * base.transform.localPosition.z + 732f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("maphash", Mathf.Lerp(item.GetFloat("_MainTex2"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 814f));
				}
				else
				{
					item.SetFloat("id", Mathf.Lerp(item.GetFloat("note.4"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1822f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)5)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void MDIFMKCNBBA(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void PJILLPKFCPO()
	{
		time = 1148f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat(" not exist", maxAlpha);
		}
	}

	public void FMOPCDHGMMK(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void MFPOGPELLOB(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void NKLIHNJCHOG()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 318f;
			num2 = ((!(base.transform.localPosition.z < 853f)) ? (1369f * base.transform.localPosition.z + 32f) : (1179f * base.transform.localPosition.z + 803f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Red_G", Mathf.Lerp(item.GetFloat("_DiffuseColor"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 479f));
				}
				else
				{
					item.SetFloat("mapselector.filter.subscribedonly", Mathf.Lerp(item.GetFloat("<color=#"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1147f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)5)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void HBKEHHCMMBN()
	{
		time = 1178f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("Best region found in PlayerPrefs. Connecting to: ", maxAlpha);
		}
	}

	public void PIEPPKMBJHI()
	{
		time = 1724f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("UseScanLineSize", maxAlpha);
		}
	}

	public void EKOAKKNGGGI()
	{
		time = 28f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("Object ID. Case-Sensitive", maxAlpha);
		}
	}

	private void FEHCNJLLJMP()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty(":\n"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void FIMJABKECNG()
	{
		time = 1196f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("#onfirstranktext", maxAlpha);
		}
	}

	public void OECCKNFPEJK(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void NFKMIOJGFMM(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void KFACDBHDAOD()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1589f;
			num2 = ((!(base.transform.localPosition.z < 1368f)) ? (787f * base.transform.localPosition.z + 621f) : (1389f * base.transform.localPosition.z + 943f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("maps.", Mathf.Lerp(item.GetFloat("_Value2"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1248f));
				}
				else
				{
					item.SetFloat("/", Mathf.Lerp(item.GetFloat("_FarCamera"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1197f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)5)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void EPAJHKHCMHJ(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void GBLLEBPBDIA(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void LICADKMAFCD(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void Start()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("_EmissionGain"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void CCLNNLCOPBL()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("_TileMaxLoop"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void FMNPFCHBLJF()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("CameraFilterPack_Atmosphere_Rain_FX"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void AHNBCMOPCBI(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void NPLBOOJODHD(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void DLAFGJIIKFB(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void JNBPKNNBMDI()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 298f;
			num2 = ((!(base.transform.localPosition.z < 1430f)) ? (630f * base.transform.localPosition.z + 1135f) : (766f * base.transform.localPosition.z + 1453f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("stretchWidth", Mathf.Lerp(item.GetFloat("_TimeX"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1798f));
				}
				else
				{
					item.SetFloat("_TimeX", Mathf.Lerp(item.GetFloat("_Red_C"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1150f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)7)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	private void IBHACCEEFFI()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1654f;
			num2 = ((!(base.transform.localPosition.z < 377f)) ? (1284f * base.transform.localPosition.z + 424f) : (192f * base.transform.localPosition.z + 928f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("settings.selectormapsperpage", Mathf.Lerp(item.GetFloat("_PColor"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1821f));
				}
				else
				{
					item.SetFloat("DPADVER", Mathf.Lerp(item.GetFloat("0.00:0.00"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 215f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)5)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	private void MJEFMIPLFAB()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("_Speed"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void GPNAOAKCMHC()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				if (material.HasProperty("warning: Audio Source: "))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void DAHFFNNIGML()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("id"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void IEAMGJHEGMA(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void SetMaxAlpha(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void NPIOMADKGPP(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void BAAPHBKJKLI(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void FKKFMFPBNLC(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void BBGLEFNEJEK(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void BMODOIJGIOO()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 553f;
			num2 = ((!(base.transform.localPosition.z < 314f)) ? (1594f * base.transform.localPosition.z + 1453f) : (153f * base.transform.localPosition.z + 65f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Overlay", Mathf.Lerp(item.GetFloat("_Value4"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 76f));
				}
				else
				{
					item.SetFloat("RedoButton", Mathf.Lerp(item.GetFloat(".played"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1822f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == Mode.TextAlpha)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void CAJFKNFJEKC()
	{
		time = 1292f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("RoomDescriptionText", maxAlpha);
		}
	}

	public void KKIEHCHNLDF(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void MECJHOJPODB()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1143f;
			num2 = ((!(base.transform.localPosition.z < 305f)) ? (486f * base.transform.localPosition.z + 382f) : (138f * base.transform.localPosition.z + 1058f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("LevelConfigButton", Mathf.Lerp(item.GetFloat("#FFFFFF"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1397f));
				}
				else
				{
					item.SetFloat("EventMenu", Mathf.Lerp(item.GetFloat("checkpoint"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 440f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)3)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void PFNDFPNPBOJ(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void FBNGAIJDBNK(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void GDJMBJEAPHM()
	{
		time = 1237f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("CameraFilterPack/Color_BrightContrastSaturation", maxAlpha);
		}
	}

	public void NANHBKPOAFJ(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void GHPKJJKDONI(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void LCGMHCBNCDM()
	{
		time = 327f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_Value3", maxAlpha);
		}
	}

	public void LILOGPDPFDA()
	{
		time = 1679f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("CameraFilterPack/TV_Videoflip", maxAlpha);
		}
	}

	private void KDMKDEKCELE()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("uploads/Intralism/mods_terms.pdf"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void HDMDKOKOOJC()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("_SearchTex"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void OPKEHMPGGDG(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void LIBGAKMKHJJ()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				if (material.HasProperty(": "))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void LONEFLJPJKM(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void LLAHPNGMEOO()
	{
		time = 1553f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("UI Extensions/UIMultiply", maxAlpha);
		}
	}

	private void KIMMMCJFMAB()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("_ScreenResolution"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void NJACHGLHMFO(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}
}
