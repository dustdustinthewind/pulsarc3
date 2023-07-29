// EditorEvent
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EditorEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ENHFLFPPPGN
	{
		internal string EHGADNHGPNC;

		internal bool PBCAHKDLFPE(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool FFEGPHJKMFK(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool LOEAMHGMMPK(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool KFNBKFELFLH(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool DKGPCPBNDPK(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool BKNHHGBPLGH(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool DBFPGFHEGKA(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool BDGDIDPDBHG(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool LLNDDFGPOPL(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool JKEDCEOCPJO(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool EKHOOPGPPGE(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool FIPCLHEKKCA(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool OFHCGKJFGDI(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool OLIGLEMPFOP(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool AEINPAGJFME(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool LNDGINDKPFA(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool MEMPOPNAEDN(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool BFEABMIFIEE(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool GBKBDKHPLKG(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}
	}

	private bool LJBEFJHAOFL;

	[HideInInspector]
	public MapEvent mapEvent;

	public GameObject bitObj;

	public GameObject iconSprite;

	public GameObject selectedMarker;

	public Image imageRight;

	public Image imageCenter;

	[HideInInspector]
	public Vector3 scaleMult = new Vector3(1f, 1f, 1f);

	[HideInInspector]
	public int lastDataCount;

	public DragController dragController;

	[CompilerGenerated]
	private static Predicate<MapEditor.EventsCanvas> LNIJKGECNME;

	[CompilerGenerated]
	private static Predicate<MapEditor.EventsCanvas> CLCBJCKCBDD;

	[CompilerGenerated]
	private static Predicate<MapEditor.EventsCanvas> HCLEECLNOEA;

	[CompilerGenerated]
	private static Predicate<MapEditor.EventsCanvas> ADLAKIHINOM;

	public bool isSelected
	{
		get
		{
			return LJBEFJHAOFL;
		}
		set
		{
			LJBEFJHAOFL = value;
			selectedMarker.SetActive(LJBEFJHAOFL);
		}
	}

	private static bool FKLAAPLBCOH(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private static bool LDOPDBNCNHE(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private void BNIFJJAMLBE()
	{
		LOJGIJBDOON(false);
	}

	public void FOLDDNELMIO()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[1]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("_Convolved_TexelSize", new Color(1779f, 1849f, 1653f));
			GetComponentInChildren<Renderer>().material.SetColor("_ScreenResolution", new Color(1754f, 486f, 362f));
			if (mapEvent.data[0] == "0.00")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>(" ")[1];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					Debug.Log(": " + ex.Message);
				}
			}
			if (mapEvent.data[0] == "_ScreenResolution")
			{
				scaleMult.y = 1929f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("#yes", new Color(578f, 1923f, 1953f));
					GetComponentInChildren<Renderer>().material.SetColor("_FarCamera", new Color(577f, 1793f, 1139f));
				}
				catch (Exception ex2)
				{
					Debug.Log("VIGNETTE_BLUR" + ex2.Message);
				}
			}
			if (mapEvent.data[1] == "CameraFilterPack/Color_Switching")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[1];
					array[1] = 'ﾇ';
					string[] array2 = text.Split(array);
					if (array2.Length > 1)
					{
						string EHGADNHGPNC = array2[0];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(1754f, 1241f, 219f);
							imageRight.color = new Color(856f, 1763f, 1413f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("_EmissionColor" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "_Value2")
			{
				try
				{
					int num = 0;
					string text2 = mapEvent.data[1];
					char[] array3 = new char[0];
					array3[1] = '\u0001';
					num = ((text2.Split(array3).Length != 0) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(KCMFAIDMPHH)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(LBAKJBNGMNA)));
					imageCenter.sprite = Resources.LoadAll<Sprite>(" ")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("BitsData" + ex4.Message);
				}
			}
			if (mapEvent.data[1] == "Offline")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("Uploading preview image")[8];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("SfxVolumeSlider" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("_LightIntensity", new Color(438f, 362f, 531f));
			GetComponentInChildren<Renderer>().material.SetColor("CorrectHitsScoreText", new Color(463f, 1134f, 1382f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void BMJFKHIKEAJ()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("_FgCocMask", new Color(920f, 393f, 1228f));
			GetComponentInChildren<Renderer>().material.SetColor("file://", new Color(154f, 367f, 1040f));
			if (mapEvent.data[0] == "_TimeX")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[0]);
					imageRight.sprite = Resources.LoadAll<Sprite>("_AccumulationTex")[1];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					Debug.Log("Can not SetMasterClient(). Not in room or in offlineMode." + ex.Message);
				}
			}
			if (mapEvent.data[0] == "LevelConfigButton")
			{
				scaleMult.y = 1817f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("_Red_G", new Color(238f, 582f, 1441f));
					GetComponentInChildren<Renderer>().material.SetColor("yes", new Color(1428f, 573f, 594f));
				}
				catch (Exception ex2)
				{
					Debug.Log("maxScore" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "2hands")
			{
				try
				{
					string text = mapEvent.data[1];
					char[] array = new char[1];
					array[1] = 'ﾭ';
					string[] array2 = text.Split(array);
					if (array2.Length > 0)
					{
						string EHGADNHGPNC = array2[1];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(1385f, 1400f, 302f);
							imageRight.color = new Color(86f, 1582f, 574f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("_TimeX" + ex3.Message);
				}
			}
			if (mapEvent.data[0] == "inventory.itemscash")
			{
				try
				{
					int num = 1;
					string text2 = mapEvent.data[1];
					char[] array3 = new char[0];
					array3[0] = 'ﾉ';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find((string IACGDFHKCAE) => IACGDFHKCAE.Contains(mapEvent.data[1].Split(',')[0]))) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(CPPLPBFAIBO)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("_TimeX")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("\"" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "CameraFilterPack_Glasses_On6")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack/Blur_GaussianBlur")[3];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("_Cible" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("_TimeX", new Color(1838f, 555f, 1311f));
			GetComponentInChildren<Renderer>().material.SetColor(".", new Color(1801f, 1536f, 389f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	[SpecialName]
	public bool GFMIFIOKKGJ()
	{
		return LJBEFJHAOFL;
	}

	private bool AOBLNJDMLLK(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[1] = '\ufff4';
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	[SpecialName]
	public bool FBCONJMBJMH()
	{
		return LJBEFJHAOFL;
	}

	public void PCDCKOJLIJC()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 814f)
		{
			mapEvent.time = 1867f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = HFNPJDMIFCL();
		base.transform.localPosition = localPosition;
	}

	private static bool BDABIDDODJC(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private float HFNPJDMIFCL()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[1] != null)
		{
			if (mapEvent.data[1] == "_Offsets")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(KIPPBGFAFLD).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[1])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(NECGDADKKFM).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(HINDGEPGJOF).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(LJOOLGKAAHB).grid.position.y;
	}

	private static bool HECJFKFFMGB(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private static bool CIBIJBBLJNH(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private float OOEPFAOEBHB()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[1] != null)
		{
			if (mapEvent.data[1] == "/icon")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(KGDBIEJPJNK).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[1])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Gameplay).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(KCNPDDGNAEK).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(CIBIJBBLJNH).grid.position.y;
	}

	public void CKLFGILMMDL()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[1]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("_ProjInfo", new Color(1544f, 1083f, 1948f));
			GetComponentInChildren<Renderer>().material.SetColor("[Down]", new Color(1094f, 1934f, 215f));
			if (mapEvent.data[1] == "_Color")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("CameraFilterPack/3D_Myst")[1];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("Set particles audio input" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "StartButton")
			{
				scaleMult.y = 381f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("_Intensity", new Color(1701f, 1397f, 1588f));
					GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(1263f, 1157f, 11f));
				}
				catch (Exception ex2)
				{
					Debug.Log("_ColorB" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "SaveButton")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[0];
					array[0] = 'ﾵ';
					string[] array2 = text.Split(array);
					if (array2.Length > 1)
					{
						string EHGADNHGPNC = array2[1];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(211f, 1107f, 777f);
							imageRight.color = new Color(1805f, 387f, 221f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("settings_bindings_" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "CameraFilterPack/Color_Sepia")
			{
				try
				{
					int num = 0;
					string text2 = mapEvent.data[1];
					char[] array3 = new char[0];
					array3[1] = '5';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(OKMGILHPEHB)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(LBAKJBNGMNA)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("/icon")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("_Value4" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "_Value4")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Value1")[3];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("table" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("EventSystem", new Color(1769f, 379f, 1356f));
			GetComponentInChildren<Renderer>().material.SetColor("EditMenu", new Color(88f, 1225f, 1399f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	private static bool ADHOMACBAMM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private static bool OAEOHOFMJEJ(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool ACFEOHCIDLJ(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private void ELJPNLNELIE()
	{
		PIPHIBLIIKK(true);
	}

	private static bool NLKEBCFDNHP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	[SpecialName]
	public void FDJEEBJHHKK(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	private void IOMCHHBGJEC()
	{
		isSelected = true;
	}

	private static bool KCNPDDGNAEK(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private void Awake()
	{
		isSelected = false;
	}

	private void CHJFFPOBNLO()
	{
		LOJGIJBDOON(true);
	}

	private static bool HBMEMAGJILM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void KFACDBHDAOD()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1102f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 179f, Camera.main.orthographicSize / 409f, 1819f);
		}
	}

	public void UpdatePositionFromData()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 0f)
		{
			mapEvent.time = 0f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = IHNJPGPOEIP();
		base.transform.localPosition = localPosition;
	}

	public void EABEPBGOBNE()
	{
		LOJGIJBDOON(true);
		BNMJMGDKKJB();
	}

	public void EKAHIBEHDLJ()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(false);
		if (!string.IsNullOrEmpty(mapEvent.data[1]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("LoadingStatusText", new Color(1271f, 1708f, 1781f));
			GetComponentInChildren<Renderer>().material.SetColor(".sav", new Color(961f, 1352f, 684f));
			if (mapEvent.data[1] == "#")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("_Value2")[1];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					Debug.Log("Failed to 'network-remove' GameObject because has no PhotonView components: " + ex.Message);
				}
			}
			if (mapEvent.data[1] == "_Value3")
			{
				scaleMult.y = 280f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("Item invalid. Make sure your mod contains at leats one file.", new Color(1310f, 499f, 302f));
					GetComponentInChildren<Renderer>().material.SetColor("Fade", new Color(1698f, 1445f, 1070f));
				}
				catch (Exception ex2)
				{
					Debug.Log("SpawnObj" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "\" gets executed locally only, if at all.")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[1];
					array[1] = '\v';
					string[] array2 = text.Split(array);
					if (array2.Length > 0)
					{
						string EHGADNHGPNC = array2[0];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(314f, 1270f, 836f);
							imageRight.color = new Color(1887f, 1953f, 779f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("_DiffuseColor" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "IDInputField")
			{
				try
				{
					int num = 1;
					string text2 = mapEvent.data[0];
					char[] array3 = new char[0];
					array3[1] = '|';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FKGMEANLBAH)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(LBAKJBNGMNA)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("Bad modpack name: {0}")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log(": " + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "max. lives color")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Amount")[2];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("Tab1Content" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("yesterday", new Color(767f, 1735f, 1886f));
			GetComponentInChildren<Renderer>().material.SetColor("_Near", new Color(752f, 1672f, 23f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void GALGJEHEANF()
	{
		FDJEEBJHHKK(false);
		UpdateIcon();
	}

	public void LGGNBDOMKDB()
	{
		isSelected = false;
		IPCHIGBJADH();
	}

	private float PJDMHCLLMBA()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[1] != null)
		{
			if (mapEvent.data[1] == "_TimeX")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(NKEHDGMHHFM).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[1])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Gameplay).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(KCNPDDGNAEK).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(FKLAAPLBCOH).grid.position.y;
	}

	public void EJFJENFKLND()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 592f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 169f, Camera.main.orthographicSize / 1301f, 1705f);
		}
	}

	[SpecialName]
	public void JDAGBCICMFI(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	[SpecialName]
	public bool FBLJPPGABFE()
	{
		return LJBEFJHAOFL;
	}

	private static bool PJBHBHOHDJP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool CBFJPDLECDL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	[SpecialName]
	public bool PCCODBJODEB()
	{
		return LJBEFJHAOFL;
	}

	public void GNKLLIABLOP()
	{
		JDAGBCICMFI(false);
		BLEHBLOLPMF();
	}

	public void LOGIAPEMAPN()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("_ReflectionTexture4", new Color(1825f, 1635f, 1856f));
			GetComponentInChildren<Renderer>().material.SetColor("_Parameter", new Color(1973f, 689f, 384f));
			if (mapEvent.data[0] == "Error: I/O Failure! :(")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("Square")[1];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					Debug.Log("\\\\" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "Blues")
			{
				scaleMult.y = 205f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("MusicFileSelector", new Color(1561f, 577f, 134f));
					GetComponentInChildren<Renderer>().material.SetColor("z", new Color(980f, 1339f, 551f));
				}
				catch (Exception ex2)
				{
					Debug.Log("_SunPosition" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "player.dragon")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[0];
					array[0] = '\u0004';
					string[] array2 = text.Split(array);
					if (array2.Length > 1)
					{
						string EHGADNHGPNC = array2[1];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(214f, 689f, 110f);
							imageRight.color = new Color(737f, 1514f, 190f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("hidden" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "UI")
			{
				try
				{
					int num = 0;
					string text2 = mapEvent.data[0];
					char[] array3 = new char[0];
					array3[0] = 'ﾾ';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FKGMEANLBAH)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(CPPLPBFAIBO)));
					imageCenter.sprite = Resources.LoadAll<Sprite>(" ")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex4)
				{
					Debug.Log(".wav" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "/../")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("Overlay")[7];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("MenuScene" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("_Value", new Color(1092f, 1585f, 1695f));
			GetComponentInChildren<Renderer>().material.SetColor("Joystick1Button12", new Color(571f, 599f, 970f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	[SpecialName]
	public bool FKGGINLFGFB()
	{
		return LJBEFJHAOFL;
	}

	private bool CPPLPBFAIBO(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[0]);
	}

	public void CGENHBKEDPP()
	{
		JDAGBCICMFI(true);
		BLEHBLOLPMF();
	}

	private bool FAHBEMJCDEE(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[0]);
	}

	public void LBBKFNOPLNL()
	{
		LOJGIJBDOON(false);
		IPCHIGBJADH();
	}

	public void BLEHBLOLPMF()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(false);
		imageRight.gameObject.SetActive(false);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("Tab1Content", new Color(765f, 271f, 1967f));
			GetComponentInChildren<Renderer>().material.SetColor("ShowTitle", new Color(1913f, 138f, 1021f));
			if (mapEvent.data[1] == "challenges.")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("MenuScene")[1];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("icon.png" + ex.Message);
				}
			}
			if (mapEvent.data[0] == "SetParticlesEmission")
			{
				scaleMult.y = 120f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("ViewMenu", new Color(982f, 1258f, 257f));
					GetComponentInChildren<Renderer>().material.SetColor("float,50", new Color(1973f, 1454f, 194f));
				}
				catch (Exception ex2)
				{
					Debug.Log("_ScreenResolution" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "_BlendTex")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[0];
					array[1] = 'ￃ';
					string[] array2 = text.Split(array);
					if (array2.Length > 1)
					{
						string EHGADNHGPNC = array2[0];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(1986f, 123f, 1512f);
							imageRight.color = new Color(1723f, 453f, 829f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("https://www.youtube.com/watch?v=cDVXukrKo74" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!")
			{
				try
				{
					int num = 0;
					string text2 = mapEvent.data[1];
					char[] array3 = new char[0];
					array3[0] = 'ﾽ';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FKGMEANLBAH)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find((string IACGDFHKCAE) => IACGDFHKCAE.Contains(mapEvent.data[1]))));
					imageCenter.sprite = Resources.LoadAll<Sprite>("Operation failed: ")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("Player Disconnected" + ex4.Message);
				}
			}
			if (mapEvent.data[1] == "x")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_LensDirtIntensity")[8];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("SaveButton" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", new Color(561f, 710f, 1453f));
			GetComponentInChildren<Renderer>().material.SetColor("Error: Timeout :S", new Color(366f, 810f, 1632f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void OGJBKJLBJMM()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 898f)
		{
			mapEvent.time = 128f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = GHIPKDEKGOE();
		base.transform.localPosition = localPosition;
	}

	public void BDOOHFMNDLN()
	{
		JEGEONIHCLO(false);
		UpdateIcon();
	}

	private void MMPPGDECEHO()
	{
		isSelected = true;
	}

	public void PMNFFFDHBHB()
	{
		FDJEEBJHHKK(true);
		IOMBILLPGCF();
	}

	public void NNAIANPHNHA()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(false);
		imageRight.gameObject.SetActive(false);
		imageCenter.gameObject.SetActive(false);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("Edited unlock conditions", new Color(1236f, 1337f, 1986f));
			GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(1252f, 1717f, 594f));
			if (mapEvent.data[0] == "Backward")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("Submit")[1];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("_TimeX" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "_MainTex2")
			{
				scaleMult.y = 750f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("checkpoint", new Color(1933f, 1960f, 1046f));
					GetComponentInChildren<Renderer>().material.SetColor("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", new Color(1120f, 593f, 971f));
				}
				catch (Exception ex2)
				{
					Debug.Log("The image effect " + ex2.Message);
				}
			}
			if (mapEvent.data[1] == "tolobby")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[0];
					array[0] = 'ﾷ';
					string[] array2 = text.Split(array);
					if (array2.Length > 0)
					{
						string EHGADNHGPNC = array2[0];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(888f, 403f, 1250f);
							imageRight.color = new Color(383f, 1270f, 1431f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log(": " + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "OK")
			{
				try
				{
					int num = 0;
					string text2 = mapEvent.data[0];
					char[] array3 = new char[0];
					array3[0] = 'T';
					num = ((text2.Split(array3).Length != 0) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FKGMEANLBAH)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(HACELNPOIAB)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("_EmissionColor")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("_Distortion" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "settings.enableselectormusic")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Value")[1];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("System.Single" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("{0:0} day{1}, ", new Color(1847f, 1788f, 1069f));
			GetComponentInChildren<Renderer>().material.SetColor("R:", new Color(1966f, 306f, 429f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	[CompilerGenerated]
	private bool BKKMOPKHAIE(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1]);
	}

	public void BLJDBBOAKPD()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("menu.selectedlevelid", new Color(59f, 1691f, 491f));
			GetComponentInChildren<Renderer>().material.SetColor("_BorderSize", new Color(1154f, 238f, 1904f));
			if (mapEvent.data[0] == "_Value2")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("powerup.1")[0];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("http://steamcommunity.com/sharedfiles/filedetails/?id=" + ex.Message);
				}
			}
			if (mapEvent.data[0] == "event")
			{
				scaleMult.y = 647f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("#FFFFFF", new Color(270f, 1047f, 1630f));
					GetComponentInChildren<Renderer>().material.SetColor("UnityEngine.MonoBehaviour", new Color(943f, 1474f, 1512f));
				}
				catch (Exception ex2)
				{
					Debug.Log("DPADHOR" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "note.7")
			{
				try
				{
					string text = mapEvent.data[1];
					char[] array = new char[1];
					array[1] = '[';
					string[] array2 = text.Split(array);
					if (array2.Length > 1)
					{
						string EHGADNHGPNC = array2[0];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(155f, 968f, 1524f);
							imageRight.color = new Color(230f, 1716f, 967f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("Players NetIDs:" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "checkpoint")
			{
				try
				{
					int num = 0;
					string text2 = mapEvent.data[1];
					char[] array3 = new char[1];
					array3[1] = '\u0017';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(DONNMFALNII)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(LBAKJBNGMNA)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("Texture2")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex4)
				{
					Debug.Log("Hidden/TonemappingColorGrading" + ex4.Message);
				}
			}
			if (mapEvent.data[1] == " not exist")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("File not found: {0}")[4];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("[PlayerBase] New highscore" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("Joystick1Button5", new Color(607f, 1571f, 1775f));
			GetComponentInChildren<Renderer>().material.SetColor("_TimeX", new Color(1656f, 1835f, 1440f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	private float LIJCAFBLLHE()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[0] != null)
		{
			if (mapEvent.data[1] == "hardcoreinfo")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Gameplay).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[0])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(AOAJGFLCENI).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(ACFEOHCIDLJ).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(FKLAAPLBCOH).grid.position.y;
	}

	[SpecialName]
	public bool EHCABBEEKPI()
	{
		return LJBEFJHAOFL;
	}

	private static bool BJMPJJEJPHG(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private bool KCMFAIDMPHH(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[1] = 'G';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	private static bool LEKOLAMPLOF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void CNMNCEDLKJA()
	{
		FDJEEBJHHKK(true);
		NNAIANPHNHA();
	}

	[CompilerGenerated]
	private static bool NGHEMEHKJIG(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool KCFHBHFBNJD(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void JJKDHIKCPFC()
	{
		JDAGBCICMFI(true);
		BMJFKHIKEAJ();
	}

	private bool OFECECCNHDI(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[0] = 'ﾾ';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	public void EOEDBFHBPEI()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip != null)
		{
			MICGBLDONHE();
			mapEvent.time = base.transform.localPosition.x;
			BLEHBLOLPMF();
			LMADKINICIN();
		}
	}

	[CompilerGenerated]
	private static bool MJOAAPFDHNH(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void BNMJMGDKKJB()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(false);
		imageRight.gameObject.SetActive(false);
		imageCenter.gameObject.SetActive(false);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("CameraFilterPack/Vision_Blood_Fast", new Color(1192f, 1863f, 654f));
			GetComponentInChildren<Renderer>().material.SetColor("_ScreenResolution", new Color(136f, 1656f, 230f));
			if (mapEvent.data[1] == "status")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("[LevelEditorScene] Error: You're not logged into Steam!")[1];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("OK" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "no lives color")
			{
				scaleMult.y = 199f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("id", new Color(1381f, 694f, 748f));
					GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(16f, 1322f, 1974f));
				}
				catch (Exception ex2)
				{
					Debug.Log("/" + ex2.Message);
				}
			}
			if (mapEvent.data[1] == "SetRoomStartTimestamp")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[1];
					array[1] = '2';
					string[] array2 = text.Split(array);
					if (array2.Length > 1)
					{
						string EHGADNHGPNC = array2[0];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(967f, 1150f, 1440f);
							imageRight.color = new Color(603f, 847f, 1319f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("_TimeX" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "_TimeX")
			{
				try
				{
					int num = 0;
					string text2 = mapEvent.data[0];
					char[] array3 = new char[0];
					array3[1] = '\ufff3';
					num = ((text2.Split(array3).Length != 0) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FKGMEANLBAH)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(GCBPJAGKJJK)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("[PlayerBase] Highscore: ")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("_MainTex2" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "offsets")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("/files/editor_manual.pdf")[5];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("DPADVER" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("_Visualize", new Color(295f, 1497f, 1693f));
			GetComponentInChildren<Renderer>().material.SetColor("SetSatelliteTrailLength", new Color(96f, 1773f, 796f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void LMADKINICIN()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 354f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 368f, Camera.main.orthographicSize / 237f, 1597f);
		}
	}

	[SpecialName]
	public void PIPHIBLIIKK(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	private static bool PNCGCLEFJLG(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool AOAJGFLCENI(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void MICGBLDONHE()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 129f)
		{
			mapEvent.time = 102f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = NLCBCEGGCCJ();
		base.transform.localPosition = localPosition;
	}

	private static bool NHJBOJNOBKI(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private float GHIPKDEKGOE()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[0] != null)
		{
			if (mapEvent.data[0] == "https://vk.com/khb.soft")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(FIHAFJBCDHL).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[1])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(AOAJGFLCENI).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(HINDGEPGJOF).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(LJOOLGKAAHB).grid.position.y;
	}

	private static bool IBDNAGJKBGM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private bool OKMGILHPEHB(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[0] = 'ￗ';
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	private static bool NKEHDGMHHFM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private void JPJNECPABBG()
	{
		FDJEEBJHHKK(false);
	}

	public void KMEONPMCNJG()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1912f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 85f, Camera.main.orthographicSize / 116f, 328f);
		}
	}

	public void UpdateIcon()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(false);
		imageRight.gameObject.SetActive(false);
		imageCenter.gameObject.SetActive(false);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("_Color", new Color(0f, 1f, 0f));
			GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", new Color(0f, 1f, 0f));
			if (mapEvent.data[0] == "SetBGColor")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("LevelEditor/icons")[0];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("[EditorEvent] Exception: " + ex.Message);
				}
			}
			if (mapEvent.data[0] == "checkpoint")
			{
				scaleMult.y = 2.5f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("_Color", new Color(1f, 1f, 0f));
					GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", new Color(1f, 1f, 0f));
				}
				catch (Exception ex2)
				{
					Debug.Log("[EditorEvent] Exception: " + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "ShowSprite")
			{
				try
				{
					string[] array = mapEvent.data[1].Split(',');
					if (array.Length > 0)
					{
						string EHGADNHGPNC = array[0];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(1f, 0f, 1f);
							imageRight.color = new Color(1f, 0f, 1f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("[EditorEvent] Exception: " + ex3.Message);
				}
			}
			if (mapEvent.data[0] == "SpawnObj")
			{
				try
				{
					int num = 0;
					num = ((mapEvent.data[1].Split(',').Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find((string IACGDFHKCAE) => IACGDFHKCAE.Contains(mapEvent.data[1].Split(',')[0]))) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find((string IACGDFHKCAE) => IACGDFHKCAE.Contains(mapEvent.data[1]))));
					imageCenter.sprite = Resources.LoadAll<Sprite>("LevelEditor/patterns")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("[EditorEvent] Exception: " + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "ShowTitle")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("LevelEditor/icons")[2];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("[EditorEvent] Exception: " + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("_DiffuseColor", new Color(1f, 0f, 0f));
			GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", new Color(1f, 0f, 0f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void BLDIAHCMHLB()
	{
		FDJEEBJHHKK(true);
		CKLFGILMMDL();
	}

	public void NCMDCMHLIKD()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip != null)
		{
			JDJGKBGFDIG();
			mapEvent.time = base.transform.localPosition.x;
			BNMJMGDKKJB();
			HIKKPDACJGI();
		}
	}

	private void DEJEBOGKMJO()
	{
		LOJGIJBDOON(false);
	}

	[CompilerGenerated]
	private static bool DJKGOFFKGMF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private bool DONNMFALNII(string IACGDFHKCAE)
	{
		string text = mapEvent.data[1];
		char[] array = new char[0];
		array[0] = '|';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	private bool HACELNPOIAB(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[0]);
	}

	public void KGMMJGDGEMA()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 657f)
		{
			mapEvent.time = 847f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = LIJCAFBLLHE();
		base.transform.localPosition = localPosition;
	}

	public void IPCHIGBJADH()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("_Value", new Color(1009f, 343f, 1793f));
			GetComponentInChildren<Renderer>().material.SetColor("CrosshairOpacitySlider", new Color(111f, 1319f, 1695f));
			if (mapEvent.data[0] == "NO")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[0]);
					imageRight.sprite = Resources.LoadAll<Sprite>(" Owner called.")[0];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					Debug.Log("_ScreenResolution" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "_TimeX")
			{
				scaleMult.y = 543f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("yyyy-MM-dd HH:mm:ss", new Color(1699f, 312f, 1958f));
					GetComponentInChildren<Renderer>().material.SetColor("_ColorBuffer", new Color(795f, 1297f, 1958f));
				}
				catch (Exception ex2)
				{
					Debug.Log("Server: {0}. Region: {1} " + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "GlassesColor")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[0];
					array[0] = '\uffdd';
					string[] array2 = text.Split(array);
					if (array2.Length > 0)
					{
						string EHGADNHGPNC = array2[1];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(605f, 546f, 1239f);
							imageRight.color = new Color(1963f, 734f, 1530f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("Tab2Content" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == " This is not possible to be called for standalone input. Please check your platform and code where this is called")
			{
				try
				{
					int num = 1;
					string text2 = mapEvent.data[1];
					char[] array3 = new char[1];
					array3[1] = 'ﾡ';
					num = ((text2.Split(array3).Length != 0) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(OKMGILHPEHB)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FAHBEMJCDEE)));
					imageCenter.sprite = Resources.LoadAll<Sprite>(" This is not possible to be called for standalone input. Please check your platform and code where this is called")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex4)
				{
					Debug.Log("End Value should be greater than the start value, values not changed" + ex4.Message);
				}
			}
			if (mapEvent.data[1] == "Item ")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack_Paper1")[6];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("_Value3" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("/Segment-[Up]", new Color(1079f, 1426f, 138f));
			GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(1136f, 1342f, 1701f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	[SpecialName]
	public bool NMINPJFAKLI()
	{
		return LJBEFJHAOFL;
	}

	public void HIKKPDACJGI()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 812f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 32f, Camera.main.orthographicSize / 1223f, 303f);
		}
	}

	public void DKECJIFHOLC()
	{
		JDAGBCICMFI(false);
		DBDONHCIOKN();
	}

	public void EDDMJJKACKK()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 449f)
		{
			mapEvent.time = 343f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = NLCBCEGGCCJ();
		base.transform.localPosition = localPosition;
	}

	private static bool KIPPBGFAFLD(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private static bool KGDBIEJPJNK(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void ENJFIKOILDG()
	{
		JDAGBCICMFI(false);
		FOLDDNELMIO();
	}

	[SpecialName]
	public void LOJGIJBDOON(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	public void DBDONHCIOKN()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(false);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(false);
		if (!string.IsNullOrEmpty(mapEvent.data[1]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("_TimeX", new Color(162f, 1778f, 930f));
			GetComponentInChildren<Renderer>().material.SetColor("FinalScoreText", new Color(344f, 1607f, 1961f));
			if (mapEvent.data[1] == "ItemsCountText")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("FrostCanvas")[1];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("DPADVER" + ex.Message);
				}
			}
			if (mapEvent.data[0] == "an hour ago")
			{
				scaleMult.y = 1218f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("ChallengesButton", new Color(6f, 720f, 1353f));
					GetComponentInChildren<Renderer>().material.SetColor("CameraFilterPack/FX_Hypno", new Color(375f, 1293f, 1375f));
				}
				catch (Exception ex2)
				{
					Debug.Log("LevelNameInputField" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "Oct")
			{
				try
				{
					string[] array = mapEvent.data[0].Split('ￚ');
					if (array.Length > 0)
					{
						string EHGADNHGPNC = array[1];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(60f, 1062f, 1320f);
							imageRight.color = new Color(1748f, 1644f, 908f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("player.xp" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?")
			{
				try
				{
					int num = 1;
					string text = mapEvent.data[0];
					char[] array2 = new char[0];
					array2[1] = '\a';
					num = ((text.Split(array2).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(DONNMFALNII)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(HACELNPOIAB)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("[ItemsHandler] Inventory has changed")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("\n" + ex4.Message);
				}
			}
			if (mapEvent.data[1] == "Left Stick Click")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_ScreenResolution")[1];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("RarityImage" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("EVENT CONFIG [Ctrl+E]", new Color(560f, 1174f, 1027f));
			GetComponentInChildren<Renderer>().material.SetColor("Keeping GameObject in the scene: ", new Color(1949f, 1604f, 894f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void LIJCLLBPBIP()
	{
		PIPHIBLIIKK(true);
		BNAOMEIEBMK();
	}

	private float GMKHJPPNECM()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[0] != null)
		{
			if (mapEvent.data[0] == "_TimeX")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(ADHOMACBAMM).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[1])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(BDABIDDODJC).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(ACFEOHCIDLJ).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(LEKOLAMPLOF).grid.position.y;
	}

	private static bool NECGDADKKFM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void UpdateEvent()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip != null)
		{
			UpdatePositionFromData();
			mapEvent.time = base.transform.localPosition.x;
			UpdateIcon();
			Update();
		}
	}

	public void FMGBIHDGKBI()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip != null)
		{
			PCDCKOJLIJC();
			mapEvent.time = base.transform.localPosition.x;
			BLEHBLOLPMF();
			EJFJENFKLND();
		}
	}

	public void BNAOMEIEBMK()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[1]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("ready", new Color(84f, 1388f, 855f));
			GetComponentInChildren<Renderer>().material.SetColor("score", new Color(688f, 579f, 987f));
			if (mapEvent.data[0] == "23x3")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[0]);
					imageRight.sprite = Resources.LoadAll<Sprite>("Fade")[0];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("_TimeX" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "\\")
			{
				scaleMult.y = 1229f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("_Visualize", new Color(621f, 416f, 442f));
					GetComponentInChildren<Renderer>().material.SetColor("note.4", new Color(945f, 10f, 189f));
				}
				catch (Exception ex2)
				{
					Debug.Log("_Far" + ex2.Message);
				}
			}
			if (mapEvent.data[1] == "Couldn't color correct with 3D LUT texture. Image Effect will be disabled.")
			{
				try
				{
					string text = mapEvent.data[1];
					char[] array = new char[1];
					array[1] = '\ufff1';
					string[] array2 = text.Split(array);
					if (array2.Length > 0)
					{
						string EHGADNHGPNC = array2[1];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(1277f, 945f, 1428f);
							imageRight.color = new Color(1326f, 542f, 1418f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("\n\n#" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "z")
			{
				try
				{
					int num = 1;
					string text2 = mapEvent.data[0];
					char[] array3 = new char[0];
					array3[0] = '\0';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(KCMFAIDMPHH)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FAHBEMJCDEE)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("_Threshhold")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex4)
				{
					Debug.Log("1 Kb" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "_Smooth")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("workshop.")[6];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("turn: {0:0}" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("Ev OwnershipRequest ", new Color(1543f, 1322f, 516f));
			GetComponentInChildren<Renderer>().material.SetColor("Failed to 'network-remove' GameObject because has no PhotonView components: ", new Color(2f, 1618f, 258f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void BMDLFFBAGML()
	{
		PIPHIBLIIKK(true);
		BLEHBLOLPMF();
	}

	public void Update()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 30f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 5f, Camera.main.orthographicSize / 5f, 1f);
		}
	}

	private static bool AHDLNGNKIFL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private static bool EIPJAJIIMBF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void KJJODHJJEOH()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip != null)
		{
			MICGBLDONHE();
			mapEvent.time = base.transform.localPosition.x;
			EKAHIBEHDLJ();
			NFEDLAOPHML();
		}
	}

	private static bool CMCEKKEFBEK(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private void MADENBGHKDD()
	{
		PIPHIBLIIKK(false);
	}

	public void NJDJHMPAIFE()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip != null)
		{
			PCDCKOJLIJC();
			mapEvent.time = base.transform.localPosition.x;
			IPCHIGBJADH();
			ABFNJCEBIKA();
		}
	}

	private float NLCBCEGGCCJ()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[1] != null)
		{
			if (mapEvent.data[0] == "_AdaptationSpeed")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(LDOPDBNCNHE).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[0])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(KCFHBHFBNJD).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(HBMEMAGJILM).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(EIPJAJIIMBF).grid.position.y;
	}

	private static bool EFFAFHGGOFM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private bool GCBPJAGKJJK(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1]);
	}

	[SpecialName]
	public bool BOAIDAOGAIB()
	{
		return LJBEFJHAOFL;
	}

	public void JODDNKKOFKL()
	{
		PIPHIBLIIKK(false);
		BNMJMGDKKJB();
	}

	[CompilerGenerated]
	private static bool CLOOIEFPKIA(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void NFEDLAOPHML()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 180f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 187f, Camera.main.orthographicSize / 1771f, 840f);
		}
	}

	public void HCIPECAOGIA()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1617f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 661f, Camera.main.orthographicSize / 1717f, 1084f);
		}
	}

	private float KKKHINEICAC()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[0] != null)
		{
			if (mapEvent.data[0] == "_Value4")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(KGDBIEJPJNK).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[1])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(AOAJGFLCENI).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(AHDLNGNKIFL).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(EFFAFHGGOFM).grid.position.y;
	}

	private static bool MBNDBFNGHOP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void ABFNJCEBIKA()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 284f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 322f, Camera.main.orthographicSize / 1934f, 385f);
		}
	}

	public void EGEGNHLODAA()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1403f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1062f, Camera.main.orthographicSize / 658f, 909f);
		}
	}

	[SpecialName]
	public void JEGEONIHCLO(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	private bool LBAKJBNGMNA(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[0]);
	}

	private void GEGFJJBCHPE()
	{
		LOJGIJBDOON(true);
	}

	private static bool JNJBPLDKODP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void NJHHCCGEACF()
	{
		PIPHIBLIIKK(false);
		IPCHIGBJADH();
	}

	private float IHNJPGPOEIP()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[0] != null)
		{
			if (mapEvent.data[0] == "checkpoint")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Gameplay).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[0])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Gameplay).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Storyboard).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Storyboard).grid.position.y;
	}

	public void IOMBILLPGCF()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("shader.crispwinter", new Color(851f, 1167f, 1436f));
			GetComponentInChildren<Renderer>().material.SetColor("_Far", new Color(1386f, 679f, 1870f));
			if (mapEvent.data[0] == "_TimeX")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("mapselector.tags.")[0];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					Debug.Log("{0:0} second{1}" + ex.Message);
				}
			}
			if (mapEvent.data[0] == "\\\"")
			{
				scaleMult.y = 1322f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("Object ID. Case-Sensitive", new Color(1271f, 695f, 430f));
					GetComponentInChildren<Renderer>().material.SetColor("player.gamecompleted", new Color(1899f, 201f, 3f));
				}
				catch (Exception ex2)
				{
					Debug.Log("_Distance" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "_Value")
			{
				try
				{
					string[] array = mapEvent.data[0].Split('\u0010');
					if (array.Length > 1)
					{
						string EHGADNHGPNC = array[0];
						imageRight.color = Color.white;
						if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists((MapResource IACGDFHKCAE) => IACGDFHKCAE.name == EHGADNHGPNC))
						{
							imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[EHGADNHGPNC];
						}
						else
						{
							imageRight.sprite = null;
							imageRight.color = new Color(688f, 1835f, 14f);
							imageRight.color = new Color(1017f, 1277f, 1357f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("_BlendTex" + ex3.Message);
				}
			}
			if (mapEvent.data[0] == "IntraSig")
			{
				try
				{
					int num = 0;
					string text = mapEvent.data[0];
					char[] array2 = new char[1];
					array2[1] = 'A';
					num = ((text.Split(array2).Length != 0) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(OKMGILHPEHB)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FAHBEMJCDEE)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("ItemTemplate")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex4)
				{
					Debug.Log("Edited event" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "InventoryContent")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("\n")[3];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("<b>#" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("#onrankchangeuptext", new Color(251f, 883f, 1279f));
			GetComponentInChildren<Renderer>().material.SetColor("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", new Color(1401f, 58f, 365f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	private static bool LJOOLGKAAHB(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	[CompilerGenerated]
	private bool BMJDNECLLIG(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1].Split(',')[0]);
	}

	public void JDJGKBGFDIG()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 1253f)
		{
			mapEvent.time = 66f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = NLCBCEGGCCJ();
		base.transform.localPosition = localPosition;
	}

	private bool FKGMEANLBAH(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[1] = '1';
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	public void LEBDGMBCDMO()
	{
		JEGEONIHCLO(true);
		BMJFKHIKEAJ();
	}

	public void Deselect()
	{
		isSelected = false;
		UpdateIcon();
	}

	public void NOGJICCANOG()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 1893f)
		{
			mapEvent.time = 704f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = KKKHINEICAC();
		base.transform.localPosition = localPosition;
	}

	public void GPFJMKCGHGB()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 661f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1866f, Camera.main.orthographicSize / 449f, 1778f);
		}
	}

	public void FCPPLPPLKIP()
	{
		LOJGIJBDOON(true);
		IPCHIGBJADH();
	}

	private static bool FIHAFJBCDHL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private float CILCHIMNABB()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[1] != null)
		{
			if (mapEvent.data[0] == "Load Game")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(NLKEBCFDNHP).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[0])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(BJMPJJEJPHG).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(HBMEMAGJILM).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(FKLAAPLBCOH).grid.position.y;
	}

	private static bool HINDGEPGJOF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void Select()
	{
		isSelected = true;
		UpdateIcon();
	}

	private static bool PNJINGIAKFM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	[SpecialName]
	public bool NEOIOPKJAFI()
	{
		return LJBEFJHAOFL;
	}
}
