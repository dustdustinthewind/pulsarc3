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

		internal bool BKNHHGBPLGH(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool LLNDDFGPOPL(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool GBKBDKHPLKG(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool MEMPOPNAEDN(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool DBFPGFHEGKA(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool LOEAMHGMMPK(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool BDGDIDPDBHG(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool AEINPAGJFME(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool KFNBKFELFLH(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool LNDGINDKPFA(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool PBCAHKDLFPE(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == EHGADNHGPNC;
		}

		internal bool JKEDCEOCPJO(MapResource IACGDFHKCAE)
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

	private static bool MICOIKOLKFC(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool NCALDGPEJCK(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private static bool EAGEEGBCNFD(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool GALCPMGJDGC(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private bool BBDFHOKCDPG(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[1];
		array[1] = 'ﾓ';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	private bool EEIGDBBFLEM(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[0].Split('ﾒ')[0]);
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

	private void Awake()
	{
		isSelected = false;
	}

	public void IOCMKABIBOC()
	{
		BKEDJGGEIGB(true);
		GKKAJOHEJCG();
	}

	private void NLNAJMCBNDC()
	{
		MFEPCILLECI(true);
	}

	public void CNDHFHFNCOM()
	{
		BCLLPELLKKP(true);
		KDHAMIJPEIO();
	}

	public void Deselect()
	{
		isSelected = false;
		UpdateIcon();
	}

	public void PFONHMPKABG()
	{
		AJHMKMAHDFK(false);
		MLNPNMLBKHI();
	}

	public void PBEPCAPAKLG()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 887f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 245f, Camera.main.orthographicSize / 1058f, 1765f);
		}
	}

	private static bool CAJOHGJJBDL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool EBNNEAENKPE(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool KPCNFNPFPJB(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void EKAGILPDBCN()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(false);
		imageRight.gameObject.SetActive(false);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[1]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("_Bullet_4", new Color(1927f, 1360f, 999f));
			GetComponentInChildren<Renderer>().material.SetColor("_Brightness", new Color(1395f, 320f, 796f));
			if (mapEvent.data[0] == "/")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[0]);
					imageRight.sprite = Resources.LoadAll<Sprite>("InfoText")[0];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					Debug.Log("[MapsData] Workshop maps was loaded" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "settings.cameramovements")
			{
				scaleMult.y = 190f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("_TileMaxLoop", new Color(483f, 705f, 1457f));
					GetComponentInChildren<Renderer>().material.SetColor("[Left]", new Color(657f, 462f, 773f));
				}
				catch (Exception ex2)
				{
					Debug.Log("_LowRez" + ex2.Message);
				}
			}
			if (mapEvent.data[0] == "(\\[ *i *\\])")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[1];
					array[1] = ',';
					string[] array2 = text.Split(array);
					if (array2.Length > 1)
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
							imageRight.color = new Color(92f, 829f, 1088f);
							imageRight.color = new Color(852f, 254f, 1224f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("offsets" + ex3.Message);
				}
			}
			if (mapEvent.data[0] == "_FarCamera")
			{
				try
				{
					int num = 1;
					string text2 = mapEvent.data[0];
					char[] array3 = new char[0];
					array3[0] = '%';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(OMOANNOIJLO)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FNIJFIJGOON)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("float,50")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex4)
				{
					Debug.Log("_TimeX" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "PlayMusic")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("#C8C8C8FF")[5];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("," + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("[LevelEditorScene] Error: You're not logged into Steam!", new Color(1435f, 209f, 1329f));
			GetComponentInChildren<Renderer>().material.SetColor("Pop", new Color(1996f, 1493f, 1795f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	private bool OMOANNOIJLO(string IACGDFHKCAE)
	{
		string text = mapEvent.data[1];
		char[] array = new char[1];
		array[1] = 'k';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	private static bool JGMIOGIPLKI(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void DODLGMDOEOJ()
	{
		isSelected = true;
		GKKAJOHEJCG();
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

	private static bool DIHILOHGBAM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	[SpecialName]
	public void DKHEBPFKBCI(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	public void HKEDNOKBCCG()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(false);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("ItemTemplate", new Color(1887f, 1513f, 1544f));
			GetComponentInChildren<Renderer>().material.SetColor("_VignetteDesat", new Color(1238f, 1044f, 1140f));
			if (mapEvent.data[0] == "CameraFilterPack/OldFilm_Cutting1")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("value")[0];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("_Value2" + ex.Message);
				}
			}
			if (mapEvent.data[0] == "ConfigVersionSlider")
			{
				scaleMult.y = 827f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("https://bitbucket.org/khb-soft/intralismarcsviewer/", new Color(1252f, 1264f, 1373f));
					GetComponentInChildren<Renderer>().material.SetColor("CameraFilterPack/Blend2Camera_Blend", new Color(949f, 1515f, 1996f));
				}
				catch (Exception ex2)
				{
					Debug.Log("_Alpha2" + ex2.Message);
				}
			}
			if (mapEvent.data[1] == "_Value")
			{
				try
				{
					string text = mapEvent.data[1];
					char[] array = new char[0];
					array[0] = ':';
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
							imageRight.color = new Color(693f, 1046f, 865f);
							imageRight.color = new Color(744f, 316f, 347f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("restrictions" + ex3.Message);
				}
			}
			if (mapEvent.data[0] == "[Up-Right-Left]")
			{
				try
				{
					int num = 1;
					string text2 = mapEvent.data[1];
					char[] array3 = new char[0];
					array3[1] = '\r';
					num = ((text2.Split(array3).Length != 0) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(MDFEGPFDONL)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FNIJFIJGOON)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("Hex value #RRGGBB")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex4)
				{
					Debug.Log("BitsData" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "Object ID. Case-Sensitive")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack/Noise_TV_2")[2];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("_CenterY" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("CameraFilterPack/Blend2Camera_Darken", new Color(1605f, 1180f, 1147f));
			GetComponentInChildren<Renderer>().material.SetColor("inventory.itemscash", new Color(1809f, 793f, 871f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void GKKAJOHEJCG()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(false);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(false);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", new Color(1810f, 1784f, 249f));
			GetComponentInChildren<Renderer>().material.SetColor("0.00", new Color(835f, 284f, 1475f));
			if (mapEvent.data[0] == "getbool")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[0]);
					imageRight.sprite = Resources.LoadAll<Sprite>("Illegal view ID:")[1];
					imageRight.color = color;
					iconSprite.SetActive(true);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("x" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "_Amount")
			{
				scaleMult.y = 1934f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("NO", new Color(979f, 502f, 819f));
					GetComponentInChildren<Renderer>().material.SetColor("SupportLogger Info: PUN {0}: ", new Color(1583f, 143f, 670f));
				}
				catch (Exception ex2)
				{
					Debug.Log("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(" + ex2.Message);
				}
			}
			if (mapEvent.data[1] == "\n")
			{
				try
				{
					string[] array = mapEvent.data[1].Split('\uffdf');
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
							imageRight.color = new Color(1928f, 366f, 1264f);
							imageRight.color = new Color(933f, 1863f, 456f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("SetParticlesGravity" + ex3.Message);
				}
			}
			if (mapEvent.data[1] == "finished")
			{
				try
				{
					int num = 0;
					string text = mapEvent.data[0];
					char[] array2 = new char[0];
					array2[0] = 'ￌ';
					num = ((text.Split(array2).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(CHJGMEEPGMM)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(APAFIDOEJBA)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("[PlayerController] ")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("https://bitbucket.org/khb-soft/intralismarcsviewer/" + ex4.Message);
				}
			}
			if (mapEvent.data[1] == ".progress")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("st")[4];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("settings.arcsnohitsoundtimedelay" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("OK", new Color(1796f, 1634f, 405f));
			GetComponentInChildren<Renderer>().material.SetColor("SaveButton", new Color(302f, 1117f, 1120f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void KFCKGCCNGNI()
	{
		BKEDJGGEIGB(true);
		EKAGILPDBCN();
	}

	public void BEMGANLFMJJ()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(false);
		imageCenter.gameObject.SetActive(true);
		if (!string.IsNullOrEmpty(mapEvent.data[1]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("Run a command for data system", new Color(1672f, 981f, 1576f));
			GetComponentInChildren<Renderer>().material.SetColor("checkpoint", new Color(897f, 87f, 515f));
			if (mapEvent.data[0] == "randomdrop")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("[Right]")[1];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("CameraFilterPack/3D_Computer" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "CameraFilterPack/Distortion_ShockWaveManual")
			{
				scaleMult.y = 144f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("finished", new Color(304f, 1427f, 804f));
					GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(432f, 1916f, 402f));
				}
				catch (Exception ex2)
				{
					Debug.Log(" - LOCAL" + ex2.Message);
				}
			}
			if (mapEvent.data[1] == "_ScreenResolution")
			{
				try
				{
					string text = mapEvent.data[1];
					char[] array = new char[0];
					array[0] = '4';
					string[] array2 = text.Split(array);
					if (array2.Length > 1)
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
							imageRight.color = new Color(1492f, 180f, 1960f);
							imageRight.color = new Color(1248f, 1398f, 1782f);
						}
						iconSprite.SetActive(true);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("mapselector.filter.favoriteonly" + ex3.Message);
				}
			}
			if (mapEvent.data[0] == ": ")
			{
				try
				{
					int num = 0;
					num = ((mapEvent.data[1].Split('b').Length != 0) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(EEIGDBBFLEM)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(APAFIDOEJBA)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("#000000CC")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex4)
				{
					Debug.Log("_SmallTex" + ex4.Message);
				}
			}
			if (mapEvent.data[1] == "OK")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("GameVolumeSlider")[6];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("No Name" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("OnReadyClick", new Color(1225f, 403f, 442f));
			GetComponentInChildren<Renderer>().material.SetColor("_Radius2", new Color(1212f, 789f, 432f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	private float GMKHJPPNECM()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[0] != null)
		{
			if (mapEvent.data[1] == "st")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(FGHAMCNIHMN).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[1])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Gameplay).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(KPCNFNPFPJB).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find((MapEditor.EventsCanvas IACGDFHKCAE) => IACGDFHKCAE.forType == MapEditor.EventType.Storyboard).grid.position.y;
	}

	private float FBAIFGMPFKP()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[0] != null)
		{
			if (mapEvent.data[1] == "_ReflectionTexture2")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(NDNMONPHGPH).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[0])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(KKIPNANJDPP).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(CAJOHGJJBDL).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(ODBLBKBIEMG).grid.position.y;
	}

	private static bool ODBLBKBIEMG(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	[CompilerGenerated]
	private static bool NGHEMEHKJIG(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private bool OFECECCNHDI(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[0] = '`';
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	private static bool OAEOHOFMJEJ(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void FMKOPONFFOH()
	{
		isSelected = true;
		GKKAJOHEJCG();
	}

	[SpecialName]
	public void AJHMKMAHDFK(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
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

	private bool FIMKBBONPKO(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1]);
	}

	[CompilerGenerated]
	private bool BMJDNECLLIG(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1].Split(',')[0]);
	}

	public void LPJFCLNOFAF()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 117f)
		{
			mapEvent.time = 54f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = IHNJPGPOEIP();
		base.transform.localPosition = localPosition;
	}

	[SpecialName]
	public bool GGECOKCHILN()
	{
		return LJBEFJHAOFL;
	}

	public void IKGCJBNDHIA()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 966f)
		{
			mapEvent.time = 1161f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = GMKHJPPNECM();
		base.transform.localPosition = localPosition;
	}

	public void KDHAMIJPEIO()
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
			GetComponentInChildren<Renderer>().material.SetColor("Tab2Content", new Color(1070f, 1093f, 1467f));
			GetComponentInChildren<Renderer>().material.SetColor("CameraFilterPack/TV_CompressionFX", new Color(918f, 1375f, 940f));
			if (mapEvent.data[1] == "menu.copyright")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[0]);
					imageRight.sprite = Resources.LoadAll<Sprite>("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}")[1];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(true);
				}
				catch (Exception ex)
				{
					Debug.Log("GO==null" + ex.Message);
				}
			}
			if (mapEvent.data[0] == "settings_bindings_controller_type")
			{
				scaleMult.y = 491f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("CameraFilterPack_Fly_VisionFX", new Color(918f, 570f, 1135f));
					GetComponentInChildren<Renderer>().material.SetColor("_Blend", new Color(1750f, 1676f, 1364f));
				}
				catch (Exception ex2)
				{
					Debug.Log("," + ex2.Message);
				}
			}
			if (mapEvent.data[0] == ",")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[0];
					array[0] = 'ﾱ';
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
							imageRight.color = new Color(369f, 842f, 492f);
							imageRight.color = new Color(139f, 1540f, 760f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(true);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("Failed to 'network-remove' GameObject because it's null." + ex3.Message);
				}
			}
			if (mapEvent.data[0] == "LevelNameText")
			{
				try
				{
					int num = 1;
					string text2 = mapEvent.data[0];
					char[] array3 = new char[0];
					array3[1] = '!';
					num = ((text2.Split(array3).Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(EEIGDBBFLEM)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FIMKBBONPKO)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("_InternalLutParams")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("_Value3" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "Exception caught! ")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("#ok")[2];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(false);
					imageCenter.gameObject.SetActive(false);
				}
				catch (Exception ex5)
				{
					Debug.Log("powerup.1" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("\\", new Color(1763f, 807f, 585f));
			GetComponentInChildren<Renderer>().material.SetColor("RanksButton", new Color(590f, 1517f, 755f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	private static bool IFHMHIECIHL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool AHDLNGNKIFL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	[CompilerGenerated]
	private static bool MJOAAPFDHNH(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void DMNDGIIEAKI()
	{
		MFEPCILLECI(true);
		BEMGANLFMJJ();
	}

	[SpecialName]
	public bool HGEPOPKNKID()
	{
		return LJBEFJHAOFL;
	}

	private bool LNJAMEAPMDG(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1]);
	}

	public void BOBMDOJALEC()
	{
		MFEPCILLECI(false);
		EKAGILPDBCN();
	}

	[CompilerGenerated]
	private bool BKKMOPKHAIE(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1]);
	}

	[SpecialName]
	public bool JPJEINKPMKA()
	{
		return LJBEFJHAOFL;
	}

	private static bool KKIPNANJDPP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	[SpecialName]
	public bool FGNCJCMNDIN()
	{
		return LJBEFJHAOFL;
	}

	[SpecialName]
	public bool FIJPHPCKEKH()
	{
		return LJBEFJHAOFL;
	}

	public void MMBPLGGLPDB()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 227f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1416f, Camera.main.orthographicSize / 605f, 1429f);
		}
	}

	[SpecialName]
	public void BKEDJGGEIGB(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	public void MLNPNMLBKHI()
	{
		if (mapEvent.data == null || lastDataCount == mapEvent.data.Count)
		{
			return;
		}
		iconSprite.SetActive(true);
		imageRight.gameObject.SetActive(true);
		imageCenter.gameObject.SetActive(false);
		if (!string.IsNullOrEmpty(mapEvent.data[0]))
		{
			GetComponentInChildren<Renderer>().material.SetColor("SetBGColor", new Color(1161f, 1480f, 1376f));
			GetComponentInChildren<Renderer>().material.SetColor(" ", new Color(1000f, 1087f, 1079f));
			if (mapEvent.data[0] == "inventory.selected.")
			{
				try
				{
					Color color = Helpers.StringToColor(mapEvent.data[1]);
					imageRight.sprite = Resources.LoadAll<Sprite>("CameraFilterPack/Blur_GaussianBlur")[0];
					imageRight.color = color;
					iconSprite.SetActive(false);
					imageRight.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					Debug.Log("ns" + ex.Message);
				}
			}
			if (mapEvent.data[1] == "JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.")
			{
				scaleMult.y = 423f;
				try
				{
					GetComponentInChildren<Renderer>().material.SetColor("SetParticlesCountPerBeat", new Color(226f, 703f, 1342f));
					GetComponentInChildren<Renderer>().material.SetColor("Scene", new Color(1938f, 311f, 328f));
				}
				catch (Exception ex2)
				{
					Debug.Log("value" + ex2.Message);
				}
			}
			if (mapEvent.data[1] == "#timeuntilchallenge: ")
			{
				try
				{
					string text = mapEvent.data[0];
					char[] array = new char[1];
					array[1] = '\n';
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
							imageRight.color = new Color(433f, 1643f, 1200f);
							imageRight.color = new Color(1818f, 1952f, 779f);
						}
						iconSprite.SetActive(false);
						imageRight.gameObject.SetActive(false);
					}
				}
				catch (Exception ex3)
				{
					Debug.Log("[Left]" + ex3.Message);
				}
			}
			if (mapEvent.data[0] == ",")
			{
				try
				{
					int num = 0;
					num = ((mapEvent.data[1].Split('ￄ').Length != 1) ? Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(EEIGDBBFLEM)) : Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(FIMKBBONPKO)));
					imageCenter.sprite = Resources.LoadAll<Sprite>("Gameplay/particles")[num];
					imageCenter.color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex4)
				{
					Debug.Log("0,2,true,0" + ex4.Message);
				}
			}
			if (mapEvent.data[0] == "open")
			{
				try
				{
					imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack/NightVision_4")[2];
					imageCenter.GetComponentInChildren<Image>().color = Color.white;
					iconSprite.SetActive(true);
					imageCenter.gameObject.SetActive(true);
				}
				catch (Exception ex5)
				{
					Debug.Log("_ScreenResolution" + ex5.Message);
				}
			}
		}
		else
		{
			GetComponentInChildren<Renderer>().material.SetColor("[MapsData] Found ", new Color(846f, 1323f, 1159f));
			GetComponentInChildren<Renderer>().material.SetColor("GlassAberration", new Color(133f, 1763f, 1126f));
		}
		lastDataCount = mapEvent.data.Count;
	}

	public void ONALEHODPJO()
	{
		EINLEAFPPOL(true);
		MLNPNMLBKHI();
	}

	public void MFILDNIGKGO()
	{
		BKEDJGGEIGB(true);
		EKAGILPDBCN();
	}

	private static bool EJLKFCEBFEN(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void Select()
	{
		isSelected = true;
		UpdateIcon();
	}

	public void CMHOENHNEEL()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 1557f)
		{
			mapEvent.time = 517f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = IHNJPGPOEIP();
		base.transform.localPosition = localPosition;
	}

	public void GAAICNOFMNJ()
	{
		DKHEBPFKBCI(true);
		UpdateIcon();
	}

	private static bool OJIIBAOHENA(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private void JNBMKLFJCEM()
	{
		BCLLPELLKKP(true);
	}

	public void IDIIELPAMCJ()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 532f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 596f, Camera.main.orthographicSize / 1534f, 1939f);
		}
	}

	private bool APAFIDOEJBA(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[0]);
	}

	[SpecialName]
	public bool HHNOHJJLMHN()
	{
		return LJBEFJHAOFL;
	}

	private bool BCKBIPBLMDE(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1].Split('ￖ')[0]);
	}

	[SpecialName]
	public void MFEPCILLECI(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	[SpecialName]
	public void BCLLPELLKKP(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	private static bool DOHJKGPFNEA(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void DGGCBKJBFCM()
	{
		AJHMKMAHDFK(true);
		HKEDNOKBCCG();
	}

	private static bool NGKFJOMEJFD(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	[CompilerGenerated]
	private static bool CLOOIEFPKIA(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	public void JNPLGFCCPHA()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 592f)
		{
			mapEvent.time = 1590f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = MJNJJOHPKPN();
		base.transform.localPosition = localPosition;
	}

	private static bool LEPFFADBPOF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private static bool CKMIJAHMFDL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	[SpecialName]
	public bool HFEGEHHPPFG()
	{
		return LJBEFJHAOFL;
	}

	private void LFFAKAOAOCN()
	{
		EINLEAFPPOL(false);
	}

	public void OMCLOFCJMPG()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1291f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1522f, Camera.main.orthographicSize / 445f, 962f);
		}
	}

	[CompilerGenerated]
	private static bool DJKGOFFKGMF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private static bool KGEEKIBHCJM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void CGPHOALLNKG()
	{
		BKEDJGGEIGB(false);
		HKEDNOKBCCG();
	}

	private bool INOEBLIDKCH(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[0]);
	}

	public void HGMOKFLGAKG()
	{
		MFEPCILLECI(false);
		HKEDNOKBCCG();
	}

	public void HOBPIHKCKOA()
	{
		EINLEAFPPOL(true);
		KDHAMIJPEIO();
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

	public void NKLIHNJCHOG()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 142f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1695f, Camera.main.orthographicSize / 964f, 113f);
		}
	}

	private static bool DFBEBLPCKAB(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void KELLAMNDMKJ()
	{
		AJHMKMAHDFK(true);
		HKEDNOKBCCG();
	}

	private bool DONNMFALNII(string IACGDFHKCAE)
	{
		string text = mapEvent.data[1];
		char[] array = new char[1];
		array[1] = '\uffd8';
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	[SpecialName]
	public void EINLEAFPPOL(bool DPNHODJHGJL)
	{
		LJBEFJHAOFL = DPNHODJHGJL;
		selectedMarker.SetActive(LJBEFJHAOFL);
	}

	public void DFJJIEJGFEF()
	{
		AJHMKMAHDFK(true);
		BEMGANLFMJJ();
	}

	public void CMNPEMEIJEJ()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip != null)
		{
			LPJFCLNOFAF();
			mapEvent.time = base.transform.localPosition.x;
			UpdateIcon();
			Update();
		}
	}

	public void PKCGDOHEGCA()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 1694f)
		{
			mapEvent.time = 1247f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = GMKHJPPNECM();
		base.transform.localPosition = localPosition;
	}

	private bool MFJKFJBMBAJ(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[0] = 'D';
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	private float EILECBGLFGJ()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[0] != null)
		{
			if (mapEvent.data[0] == "RecordButton")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(DIHILOHGBAM).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[0])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(EJLKFCEBFEN).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(CAJOHGJJBDL).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(NCALDGPEJCK).grid.position.y;
	}

	private static bool JPGCCLDADHO(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	private bool MDFEGPFDONL(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[1] = '\u0014';
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	public void DHLHKPJNKNC()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 1140f)
		{
			mapEvent.time = 1685f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = MJNJJOHPKPN();
		base.transform.localPosition = localPosition;
	}

	private float MJNJJOHPKPN()
	{
		if (mapEvent != null && mapEvent.data != null && mapEvent.data[1] != null)
		{
			if (mapEvent.data[1] == "EventSystem")
			{
				return Singleton<MapEditor>.Instance.eventsCanvases.Find(KGEEKIBHCJM).grid.position.y;
			}
			return (!Helpers.IsStoryboardEvent(mapEvent.data[1])) ? Singleton<MapEditor>.Instance.eventsCanvases.Find(EJLKFCEBFEN).grid.position.y : Singleton<MapEditor>.Instance.eventsCanvases.Find(NGKFJOMEJFD).grid.position.y;
		}
		return Singleton<MapEditor>.Instance.eventsCanvases.Find(NCALDGPEJCK).grid.position.y;
	}

	public void GEEFMELBHCA()
	{
		AJHMKMAHDFK(false);
		BEMGANLFMJJ();
	}

	public void EDJHABOOHKN()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (mapEvent.time < 15f)
		{
			mapEvent.time = 1863f;
		}
		if (mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length)
		{
			mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = mapEvent.time;
		localPosition.y = EILECBGLFGJ();
		base.transform.localPosition = localPosition;
	}

	private bool IGPBEJKFEOK(string IACGDFHKCAE)
	{
		string text = mapEvent.data[1];
		char[] array = new char[0];
		array[0] = 'ￂ';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
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

	[SpecialName]
	public bool DBGGELDMBCN()
	{
		return LJBEFJHAOFL;
	}

	private static bool FGHAMCNIHMN(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	private void PPCGJBIIFAO()
	{
		EINLEAFPPOL(true);
	}

	private bool CHJGMEEPGMM(string IACGDFHKCAE)
	{
		string text = mapEvent.data[0];
		char[] array = new char[0];
		array[1] = 'ﾉ';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	private bool FNIJFIJGOON(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(mapEvent.data[1]);
	}

	private void GLGOLEOAFOD()
	{
		MFEPCILLECI(true);
	}

	public void OBAEDJJDCPN()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 817f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1972f, Camera.main.orthographicSize / 1865f, 522f);
		}
	}

	public void PHPOCLOJFIB()
	{
		DKHEBPFKBCI(true);
		EKAGILPDBCN();
	}

	private static bool KIPPBGFAFLD(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	public void NEPBGJLOCNH()
	{
		EINLEAFPPOL(false);
		GKKAJOHEJCG();
	}

	public void DGCGGKMNPLD()
	{
		if (bitObj != null && bitObj.activeSelf)
		{
			bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1969f, scaleMult.y, scaleMult.z);
		}
		if (iconSprite != null && iconSprite.activeSelf)
		{
			iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1365f, Camera.main.orthographicSize / 1245f, 1031f);
		}
	}

	private static bool NDNMONPHGPH(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}
}
