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

	public void EMOCEKPLGBK()
	{
		time = 186f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("DPADVER", maxAlpha);
		}
	}

	private void ODMPMJPALID()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("skins"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void IILBHOFEMOE()
	{
		time = 1498f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("FileLabel", maxAlpha);
		}
	}

	public void NOMLFPFGFBI()
	{
		time = 697f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_Value4", maxAlpha);
		}
	}

	private void MMOKKAPFGAK()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty(": "))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void ONKFGJMKIKG(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void MECJHOJPODB()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1512f;
			num2 = ((!(base.transform.localPosition.z < 1146f)) ? (1731f * base.transform.localPosition.z + 363f) : (46f * base.transform.localPosition.z + 32f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("ticket", Mathf.Lerp(item.GetFloat(" "), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1948f));
				}
				else
				{
					item.SetFloat("value", Mathf.Lerp(item.GetFloat("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 686f));
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

	public void MOKHHEMAJBJ()
	{
		time = 1892f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("[MapsData] Bad map: ", maxAlpha);
		}
	}

	public void FKCCNAJDJJK(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void IFCCHKPJHAN(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void DOFDGBGEDFI()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("CameraFilterPack/Distortion_Dissipation"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void LGHCJCFHEMF()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				if (material.HasProperty("[Right-Left]"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void PNLBNPOGHAC(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void PKGJJFIFLII()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 440f;
			num2 = ((!(base.transform.localPosition.z < 1208f)) ? (1539f * base.transform.localPosition.z + 93f) : (410f * base.transform.localPosition.z + 1663f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("ItemNameBGImage", Mathf.Lerp(item.GetFloat(": "), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1737f));
				}
				else
				{
					item.SetFloat("CompletedLevel", Mathf.Lerp(item.GetFloat("Failed!"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 973f));
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

	public void DDLBJKMHMIH(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void GLEJGFLCLPJ()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("Type \"help\" for list of commands"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void POEMOLBJDLG()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1154f;
			num2 = ((!(base.transform.localPosition.z < 438f)) ? (913f * base.transform.localPosition.z + 188f) : (25f * base.transform.localPosition.z + 721f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Far", Mathf.Lerp(item.GetFloat(".lastCheckpoint.lives"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1877f));
				}
				else
				{
					item.SetFloat("BitsData", Mathf.Lerp(item.GetFloat("_Value4"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 180f));
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

	public void OKEGFPDAHJE(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void NFEDLAOPHML()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 507f;
			num2 = ((!(base.transform.localPosition.z < 1319f)) ? (453f * base.transform.localPosition.z + 1981f) : (695f * base.transform.localPosition.z + 1265f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("PlayerPrefs::Deserialize() parameterContent has ", Mathf.Lerp(item.GetFloat("menu.tabid"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1150f));
				}
				else
				{
					item.SetFloat("_TimeX", Mathf.Lerp(item.GetFloat("[DiscordController] Sectate ({0})"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1541f));
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

	public void EIKDCCKLGMK(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void OGNMLHBGPJH(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void MMPHNFPPEHO()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("CameraFilterPack/FX_Scan"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void JDGHMLGAJBC()
	{
		time = 850f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_Value2", maxAlpha);
		}
	}

	private void MEBPBNLBECA()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("_Value5"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void MMLMMEMFJNF(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void IBHLAJFJKBK(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void HKJDFJHLAFD(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void JEDHFJNFNFA()
	{
		time = 837f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat(":", maxAlpha);
		}
	}

	public void IGKKDBKGDDC(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void KCDOMIJBFLL()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 903f;
			num2 = ((!(base.transform.localPosition.z < 903f)) ? (1455f * base.transform.localPosition.z + 348f) : (777f * base.transform.localPosition.z + 351f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Value2", Mathf.Lerp(item.GetFloat("AccuracyScoreText"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 752f));
				}
				else
				{
					item.SetFloat("[DiscordController] Shutdown", Mathf.Lerp(item.GetFloat("_DotSize"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1247f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)6)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	private void AGEJKLMJGDO()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("_Value3"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void PDHKMDBNGGN()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("_ScreenResolution"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void KKEFCHJGDGD(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void LBIOIEANMGI()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1285f;
			num2 = ((!(base.transform.localPosition.z < 1310f)) ? (1832f * base.transform.localPosition.z + 653f) : (1360f * base.transform.localPosition.z + 328f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("[DiscordController] Error {0}: {1}", Mathf.Lerp(item.GetFloat(") but there is no recycle bin setup for it. Falling back to Instantiate"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1599f));
				}
				else
				{
					item.SetFloat("error", Mathf.Lerp(item.GetFloat("ShadersToggle"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 540f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)6)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void SetAmplValue(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
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

	public void FKKFMFPBNLC(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void JOPCCCCHNLI()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("Joystick1Button6"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void ADDOILADHMI(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void MDIFMKCNBBA(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void CNJNJGPAOGI(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void PBIGHNGAAID()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 124f;
			num2 = ((!(base.transform.localPosition.z < 1002f)) ? (266f * base.transform.localPosition.z + 968f) : (477f * base.transform.localPosition.z + 1774f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Value8", Mathf.Lerp(item.GetFloat("BitsData"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1558f));
				}
				else
				{
					item.SetFloat("_PColor2", Mathf.Lerp(item.GetFloat("Decibal"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1431f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)8)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void CCEBEGACAFJ(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void PGGPCJEOGPJ(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void KIEJKBNBHMD()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1188f;
			num2 = ((!(base.transform.localPosition.z < 1295f)) ? (49f * base.transform.localPosition.z + 66f) : (669f * base.transform.localPosition.z + 608f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat(" = ", Mathf.Lerp(item.GetFloat("_Red_C"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1971f));
				}
				else
				{
					item.SetFloat("/icon", Mathf.Lerp(item.GetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 115f));
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

	public void FEFJDOICKGP(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void LJIHHJOAJCN()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1470f;
			num2 = ((!(base.transform.localPosition.z < 1109f)) ? (390f * base.transform.localPosition.z + 1464f) : (775f * base.transform.localPosition.z + 1477f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("VHS", Mathf.Lerp(item.GetFloat("/"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 407f));
				}
				else
				{
					item.SetFloat("ICollection", Mathf.Lerp(item.GetFloat("Ev OwnershipRequest "), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1446f));
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

	public void IOOBNGFGDPA(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void APDJNPPFJIM(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void DJGBPCFHKPA(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void FABKIGNFECE()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1574f;
			num2 = ((!(base.transform.localPosition.z < 490f)) ? (1437f * base.transform.localPosition.z + 1723f) : (2f * base.transform.localPosition.z + 303f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("CameraFilterPack/Distortion_Twist", Mathf.Lerp(item.GetFloat("Edited unlock conditions"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 219f));
				}
				else
				{
					item.SetFloat("_Green_C", Mathf.Lerp(item.GetFloat("EndlessLoopsScoreText"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1549f));
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

	public void KPFDKNBLDDI(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void CAAALPKDEGL(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void HKECNOCGEDH()
	{
		time = 127f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_TimeX", maxAlpha);
		}
	}

	public void EEMIHIFBFFJ()
	{
		time = 1227f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_ScreenResolution", maxAlpha);
		}
	}

	public void Init()
	{
		time = 5f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_EmissionGain", maxAlpha);
		}
	}

	private void ONKDMMJPEMN()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 672f;
			num2 = ((!(base.transform.localPosition.z < 987f)) ? (1235f * base.transform.localPosition.z + 1079f) : (1619f * base.transform.localPosition.z + 725f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("1087340967", Mathf.Lerp(item.GetFloat("DisableStoryboardToggle"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1080f));
				}
				else
				{
					item.SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Mathf.Lerp(item.GetFloat("/"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1627f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)8)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void OJILCKLLBDB(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void JONGNKNLLND()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("(\\[ */ *h1 *\\])"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void BBGLEFNEJEK(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void IAIGNDMHFFG()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 148f;
			num2 = ((!(base.transform.localPosition.z < 1273f)) ? (712f * base.transform.localPosition.z + 1875f) : (1385f * base.transform.localPosition.z + 1536f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("EditMenu", Mathf.Lerp(item.GetFloat("SetPlayerDistance"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1586f));
				}
				else
				{
					item.SetFloat("Set Particles Emission", Mathf.Lerp(item.GetFloat("DifficultyBG"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1723f));
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

	private void CFIAKIJAILI()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1837f;
			num2 = ((!(base.transform.localPosition.z < 1805f)) ? (436f * base.transform.localPosition.z + 1755f) : (1739f * base.transform.localPosition.z + 1485f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat(". The RPC has been ignored.", Mathf.Lerp(item.GetFloat("maps."), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1589f));
				}
				else
				{
					item.SetFloat("[", Mathf.Lerp(item.GetFloat("setAF"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 238f));
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

	public void EFHCDOFBMIJ()
	{
		time = 178f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("GameVolumeSlider", maxAlpha);
		}
	}

	public void GDCNIPDIEPJ(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void IEMEHGCFAPD()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1221f;
			num2 = ((!(base.transform.localPosition.z < 1027f)) ? (932f * base.transform.localPosition.z + 15f) : (1032f * base.transform.localPosition.z + 1708f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Green_R", Mathf.Lerp(item.GetFloat("player.goldbat"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 658f));
				}
				else
				{
					item.SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", Mathf.Lerp(item.GetFloat("CameraFilterPack/Blur_Radial_Fast"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 337f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)8)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void CANIHLHGGOF()
	{
		time = 216f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_FgOverlap", maxAlpha);
		}
	}

	public void FCAOJELPFOE(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void NLICNMFBGJM(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void EPEGAEGDJAM()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("_Value"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void ANKIJGCGCBF()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1916f;
			num2 = ((!(base.transform.localPosition.z < 1752f)) ? (1279f * base.transform.localPosition.z + 152f) : (507f * base.transform.localPosition.z + 1624f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("maps.", Mathf.Lerp(item.GetFloat("#ok"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1141f));
				}
				else
				{
					item.SetFloat("b", Mathf.Lerp(item.GetFloat("Show image from resources by id at the center of the screen at foreground or background"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 150f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void PMAGMPCMGPB()
	{
		time = 1177f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("GhostSize", maxAlpha);
		}
	}

	public void NAEPCEEOAGK(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void JINGAPFINEK(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void MKKJICPMPHK()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1497f;
			num2 = ((!(base.transform.localPosition.z < 1397f)) ? (57f * base.transform.localPosition.z + 1176f) : (1344f * base.transform.localPosition.z + 674f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("EventSystem", Mathf.Lerp(item.GetFloat("_DepthLevel"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1824f));
				}
				else
				{
					item.SetFloat("_MainTex2", Mathf.Lerp(item.GetFloat("[Up]"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1131f));
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

	public void HAKMJMAFNIL()
	{
		time = 421f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat(":", maxAlpha);
		}
	}

	private void KOJKBFDNGDK()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("_Value3"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void JOACBIEHHCE()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 128f;
			num2 = ((!(base.transform.localPosition.z < 237f)) ? (685f * base.transform.localPosition.z + 1268f) : (1164f * base.transform.localPosition.z + 1069f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Value4", Mathf.Lerp(item.GetFloat("_TimeX"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 142f));
				}
				else
				{
					item.SetFloat("an hour ago", Mathf.Lerp(item.GetFloat("CameraFilterPack/Gradients_Stripe"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 775f));
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

	public void OCGJOJKJKMD()
	{
		time = 817f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("Indie", maxAlpha);
		}
	}

	private void CEDFFAOOPOG()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("colorD"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void ONMGIPAILOH()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1387f;
			num2 = ((!(base.transform.localPosition.z < 1478f)) ? (926f * base.transform.localPosition.z + 740f) : (1372f * base.transform.localPosition.z + 1776f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("player.crystal", Mathf.Lerp(item.GetFloat("_TimeX"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1329f));
				}
				else
				{
					item.SetFloat("NetworkScene", Mathf.Lerp(item.GetFloat("_Value2"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1290f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)6)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	private void BEKMLIFILFP()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("maps."))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void PAJFHGDIFLF(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void HNDNDPECBPL()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 776f;
			num2 = ((!(base.transform.localPosition.z < 799f)) ? (808f * base.transform.localPosition.z + 992f) : (387f * base.transform.localPosition.z + 680f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("/../", Mathf.Lerp(item.GetFloat("Data/Editor/leveltemplate"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1798f));
				}
				else
				{
					item.SetFloat("_TileMaxLoop", Mathf.Lerp(item.GetFloat(".completed"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 813f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)4)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void AKMHMIABECC(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void NKLIHNJCHOG()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 238f;
			num2 = ((!(base.transform.localPosition.z < 1827f)) ? (1240f * base.transform.localPosition.z + 208f) : (1878f * base.transform.localPosition.z + 1258f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("USE_CORNER_DETECTION", Mathf.Lerp(item.GetFloat("_Heigh"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1472f));
				}
				else
				{
					item.SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", Mathf.Lerp(item.GetFloat("CameraFilterPack/FX_superDot"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1187f));
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

	private void ODCJJFBJJNF()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1799f;
			num2 = ((!(base.transform.localPosition.z < 1268f)) ? (293f * base.transform.localPosition.z + 693f) : (931f * base.transform.localPosition.z + 272f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Distortion", Mathf.Lerp(item.GetFloat("DPADVER"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 134f));
				}
				else
				{
					item.SetFloat("Fade", Mathf.Lerp(item.GetFloat("_Val"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1730f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)4)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void KJBPMACBKBN(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void GGHCMPKGNGE()
	{
		time = 300f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_MainTex2", maxAlpha);
		}
	}

	public void MIAIEKCLEAO()
	{
		time = 165f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_Value", maxAlpha);
		}
	}

	public void JKHKHOIHLOI()
	{
		time = 1859f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("[CraftingPanel] Init", maxAlpha);
		}
	}

	public void HEJIGFGAIAP(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void EOPEMLDJAAO()
	{
		time = 1802f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat(" not exist", maxAlpha);
		}
	}

	public void ENIPIMLOEKM(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void CFKJHLOEDFO()
	{
		time = 424f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("0.00", maxAlpha);
		}
	}

	public void FHNPJPLGKAD(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void BGDONBMDPGM()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 202f;
			num2 = ((!(base.transform.localPosition.z < 657f)) ? (560f * base.transform.localPosition.z + 646f) : (400f * base.transform.localPosition.z + 660f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("FPSToggle", Mathf.Lerp(item.GetFloat("_FixDistance"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 45f));
				}
				else
				{
					item.SetFloat("return ", Mathf.Lerp(item.GetFloat("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1558f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	private void HPFIHLMKIPF()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("CameraFilterPack/TV_Video3D"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void GFACKFCEIBC()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 41f;
			num2 = ((!(base.transform.localPosition.z < 1783f)) ? (615f * base.transform.localPosition.z + 1508f) : (1150f * base.transform.localPosition.z + 759f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("Tonemapper curve texture", Mathf.Lerp(item.GetFloat("Tab2Content"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1337f));
				}
				else
				{
					item.SetFloat("#no", Mathf.Lerp(item.GetFloat("Crosshair"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1193f));
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

	public void GKIDCEFAIBI(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void GKENNHBFBLA()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 52f;
			num2 = ((!(base.transform.localPosition.z < 1057f)) ? (1486f * base.transform.localPosition.z + 96f) : (1956f * base.transform.localPosition.z + 1003f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("RoomPlayersCountText", Mathf.Lerp(item.GetFloat("_Value"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 798f));
				}
				else
				{
					item.SetFloat("st", Mathf.Lerp(item.GetFloat("L2"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 37f));
				}
			}
		}
		if (mode == Mode.Emission)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)8)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void BPLEDKPAPFN(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void KABKIDEDIOE()
	{
		time = 1267f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("#forever", maxAlpha);
		}
	}

	private void IKDNLHLBHID()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("player.mysteryitem"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void DKOPKPBLDHH()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("MouseX"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void EPGOJCJLBPL(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void IDIIELPAMCJ()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1912f;
			num2 = ((!(base.transform.localPosition.z < 1170f)) ? (451f * base.transform.localPosition.z + 1197f) : (1325f * base.transform.localPosition.z + 1754f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Vignetting2", Mathf.Lerp(item.GetFloat("editorVolume"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1098f));
				}
				else
				{
					item.SetFloat("challengeid", Mathf.Lerp(item.GetFloat("settings.enableranking"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1207f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)7)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void BJKCOEBIBBD()
	{
		time = 348f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("Netw. Sim.", maxAlpha);
		}
	}

	private void FIJHDKIPENG()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("UI"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void OMBOBKJBLKC()
	{
		time = 225f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("player.arrow", maxAlpha);
		}
	}

	public void CPJHNDOBFOD()
	{
		time = 346f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("MultiplayerButton", maxAlpha);
		}
	}

	private void BEBNOKFLJPH()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("CameraFilterPack/AAA_BloodOnScreen"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void JHPOIOELNCG()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 455f;
			num2 = ((!(base.transform.localPosition.z < 938f)) ? (1138f * base.transform.localPosition.z + 1863f) : (241f * base.transform.localPosition.z + 278f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("CameraFilterPack/Gradients_Therma", Mathf.Lerp(item.GetFloat("InfoCanvas"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 971f));
				}
				else
				{
					item.SetFloat("x", Mathf.Lerp(item.GetFloat("Item "), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1651f));
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

	public void EIPPDLDJJGO()
	{
		time = 417f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("Tab1Content", maxAlpha);
		}
	}

	private void IBJIBLHJKMG()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void MCKKNMDOPIL(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void SetMaxAlpha(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void EMPFACDHPCA(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void GNBCINIKMFE(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void FJNCHGLIEMA()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("#craftng"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void PMDGAMFCHCK(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void FEGJMDDIDIC()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("GenerationMenu"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void HIKKPDACJGI()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 61f;
			num2 = ((!(base.transform.localPosition.z < 1342f)) ? (352f * base.transform.localPosition.z + 178f) : (1539f * base.transform.localPosition.z + 1125f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("\\", Mathf.Lerp(item.GetFloat("/icon"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 568f));
				}
				else
				{
					item.SetFloat("SpawnObj", Mathf.Lerp(item.GetFloat("Reload Steam Inventory"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 257f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)4)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void ODFOEENHKCO()
	{
		time = 874f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("UNDISTORT", maxAlpha);
		}
	}

	private void BFGIMALGMAJ()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 425f;
			num2 = ((!(base.transform.localPosition.z < 1491f)) ? (1037f * base.transform.localPosition.z + 861f) : (1490f * base.transform.localPosition.z + 1160f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Speed", Mathf.Lerp(item.GetFloat("Received RPC \""), maxAlpha + num2 * amplValue, Time.deltaTime * time * 600f));
				}
				else
				{
					item.SetFloat("_ScreenResolution", Mathf.Lerp(item.GetFloat("cancel"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 162f));
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

	public void CGOLDBLKGGB(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void CPFOEFKOJGA()
	{
		time = 1820f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("There is already a virtual button named ", maxAlpha);
		}
	}

	public void GBLLEBPBDIA(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void NOBNCNJKOLA()
	{
		time = 158f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat(".completedMaps", maxAlpha);
		}
	}

	private void CPCDFMMLHLO()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1032f;
			num2 = ((!(base.transform.localPosition.z < 184f)) ? (139f * base.transform.localPosition.z + 461f) : (112f * base.transform.localPosition.z + 1039f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("HostType: {0} ", Mathf.Lerp(item.GetFloat("Scene"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 669f));
				}
				else
				{
					item.SetFloat("_Distortion", Mathf.Lerp(item.GetFloat("SpectateButton"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1255f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)8)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void PGKFCCIKFPK()
	{
		time = 1616f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("/C tasklist", maxAlpha);
		}
	}

	private void JBMBNKOOENB()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1366f;
			num2 = ((!(base.transform.localPosition.z < 1234f)) ? (1390f * base.transform.localPosition.z + 120f) : (1768f * base.transform.localPosition.z + 1701f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_TimeX", Mathf.Lerp(item.GetFloat("_Distortion"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 310f));
				}
				else
				{
					item.SetFloat("Set camera background color", Mathf.Lerp(item.GetFloat("_Value"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1928f));
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

	public void OOJLALHFLEG(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void MNBPNHNAEBK()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("{0:0} second{1}"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void DDKHMCOOCPA()
	{
		time = 1638f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("Malformed RPC; this should never occur. Content: ", maxAlpha);
		}
	}

	private void GPFJMKCGHGB()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1045f;
			num2 = ((!(base.transform.localPosition.z < 471f)) ? (1948f * base.transform.localPosition.z + 1463f) : (877f * base.transform.localPosition.z + 903f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Near", Mathf.Lerp(item.GetFloat(" GameServer:"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 837f));
				}
				else
				{
					item.SetFloat("Operation failed: ", Mathf.Lerp(item.GetFloat("_Value7"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 290f));
				}
			}
		}
		if (mode == Mode.ImageAlpha)
		{
			GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, maxAlpha), Time.deltaTime * time);
		}
		if (mode == (Mode)8)
		{
			GetComponent<Text>().color = Color.Lerp(GetComponent<Text>().color, new Color(GetComponent<Text>().color.r, GetComponent<Text>().color.g, GetComponent<Text>().color.b, maxAlpha), Time.deltaTime * time);
		}
	}

	public void MAKFGKIGAEA(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void DAJCLJHKECG(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	public void EHBBFMMHDGE(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void FKDCDGEIKBC(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void NNFMIAFHMJM()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				if (material.HasProperty("Tonemapper curve texture"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void GCDLIKEDMCF()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 21f;
			num2 = ((!(base.transform.localPosition.z < 602f)) ? (110f * base.transform.localPosition.z + 1889f) : (697f * base.transform.localPosition.z + 1342f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("_Value4", Mathf.Lerp(item.GetFloat("GlassDistortion"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 289f));
				}
				else
				{
					item.SetFloat("RecordButton", Mathf.Lerp(item.GetFloat("Error0"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 1166f));
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

	public void PKIJHBAIEEG(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void KPBKHFNLNBA()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1961f;
			num2 = ((!(base.transform.localPosition.z < 1980f)) ? (1348f * base.transform.localPosition.z + 124f) : (1578f * base.transform.localPosition.z + 41f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("settings.volume.sfx", Mathf.Lerp(item.GetFloat("[EditorEvent] Exception: "), maxAlpha + num2 * amplValue, Time.deltaTime * time * 1345f));
				}
				else
				{
					item.SetFloat(":\n", Mathf.Lerp(item.GetFloat("_MainTex2"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 692f));
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

	public void FNEKLACBDFL()
	{
		time = 1352f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("VeryHigh", maxAlpha);
		}
	}

	public void NIMDDCOFMCO(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void MABCDJDPGNA()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("CrosshairOpacitySlider"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	public void KGOAIGLJGCN(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
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

	public void IFGOHEOEGKH()
	{
		time = 1451f;
		foreach (Material item in OEMADMOLHHG)
		{
			item.SetFloat("_Value", maxAlpha);
		}
	}

	public void NBPIFMKNGPJ(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	private void JDGFCEPDKAJ()
	{
		if (mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2 = 1846f;
			num2 = ((!(base.transform.localPosition.z < 1123f)) ? (1056f * base.transform.localPosition.z + 1118f) : (146f * base.transform.localPosition.z + 1644f));
			foreach (Material item in OEMADMOLHHG)
			{
				if (newVersion)
				{
					item.SetFloat("\\\"", Mathf.Lerp(item.GetFloat("_MinVelocity"), maxAlpha + num2 * amplValue, Time.deltaTime * time * 145f));
				}
				else
				{
					item.SetFloat("Joystick1Button0", Mathf.Lerp(item.GetFloat("_Red_B"), num2 * (maxAlpha + amplValue), Time.deltaTime * time * 707f));
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

	public void ILBMILIDEHD(float DPNHODJHGJL)
	{
		amplValue = DPNHODJHGJL;
	}

	public void ADMLIGCEHII(float AAEBFBPJJPK)
	{
		maxAlpha = AAEBFBPJJPK;
	}

	private void HAIAHJPCPAG()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				if (material.HasProperty("_ScreenResolution"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	private void ILCFPCIPENO()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				if (material.HasProperty("_Amount"))
				{
					OEMADMOLHHG.Add(material);
				}
			}
		}
	}
}
