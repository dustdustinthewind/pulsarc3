// CameraFilterPack_TV_CompressionFX
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glitch/Compression FX")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_CompressionFX : MonoBehaviour
{
	public Shader SCShader;

	private Vector4 GOIJPFAHKPE;

	private float HBJJOCHGOPH = 1f;

	[Range(-10f, 10f)]
	public float Parasite = 1f;

	private Material BJFKDHHMLJH;

	private Material NBPKMLMCHFN
	{
		get
		{
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return BJFKDHHMLJH;
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1236f)
			{
				HBJJOCHGOPH = 1922f;
			}
			NBPKMLMCHFN.SetFloat("BitsData", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("[ERROR KEY {0}]", Parasite);
			MNLKBFFKHIE().SetVector("Failed to Instantiate prefab: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1767f, 110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("_CenterRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find("Current xp: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LKJMIODJGCM()
	{
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 105f)
			{
				HBJJOCHGOPH = 230f;
			}
			HHIFMIPPMPF().SetFloat("Copy from ", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat(".completedMaps", Parasite);
			OCMBHMLNCEK().SetVector("BloomShaderValueSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1455f, 154f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_CompressionFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1008f)
			{
				HBJJOCHGOPH = 1024f;
			}
			GJHLADDCMFF().SetFloat("No valid adaptive tonemapper type found!", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" - StoreAuthURLResponse] - ", Parasite);
			LPMLLJKMAMP().SetVector("CameraFilterPack/TV_VHS_Rewind", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 113f, 872f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ADPLHDFJFID()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1264f)
			{
				HBJJOCHGOPH = 524f;
			}
			LPPEPKGFOEM().SetFloat("shaders", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("GroupNameText", Parasite);
			LPCHMEKDCHI().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1091f, 1857f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 952f)
			{
				HBJJOCHGOPH = 535f;
			}
			PGPEMMBJOOG().SetFloat("GetGameList failed: ", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("pointBuffer", Parasite);
			DOMEEFLPEPJ().SetVector("SetSunInput", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1708f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AKCADICOFDD()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_LutTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1564f)
			{
				HBJJOCHGOPH = 1606f;
			}
			OHKGGPFGLFD().SetFloat("_ClutTex", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("#done", Parasite);
			KLKILLCHJHO().SetVector("Please attach component to a Graphical UI component", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 410f, 1841f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKDEEJFNNJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LPMINJJPDCH()
	{
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 784f)
			{
				HBJJOCHGOPH = 1058f;
			}
			DOHGBNPMBKG().SetFloat("_FixDistance", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("_EmissionColor", Parasite);
			JFDGLLEOPGB().SetVector("FileMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 458f, 1729f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KHIGHFJKPFG()
	{
		SCShader = Shader.Find("_EdgeSharpness");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("PlayMapGoal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void ANKIJGCGCBF()
	{
	}

	private void HIFLPHLGLFG()
	{
	}

	private void FABMDEHEDNO()
	{
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1512f)
			{
				HBJJOCHGOPH = 559f;
			}
			LMLENGFLEBD().SetFloat("_TimeX", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("_Blue_B", Parasite);
			JFDGLLEOPGB().SetVector("UndoButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 738f, 704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("[Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 924f)
			{
				HBJJOCHGOPH = 1368f;
			}
			DOHGBNPMBKG().SetFloat("Changed config", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("Arc", Parasite);
			ELBMIEOIABA().SetVector("[MapEditor] Loading map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1079f, 1345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1497f)
			{
				HBJJOCHGOPH = 1904f;
			}
			EHDJJANLINB().SetFloat("Set particles audio input", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("settings.arcsnohitsoundtimedelay", Parasite);
			DOHGBNPMBKG().SetVector("QuickSave", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 539f, 1333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void BGFJOEPFOPM()
	{
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 842f)
			{
				HBJJOCHGOPH = 940f;
			}
			KLKILLCHJHO().SetFloat("seconds", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("Clears the console and prints the logs in the specified range", Parasite);
			EHDJJANLINB().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1401f, 1964f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KLKILLCHJHO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1754f)
			{
				HBJJOCHGOPH = 1768f;
			}
			PGPEMMBJOOG().SetFloat("MessageText", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("note.3", Parasite);
			EHDJJANLINB().SetVector("_Green_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 21f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void INLDEHPAMJC()
	{
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCDJFJIBADI()
	{
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return BJFKDHHMLJH;
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1216f)
			{
				HBJJOCHGOPH = 12f;
			}
			ACHNOHCLGOO().SetFloat("yyyy-MM-dd HH:mm:ss", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("CameraFilterPack/AAA_Blood", Parasite);
			HHIFMIPPMPF().SetVector("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 794f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1467f)
			{
				HBJJOCHGOPH = 1973f;
			}
			PGPEMMBJOOG().SetFloat("#onrankchangeuptext", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", Parasite);
			HHIFMIPPMPF().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1336f, 690f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("Despawn environment object by id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return BJFKDHHMLJH;
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1718f)
			{
				HBJJOCHGOPH = 1073f;
			}
			LMLENGFLEBD().SetFloat("musicVolume", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_Value4", Parasite);
			GJHLADDCMFF().SetVector("CameraFilterPack/Pixelisation_OilPaint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 580f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 276f)
			{
				HBJJOCHGOPH = 492f;
			}
			LPPEPKGFOEM().SetFloat("_TimeX", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("Editor/", Parasite);
			GJHLADDCMFF().SetVector("_Near", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 505f, 1179f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 920f)
			{
				HBJJOCHGOPH = 826f;
			}
			KAFBNOBOIAJ().SetFloat("#obtained", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat(".mp3", Parasite);
			LMLENGFLEBD().SetVector("MenuScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 200f, 1197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FAMLCFNDGNI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 713f)
			{
				HBJJOCHGOPH = 425f;
			}
			MNLKBFFKHIE().SetFloat("Missing shader in ", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("_BlurTex", Parasite);
			GJHLADDCMFF().SetVector("[LocalizationService] Loading file: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 255f, 812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 916f)
			{
				HBJJOCHGOPH = 957f;
			}
			JFDGLLEOPGB().SetFloat("Hex value #RRGGBB", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Hex value #RRGGBB", Parasite);
			LPCHMEKDCHI().SetVector("\r", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1326f, 599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("player.greenlollipop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("settings.disablestoryboard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 92f)
			{
				HBJJOCHGOPH = 210f;
			}
			OHKGGPFGLFD().SetFloat("_Value3", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Exposure", Parasite);
			CFEDGDGBCHE().SetVector("OpJoinLobby()", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 60f, 1634f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OBDEJFCNOBF()
	{
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("https://store.steampowered.com/itemstore/513510/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 346f)
			{
				HBJJOCHGOPH = 527f;
			}
			ABHDNGIHBKE().SetFloat("Identity LUT", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("Gameplay/Segment-[PowerUp]", Parasite);
			OHKGGPFGLFD().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1969f, 1288f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("menutheme.27thfloor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find(" Message: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void LBIOIEANMGI()
	{
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void PBEPCAPAKLG()
	{
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("_Green_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JABNHMIHBHC()
	{
		SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("settings.hitvariation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 224f)
			{
				HBJJOCHGOPH = 458f;
			}
			FEAEGGCNIAA().SetFloat("original.tutorial", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Anomaly", Parasite);
			LMLENGFLEBD().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1602f, 1527f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 253f)
			{
				HBJJOCHGOPH = 267f;
			}
			DOHGBNPMBKG().SetFloat("_Value", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_Gamma", Parasite);
			ELBMIEOIABA().SetVector("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 631f, 1289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1506f)
			{
				HBJJOCHGOPH = 1906f;
			}
			HHIFMIPPMPF().SetFloat("FinalScoreSmallText", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("UseScanLineSize", Parasite);
			DOMEEFLPEPJ().SetVector("Message duration multiplier. Recomended 1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1467f, 896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void JGMEKCFHGLE()
	{
	}

	private void GCHBGCGBMCK()
	{
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 119f)
			{
				HBJJOCHGOPH = 1617f;
			}
			MNLKBFFKHIE().SetFloat("Set particles start speed", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Parasite);
			LMLENGFLEBD().SetVector("Set Crosshair Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1976f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("Drop_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("offline room");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MANDOGNJJBD()
	{
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1841f)
			{
				HBJJOCHGOPH = 197f;
			}
			NBPKMLMCHFN.SetFloat("[Right-Left]", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("SetPosition", Parasite);
			MNLKBFFKHIE().SetVector(" | ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 182f, 409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ELBMIEOIABA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("Anomaly_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 931f)
			{
				HBJJOCHGOPH = 1692f;
			}
			KLKILLCHJHO().SetFloat("s", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("SpawnObj", Parasite);
			DOMEEFLPEPJ().SetVector("curScn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 80f, 147f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1446f)
			{
				HBJJOCHGOPH = 260f;
			}
			KLKILLCHJHO().SetFloat("_Bloom4", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Version 1.0", Parasite);
			EHDJJANLINB().SetVector("owner: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1401f, 1363f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Parasite", Parasite);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1099f)
			{
				HBJJOCHGOPH = 1618f;
			}
			LPPEPKGFOEM().SetFloat("_InternalLutTex", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("ItemNameText", Parasite);
			OHKGGPFGLFD().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 215f, 946f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1776f)
			{
				HBJJOCHGOPH = 1894f;
			}
			ABHDNGIHBKE().SetFloat("Parameter levelId must be int or string!", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("speed", Parasite);
			KLKILLCHJHO().SetVector("_DistortionLevel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1466f, 1561f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("Joystick1Button11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("#,0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JBMBNKOOENB()
	{
	}
}
